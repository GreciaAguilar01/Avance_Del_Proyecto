using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Avance_Del_Proyecto
{
    public partial class Pagos_Abonos : Form
    {
        string SQLconection = "Server=localhost;Port=3306;Database=sigeo_db;Uid=root;Pwd=root;";

        private int idPedidoSeleccionado = -1;
        private decimal totalPedido = 0;
        private decimal abonadoPedido = 0;

        public Pagos_Abonos() => InitializeComponent();

        // ═══════════════════════════════════════════════════════
        //  CARGA INICIAL
        // ═══════════════════════════════════════════════════════
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarPacientes();

            lboxNombresPacientes.SelectedIndexChanged += LboxNombresPacientes_SelectedIndexChanged;
            lboxPedidosPacientes.SelectedIndexChanged += LboxPedidosPacientes_SelectedIndexChanged;
            btnRecibirPago.Click += BtnRecibirPago_Click;
            btnRecibirAbono.Click += BtnRecibirAbono_Click;
            btnCancelarOperacion.Click += BtnCancelarOperacion_Click;
        }

        // ═══════════════════════════════════════════════════════
        //  CARGAR PACIENTES
        // ═══════════════════════════════════════════════════════
        private void CargarPacientes()
        {
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                string query = "SELECT id_paciente, nombre_completo FROM pacientes ORDER BY nombre_completo";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lboxNombresPacientes.DataSource = dt;
                lboxNombresPacientes.DisplayMember = "nombre_completo";
                lboxNombresPacientes.ValueMember = "id_paciente";
            }
        }

        // ═══════════════════════════════════════════════════════
        //  AL SELECCIONAR PACIENTE
        // ═══════════════════════════════════════════════════════
        private void LboxNombresPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxNombresPacientes.SelectedItem == null) return;

            DataRowView drv = (DataRowView)lboxNombresPacientes.SelectedItem;
            int idPaciente = Convert.ToInt32(drv["id_paciente"]);
            lblNombrePaciente.Text = drv["nombre_completo"].ToString();

            idPedidoSeleccionado = -1;
            totalPedido = 0;
            abonadoPedido = 0;

            CargarPedidosPaciente(idPaciente);
        }

        private void CargarPedidosPaciente(int idPaciente)
        {
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                string query = @"
                    SELECT id_pedido, fecha, total, abonado, estado,
                           (total - abonado) AS saldo
                    FROM pedidos
                    WHERE id_paciente = @idp
                    ORDER BY fecha DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@idp", idPaciente);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lboxPedidosPacientes.DataSource = null;
                lboxPedidosPacientes.Items.Clear();

                foreach (DataRow r in dt.Rows)
                {
                    string fecha = Convert.ToDateTime(r["fecha"]).ToString("dd/MM/yyyy");
                    string estado = r["estado"].ToString() == "pagado" ? "✅ Pagado" : "⏳ Pendiente";
                    decimal saldo = Convert.ToDecimal(r["saldo"]);

                    lboxPedidosPacientes.Items.Add(new PedidoItem
                    {
                        Display = $"#{r["id_pedido"]}  |  {fecha}  |  Total: ${Convert.ToDecimal(r["total"]):F2}  |  Saldo: ${saldo:F2}  |  {estado}",
                        IdPedido = Convert.ToInt32(r["id_pedido"]),
                        Total = Convert.ToDecimal(r["total"]),
                        Abonado = Convert.ToDecimal(r["abonado"]),
                        Saldo = saldo,
                        Estado = r["estado"].ToString()
                    });
                }
            }
        }

        // ═══════════════════════════════════════════════════════
        //  AL SELECCIONAR UN PEDIDO
        // ═══════════════════════════════════════════════════════
        private void LboxPedidosPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxPedidosPacientes.SelectedItem is PedidoItem item)
            {
                idPedidoSeleccionado = item.IdPedido;
                totalPedido = item.Total;
                abonadoPedido = item.Abonado;
            }
        }

        // ═══════════════════════════════════════════════════════
        //  RECIBIR PAGO COMPLETO
        // ═══════════════════════════════════════════════════════
        private void BtnRecibirPago_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;

            PedidoItem item = (PedidoItem)lboxPedidosPacientes.SelectedItem;

            if (item.Estado == "pagado")
            {
                MessageBox.Show("Este pedido ya está pagado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Saldo pendiente: ${item.Saldo:F2}\nIngresa el monto recibido:",
                "Recibir pago", item.Saldo.ToString("F2"));

            if (string.IsNullOrWhiteSpace(input)) return;

            if (!decimal.TryParse(input, out decimal montoPagado))
            {
                MessageBox.Show("Monto inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (montoPagado < item.Saldo)
            {
                MessageBox.Show($"Monto insuficiente. Faltan: ${item.Saldo - montoPagado:F2}\nUsa 'Recibir abono' para pagos parciales.",
                    "Pago incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ActualizarPedidoBD(item.IdPedido, item.Abonado + item.Saldo, "pagado");
            decimal cambio = montoPagado - item.Saldo;
            GenerarTicketPDF(item, "Pago completo", montoPagado, 0);

            string msg = $"✅ Pedido #{item.IdPedido} liquidado.";
            if (cambio > 0) msg += $"\nCambio: ${cambio:F2}";
            MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarPedidos();
        }

        // ═══════════════════════════════════════════════════════
        //  RECIBIR ABONO
        // ═══════════════════════════════════════════════════════
        private void BtnRecibirAbono_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;

            PedidoItem item = (PedidoItem)lboxPedidosPacientes.SelectedItem;

            if (item.Estado == "pagado")
            {
                MessageBox.Show("Este pedido ya está pagado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Saldo pendiente: ${item.Saldo:F2}\nIngresa el monto del abono:",
                "Recibir abono", "");

            if (string.IsNullOrWhiteSpace(input)) return;

            if (!decimal.TryParse(input, out decimal abono) || abono <= 0)
            {
                MessageBox.Show("Monto inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (abono >= item.Saldo)
            {
                MessageBox.Show("El abono cubre el total. Usa 'Recibir pago'.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal nuevoAbonado = item.Abonado + abono;
            decimal nuevoSaldo = item.Total - nuevoAbonado;

            ActualizarPedidoBD(item.IdPedido, nuevoAbonado, "abono");
            GenerarTicketPDF(item, "Abono", abono, nuevoSaldo);

            MessageBox.Show($"✅ Abono de ${abono:F2} registrado.\nSaldo pendiente: ${nuevoSaldo:F2}",
                "Abono registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarPedidos();
        }

        // ═══════════════════════════════════════════════════════
        //  CANCELAR OPERACIÓN
        // ═══════════════════════════════════════════════════════
        private void BtnCancelarOperacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ═══════════════════════════════════════════════════════
        //  ACTUALIZAR PEDIDO EN BD
        // ═══════════════════════════════════════════════════════
        private void ActualizarPedidoBD(int idPedido, decimal nuevoAbonado, string estado)
        {
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                string sql = "UPDATE pedidos SET abonado = @ab, estado = @est WHERE id_pedido = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ab", nuevoAbonado);
                cmd.Parameters.AddWithValue("@est", estado);
                cmd.Parameters.AddWithValue("@id", idPedido);
                cmd.ExecuteNonQuery();
            }
        }

        // ═══════════════════════════════════════════════════════
        //  GENERAR TICKET PDF
        // ═══════════════════════════════════════════════════════
        private void GenerarTicketPDF(PedidoItem item, string tipoPago, decimal montoPagado, decimal saldo)
        {
            string carpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "SIGEO_Tickets");
            Directory.CreateDirectory(carpeta);

            string archivo = Path.Combine(carpeta,
                $"Ticket_Pedido_{item.IdPedido}_{DateTime.Now:yyyyMMdd_HHmm}.pdf");

            DataTable productos = new DataTable();
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                string query = @"
                    SELECT CONCAT(p.codigo, ' - ', p.nombre) AS nombre_display, dp.precio_unitario
                    FROM detalle_pedido dp
                    JOIN productos p ON dp.id_producto = p.id_producto
                    WHERE dp.id_pedido = @id";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", item.IdPedido);
                da.Fill(productos);
            }

            using (FileStream fs = new FileStream(archivo, FileMode.Create))
            {
                Document doc = new Document(PageSize.A5, 30, 30, 30, 30);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, false);
                BaseFont bfNormal = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                var fTitulo = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.NORMAL, new BaseColor(0, 130, 74));
                var fNormal = new iTextSharp.text.Font(bfNormal, 10);
                var fBold = new iTextSharp.text.Font(bf, 10);
                var fTotal = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL, new BaseColor(0, 100, 50));
                var fPeq = new iTextSharp.text.Font(bfNormal, 8, iTextSharp.text.Font.NORMAL, BaseColor.GRAY);

                doc.Add(new Paragraph("SIGEO - Ortopedia", fTitulo) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph("Comprobante de Pago", fBold) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph($"Pedido #:  {item.IdPedido}", fNormal));
                doc.Add(new Paragraph($"Fecha:     {DateTime.Now:dd/MM/yyyy HH:mm}", fNormal));
                doc.Add(new Paragraph($"Paciente:  {lblNombrePaciente.Text}", fNormal));
                doc.Add(new Paragraph($"Tipo pago: {tipoPago} ({ObtenerTipoPago()})", fNormal));
                doc.Add(new Paragraph("─────────────────────────────────", fPeq));

                PdfPTable tabla = new PdfPTable(2) { WidthPercentage = 100 };
                tabla.SetWidths(new float[] { 3f, 1f });

                var hProd = new PdfPCell(new Phrase("Producto", fBold))
                { BackgroundColor = new BaseColor(0, 130, 74), BorderWidth = 0, Padding = 4 };
                var hPrecio = new PdfPCell(new Phrase("Precio", fBold))
                { BackgroundColor = new BaseColor(0, 130, 74), BorderWidth = 0, Padding = 4, HorizontalAlignment = Element.ALIGN_RIGHT };
                var fEncabezado = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL, BaseColor.WHITE);
                tabla.AddCell(hProd);
                tabla.AddCell(hPrecio);

                foreach (DataRow r in productos.Rows)
                {
                    tabla.AddCell(new PdfPCell(new Phrase(r["nombre_display"].ToString(), fNormal))
                    { BorderWidth = 0, Padding = 3 });
                    tabla.AddCell(new PdfPCell(new Phrase($"${Convert.ToDecimal(r["precio_unitario"]):F2}", fNormal))
                    { BorderWidth = 0, Padding = 3, HorizontalAlignment = Element.ALIGN_RIGHT });
                }
                doc.Add(tabla);

                doc.Add(new Paragraph("─────────────────────────────────", fPeq));
                doc.Add(new Paragraph($"TOTAL:           ${item.Total:F2}", fTotal));
                doc.Add(new Paragraph($"Monto pagado:    ${montoPagado:F2}", fBold));

                if (saldo > 0)
                    doc.Add(new Paragraph($"Saldo pendiente: ${saldo:F2}",
                        new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.NORMAL, BaseColor.RED)));
                else
                    doc.Add(new Paragraph("PAGADO EN SU TOTALIDAD",
                        new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.NORMAL, new BaseColor(0, 130, 74))));

                doc.Add(new Paragraph("\n¡Gracias por su preferencia!", fPeq) { Alignment = Element.ALIGN_CENTER });
                doc.Close();
            }

            MessageBox.Show($"Ticket guardado en:\n{archivo}", "PDF generado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ═══════════════════════════════════════════════════════
        //  HELPERS
        // ═══════════════════════════════════════════════════════
        private bool ValidarSeleccion()
        {
            if (lboxNombresPacientes.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un paciente primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (lboxPedidosPacientes.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un pedido de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private string ObtenerTipoPago()
        {
            if (rbtnPagoTarjetaDebito.Checked) return "Tarjeta de débito";
            if (rbtnPagoTarjetaCredito.Checked) return "Tarjeta de crédito";
            if (rbtnTransferencia.Checked) return "Transferencia";
            return "Efectivo";
        }

        private void RefrescarPedidos()
        {
            if (lboxNombresPacientes.SelectedItem is DataRowView drv)
                CargarPedidosPaciente(Convert.ToInt32(drv["id_paciente"]));
        }

        // Eventos vacíos requeridos por el designer original
        private void lblNombrePaciente_Click(object sender, EventArgs e) { }
        private void btnCancelarOperacion_Click(object sender, EventArgs e) { }
    }

    // ── Clase auxiliar para items del listbox de pedidos ─────
    public class PedidoItem
    {
        public string Display { get; set; }
        public int IdPedido { get; set; }
        public decimal Total { get; set; }
        public decimal Abonado { get; set; }
        public decimal Saldo { get; set; }
        public string Estado { get; set; }
        public override string ToString() => Display;
    }
}