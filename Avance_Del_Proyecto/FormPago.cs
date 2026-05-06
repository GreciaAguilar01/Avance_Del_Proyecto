using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Avance_Del_Proyecto
{
    /// <summary>
    /// Ventana de pago que se abre al presionar "Pagar" en Pedido_Producto.
    /// Permite elegir paciente, tipo de pago y registrar el pedido en BD.
    /// </summary>
    public class FormPago : Form
    {
        private string SQLconection;
        private DataTable tablaOrden;

        // ── controles ─────────────────────────────────────────
        private ListBox     lboxNombresPacientes;
        private RadioButton rbtnEfectivo;
        private RadioButton rbtnDebito;
        private RadioButton rbtnCredito;
        private RadioButton rbtnTransferencia;
        private TextBox     txtMontoPagado;
        private Label       lblTotal;
        private Label       lblMontoLabel;
        private botonRedondeado btnRecibirPago;
        private botonRedondeado btnRecibirAbono;
        private botonRedondeado btnCancelarOperacion;

        private decimal totalOrden = 0;
        private int     idPacienteSeleccionado = -1;

        public FormPago(DataTable orden, string conn)
        {
            tablaOrden   = orden;
            SQLconection = conn;

            foreach (DataRow r in tablaOrden.Rows)
                totalOrden += Convert.ToDecimal(r["precio"]);

            InicializarComponentes();
            CargarPacientes();
        }

        // ═══════════════════════════════════════════════════════
        //  UI
        // ═══════════════════════════════════════════════════════
        private void InicializarComponentes()
        {
            this.Text        = "Registrar Pago";
            this.Size        = new System.Drawing.Size(420, 420);
            this.BackColor   = System.Drawing.Color.FromArgb(242, 207, 176);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition   = FormStartPosition.CenterParent;

            // Paciente
            var lblPaciente = new Label { Text = "Selecciona paciente:", Left = 20, Top = 15, Width = 180,
                Font = new System.Drawing.Font("Comic Sans MS", 9, System.Drawing.FontStyle.Bold) };

            lboxNombresPacientes = new ListBox { Left = 20, Top = 38, Width = 180, Height = 80 };
            lboxNombresPacientes.SelectedIndexChanged += (s, e) =>
            {
                if (lboxNombresPacientes.SelectedItem is DataRowView drv)
                    idPacienteSeleccionado = Convert.ToInt32(drv["id_paciente"]);
            };

            // Tipo de pago
            var lblTipo = new Label { Text = "Tipo de pago:", Left = 220, Top = 15, Width = 160,
                Font = new System.Drawing.Font("Comic Sans MS", 9, System.Drawing.FontStyle.Bold) };

            rbtnEfectivo     = new RadioButton { Text = "Efectivo",            Left = 220, Top = 38,  Width = 160, Checked = true };
            rbtnDebito       = new RadioButton { Text = "Tarjeta de débito",   Left = 220, Top = 62,  Width = 160 };
            rbtnCredito      = new RadioButton { Text = "Tarjeta de crédito",  Left = 220, Top = 86,  Width = 160 };
            rbtnTransferencia= new RadioButton { Text = "Transferencia",        Left = 220, Top = 110, Width = 160 };

            // Total
            lblTotal = new Label
            {
                Text  = $"Total de la orden:  ${totalOrden:F2}",
                Left  = 20, Top = 130, Width = 360,
                Font  = new System.Drawing.Font("Comic Sans MS", 11, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(0, 100, 50)
            };

            // Monto pagado
            lblMontoLabel = new Label { Text = "Monto recibido ($):", Left = 20, Top = 165, Width = 160,
                Font = new System.Drawing.Font("Comic Sans MS", 9) };
            txtMontoPagado = new TextBox { Left = 185, Top = 162, Width = 120, Text = totalOrden.ToString("F2") };

            // Botones
            btnRecibirPago = new botonRedondeado
            {
                Text = "Recibir pago completo", Left = 20, Top = 210,
                Width = 180, Height = 35, BackColor = System.Drawing.Color.Lime,
                FlatStyle = FlatStyle.Flat, BorderRadius = 20,
                Font = new System.Drawing.Font("Comic Sans MS", 8, System.Drawing.FontStyle.Bold)
            };
            btnRecibirPago.Click += BtnRecibirPago_Click;

            btnRecibirAbono = new botonRedondeado
            {
                Text = "Recibir abono", Left = 210, Top = 210,
                Width = 160, Height = 35, BackColor = System.Drawing.Color.Yellow,
                FlatStyle = FlatStyle.Flat, BorderRadius = 20,
                Font = new System.Drawing.Font("Comic Sans MS", 8, System.Drawing.FontStyle.Bold)
            };
            btnRecibirAbono.Click += BtnRecibirAbono_Click;

            btnCancelarOperacion = new botonRedondeado
            {
                Text = "Cancelar operación", Left = 110, Top = 260,
                Width = 180, Height = 35, BackColor = System.Drawing.Color.FromArgb(255, 128, 0),
                FlatStyle = FlatStyle.Flat, BorderRadius = 20,
                Font = new System.Drawing.Font("Comic Sans MS", 8, System.Drawing.FontStyle.Bold)
            };
            btnCancelarOperacion.Click += (s, e) => this.Close();

            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblPaciente, lboxNombresPacientes,
                lblTipo, rbtnEfectivo, rbtnDebito, rbtnCredito, rbtnTransferencia,
                lblTotal, lblMontoLabel, txtMontoPagado,
                btnRecibirPago, btnRecibirAbono, btnCancelarOperacion
            });
        }

        private void CargarPacientes()
        {
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                string query = "SELECT id_paciente, nombre_completo FROM pacientes ORDER BY nombre_completo";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lboxNombresPacientes.DataSource    = dt;
                lboxNombresPacientes.DisplayMember = "nombre_completo";
                lboxNombresPacientes.ValueMember   = "id_paciente";
            }
        }

        // ═══════════════════════════════════════════════════════
        //  RECIBIR PAGO COMPLETO
        // ═══════════════════════════════════════════════════════
        private void BtnRecibirPago_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

            decimal montoPagado;
            if (!decimal.TryParse(txtMontoPagado.Text, out montoPagado))
            {
                MessageBox.Show("Ingresa un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (montoPagado < totalOrden)
            {
                decimal faltante = totalOrden - montoPagado;
                MessageBox.Show($"El monto recibido es insuficiente.\nFaltan: ${faltante:F2}",
                    "Pago incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal cambio = montoPagado - totalOrden;
            int idPedido = GuardarPedidoEnBD("pagado", montoPagado);

            if (idPedido > 0)
            {
                GenerarTicketPDF(idPedido, "Pago completo", montoPagado, 0);
                string msg = $"✅ Pago registrado correctamente.\nPedido #{idPedido}";
                if (cambio > 0) msg += $"\nCambio: ${cambio:F2}";
                MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // ═══════════════════════════════════════════════════════
        //  RECIBIR ABONO
        // ═══════════════════════════════════════════════════════
        private void BtnRecibirAbono_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

            decimal abono;
            if (!decimal.TryParse(txtMontoPagado.Text, out abono) || abono <= 0)
            {
                MessageBox.Show("Ingresa un monto de abono válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (abono >= totalOrden)
            {
                MessageBox.Show("El abono cubre el total. Usa 'Recibir pago completo'.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal saldo = totalOrden - abono;
            int idPedido = GuardarPedidoEnBD("abono", abono);

            if (idPedido > 0)
            {
                GenerarTicketPDF(idPedido, "Abono", abono, saldo);
                MessageBox.Show($"✅ Abono registrado.\nPedido #{idPedido}\nSaldo pendiente: ${saldo:F2}",
                    "Abono registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // ═══════════════════════════════════════════════════════
        //  GUARDAR EN BASE DE DATOS
        // ═══════════════════════════════════════════════════════
        private int GuardarPedidoEnBD(string estado, decimal abonado)
        {
            string tipoPago = ObtenerTipoPago();
            int idPedido = -1;

            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                MySqlTransaction trans = con.BeginTransaction();
                try
                {
                    // 1. Insertar cabecera del pedido
                    string sqlPedido = @"INSERT INTO pedidos 
                        (id_paciente, fecha, tipo_pago, total, abonado, estado)
                        VALUES (@idp, @fecha, @tipo, @total, @abonado, @estado);
                        SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(sqlPedido, con, trans);
                    cmd.Parameters.AddWithValue("@idp",     idPacienteSeleccionado);
                    cmd.Parameters.AddWithValue("@fecha",   DateTime.Now);
                    cmd.Parameters.AddWithValue("@tipo",    tipoPago);
                    cmd.Parameters.AddWithValue("@total",   totalOrden);
                    cmd.Parameters.AddWithValue("@abonado", abonado);
                    cmd.Parameters.AddWithValue("@estado",  estado);

                    idPedido = Convert.ToInt32(cmd.ExecuteScalar());

                    // 2. Insertar detalle (productos)
                    foreach (DataRow r in tablaOrden.Rows)
                    {
                        string sqlDetalle = @"INSERT INTO detalle_pedido 
                            (id_pedido, id_producto, precio_unitario)
                            VALUES (@idPed, @idProd, @precio)";

                        MySqlCommand cmdD = new MySqlCommand(sqlDetalle, con, trans);
                        cmdD.Parameters.AddWithValue("@idPed",  idPedido);
                        cmdD.Parameters.AddWithValue("@idProd", Convert.ToInt32(r["id_producto"]));
                        cmdD.Parameters.AddWithValue("@precio", Convert.ToDecimal(r["precio"]));
                        cmdD.ExecuteNonQuery();
                    }

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show($"Error al guardar: {ex.Message}", "Error BD",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    idPedido = -1;
                }
            }
            return idPedido;
        }

        // ═══════════════════════════════════════════════════════
        //  GENERAR TICKET PDF
        // ═══════════════════════════════════════════════════════
        private void GenerarTicketPDF(int idPedido, string tipoPago, decimal montoPagado, decimal saldo)
        {
            string carpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "SIGEO_Tickets");
            Directory.CreateDirectory(carpeta);

            string archivo = Path.Combine(carpeta, $"Ticket_Pedido_{idPedido}_{DateTime.Now:yyyyMMdd_HHmm}.pdf");

            string nombrePaciente = lboxNombresPacientes.Text;

            using (FileStream fs = new FileStream(archivo, FileMode.Create))
            {
                Document doc = new Document(PageSize.A5, 30, 30, 30, 30);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Fuentes
                BaseFont bf       = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, false);
                BaseFont bfNormal = BaseFont.CreateFont(BaseFont.HELVETICA,      BaseFont.CP1252, false);
                iTextSharp.text.Font fTitulo  = new iTextSharp.text.Font(bf,       16, iTextSharp.text.Font.NORMAL, new BaseColor(0, 130, 74));
                iTextSharp.text.Font fNormal  = new iTextSharp.text.Font(bfNormal, 10);
                iTextSharp.text.Font fBold    = new iTextSharp.text.Font(bf,       10);
                iTextSharp.text.Font fTotal   = new iTextSharp.text.Font(bf,       12, iTextSharp.text.Font.NORMAL, new BaseColor(0, 100, 50));
                iTextSharp.text.Font fPeq     = new iTextSharp.text.Font(bfNormal, 8,  iTextSharp.text.Font.NORMAL, BaseColor.GRAY);

                // Encabezado
                doc.Add(new Paragraph("SIGEO - Ortopedia", fTitulo) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph("Ticket de Compra", fBold)    { Alignment = Element.ALIGN_CENTER });
                doc.Add(new Paragraph($"Pedido #: {idPedido}",  fNormal));
                doc.Add(new Paragraph($"Fecha:    {DateTime.Now:dd/MM/yyyy HH:mm}", fNormal));
                doc.Add(new Paragraph($"Paciente: {nombrePaciente}", fNormal));
                doc.Add(new Paragraph($"Pago:     {tipoPago}", fNormal));
                doc.Add(new Paragraph("─────────────────────────────────", fPeq));

                // Tabla de productos
                PdfPTable tabla = new PdfPTable(2) { WidthPercentage = 100 };
                tabla.SetWidths(new float[] { 3f, 1f });

                // Encabezados de tabla
                PdfPCell hProd  = new PdfPCell(new Phrase("Producto", fBold))  { BackgroundColor = new BaseColor(0, 130, 74), BorderWidth = 0, Padding = 4 };
                PdfPCell hPrecio= new PdfPCell(new Phrase("Precio",   fBold))  { BackgroundColor = new BaseColor(0, 130, 74), BorderWidth = 0, Padding = 4, HorizontalAlignment = Element.ALIGN_RIGHT };
                hProd.Phrase[0].Font.Color  = BaseColor.WHITE;
                hPrecio.Phrase[0].Font.Color= BaseColor.WHITE;
                tabla.AddCell(hProd);
                tabla.AddCell(hPrecio);

                foreach (DataRow r in tablaOrden.Rows)
                {
                    tabla.AddCell(new PdfPCell(new Phrase(r["nombre_display"].ToString(), fNormal)) { BorderWidth = 0, Padding = 3 });
                    tabla.AddCell(new PdfPCell(new Phrase($"${Convert.ToDecimal(r["precio"]):F2}", fNormal)) { BorderWidth = 0, Padding = 3, HorizontalAlignment = Element.ALIGN_RIGHT });
                }
                doc.Add(tabla);

                doc.Add(new Paragraph("─────────────────────────────────", fPeq));
                doc.Add(new Paragraph($"TOTAL:          ${totalOrden:F2}",   fTotal));
                doc.Add(new Paragraph($"Monto pagado:   ${montoPagado:F2}",  fBold));

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
        private bool ValidarFormulario()
        {
            if (idPacienteSeleccionado < 0)
            {
                MessageBox.Show("Selecciona un paciente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private string ObtenerTipoPago()
        {
            if (rbtnDebito.Checked)       return "Tarjeta de débito";
            if (rbtnCredito.Checked)      return "Tarjeta de crédito";
            if (rbtnTransferencia.Checked)return "Transferencia";
            return "Efectivo";
        }
    }
}
