using System;
using System.Data;
using System.IO;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Avance_Del_Proyecto
{
    public partial class Pagos_Abonos : Form
    {
        string SQLconection = "Server=localhost;Port=3306;Database=Ortopedia; Uid=root;Pwd=4444;";

        private int idPacienteActual = -1;
        private string nombrePacienteActual = "";
        private DataTable tablaOrdenRecibida;   // orden que viene de Pedido_Producto
        private int idPedidoSeleccionado = -1;
        private decimal totalPedido = 0;
        private decimal abonadoPedido = 0;

        // Constructor normal (desde menú)
        public Pagos_Abonos()
        {
            InitializeComponent();
        }

        // Constructor desde Pedido_Producto
        public Pagos_Abonos(int idPaciente, string nombrePaciente, DataTable orden)
        {
            InitializeComponent();
            idPacienteActual = idPaciente;
            nombrePacienteActual = nombrePaciente;
            tablaOrdenRecibida = orden;
        }

        //  CARGA INICIAL
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Suscribir eventos
            lboxNombresPacientesPagosAbonos.SelectedIndexChanged += LboxPacientes_SelectedIndexChanged;
            lboxPedidosPacientes.SelectedIndexChanged += LboxPedidos_SelectedIndexChanged;
            btnRecibirPago.Click += BtnRecibirPago_Click;
            btnRecibirAbono.Click += BtnRecibirAbono_Click;
            btnCancelarOperacion.Click += BtnCancelarOperacion_Click;

            CargarPacientes();

            // Si se abrió desde Pedido_Producto, guardar pedido y preseleccionar paciente
            if (idPacienteActual >= 0 && tablaOrdenRecibida != null)
            {
                GuardarNuevoPedido();
                PreseleccionarPaciente();
            }
        }

        //  CARGAR LISTA DE PACIENTES
        private void CargarPacientes()
        {
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                string query = "SELECT Id_Paciente, nombre FROM pacientes ORDER BY nombre";
                lboxNombresPacientesPagosAbonos.DisplayMember = "nombre";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lboxNombresPacientesPagosAbonos.DataSource = dt;
                lboxNombresPacientesPagosAbonos.DisplayMember = "nombre";
                lboxNombresPacientesPagosAbonos.ValueMember = "Id_Paciente";
                lboxNombresPacientesPagosAbonos.SelectedIndex = -1;
            }
        }

        private void PreseleccionarPaciente()
        {
            for (int i = 0; i < lboxNombresPacientesPagosAbonos.Items.Count; i++)
            {
                DataRowView drv = (DataRowView)lboxNombresPacientesPagosAbonos.Items[i];
                if (Convert.ToInt32(drv["Id_Paciente"]) == idPacienteActual)
                {
                    lboxNombresPacientesPagosAbonos.SelectedIndex = i;
                    break;
                }
            }
        }

        //  GUARDAR NUEVO PEDIDO EN BD (viene de Pedido_Producto)
        private void GuardarNuevoPedido()
        {
            decimal total = 0;
            foreach (DataRow r in tablaOrdenRecibida.Rows)
                total += Convert.ToDecimal(r["precio"]);

            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                MySqlTransaction trans = con.BeginTransaction();
                try
                {
                    string sqlPedido = @"INSERT INTO pedidos (Id_Paciente, fecha_pedido, tipo_pago, total, abonado, estado)
                                         VALUES (@idp, @fecha_pedido, 'Pendiente', @total, 0, 'pendiente');
                                         SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd = new MySqlCommand(sqlPedido, con, trans);
                    cmd.Parameters.AddWithValue("@idp", idPacienteActual);
                    cmd.Parameters.AddWithValue("@fecha_pedido", DateTime.Now);
                    cmd.Parameters.AddWithValue("@total", total);
                    int idPedido = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (DataRow r in tablaOrdenRecibida.Rows)
                    {
                        string sqlDetalle = "INSERT INTO detalle_pedido (id_pedido, Id_prod, precio_unitario) VALUES (@idPed, @idProd, @precio)";
                        MySqlCommand cmdD = new MySqlCommand(sqlDetalle, con, trans);
                        cmdD.Parameters.AddWithValue("@idPed", idPedido);
                        cmdD.Parameters.AddWithValue("@idProd", Convert.ToInt32(r["id_producto"]));
                        cmdD.Parameters.AddWithValue("@precio", Convert.ToDecimal(r["precio"]));
                        cmdD.ExecuteNonQuery();
                    }

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show($"Error al guardar pedido: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //  AL SELECCIONAR PACIENTE → cargar sus pedidos
        private void LboxPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxNombresPacientesPagosAbonos.SelectedItem == null) return;

            DataRowView drv = (DataRowView)lboxNombresPacientesPagosAbonos.SelectedItem;
            idPacienteActual = Convert.ToInt32(drv["id_paciente"]);
            nombrePacienteActual = drv["nombre"].ToString();
            lblNombrePaciente.Text = nombrePacienteActual;

            idPedidoSeleccionado = -1;
            CargarPedidosPaciente(idPacienteActual);
        }

        private void CargarPedidosPaciente(int idPaciente)
        {
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                string query = @"SELECT id_pedido, fecha_pedido, total, abonado, estado,
                                        (total - abonado) AS saldo
                                 FROM pedidos
                                 WHERE Id_Paciente = @idp
                                 ORDER BY fecha_pedido DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@idp", idPaciente);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lboxPedidosPacientes.DataSource = null;
                lboxPedidosPacientes.Items.Clear();

                foreach (DataRow r in dt.Rows)
                {
                    string fecha = Convert.ToDateTime(r["fecha_pedido"]).ToString("dd/MM/yyyy");
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

        //  AL SELECCIONAR UN PEDIDO
        private void LboxPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxPedidosPacientes.SelectedItem is PedidoItem item)
            {
                idPedidoSeleccionado = item.IdPedido;
                totalPedido = item.Total;
                abonadoPedido = item.Abonado;
            }
        }

        //  RECIBIR PAGO COMPLETO
        private void BtnRecibirPago_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;

            PedidoItem item = (PedidoItem)lboxPedidosPacientes.SelectedItem;

            if (item.Estado == "pagado")
            {
                MessageBox.Show("Este pedido ya está liquidado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Saldo pendiente: ${item.Saldo:F2}\nIngresa el monto recibido:",
                "Recibir pago", item.Saldo.ToString("F2"));

            if (string.IsNullOrWhiteSpace(input)) return;

            if (!decimal.TryParse(input, out decimal monto))
            {
                MessageBox.Show("Monto inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (monto < item.Saldo)
            {
                MessageBox.Show($"Pago insuficiente. Faltan: ${item.Saldo - monto:F2}\n¿Deseas registrar un abono en su lugar?",
                    "Pago incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoPago = ObtenerTipoPago();
            ActualizarPedidoBD(item.IdPedido, item.Abonado + item.Saldo, "pagado", tipoPago);

            decimal cambio = monto - item.Saldo;
            GenerarTicketTxt(item, "Pago completo", tipoPago, monto, 0);

            string msg = $"✅ Pedido #{item.IdPedido} liquidado correctamente.";
            if (cambio > 0) msg += $"\nCambio: ${cambio:F2}";
            MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarPedidos();
        }

        //  RECIBIR ABONO
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
                MessageBox.Show("El abono cubre el saldo total. Por favor usa 'Recibir pago' para liquidarlo.",
                    "Usa Recibir Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal nuevoAbonado = item.Abonado + abono;
            decimal nuevoSaldo = item.Total - nuevoAbonado;
            string tipoPago = ObtenerTipoPago();

            ActualizarPedidoBD(item.IdPedido, nuevoAbonado, "pendiente", tipoPago);
            GenerarTicketTxt(item, "Abono", tipoPago, abono, nuevoSaldo);

            MessageBox.Show($"✅ Abono de ${abono:F2} registrado.\nSaldo pendiente: ${nuevoSaldo:F2}",
                "Abono registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarPedidos();
        }

        //  Cancelar/reiniciar la ventana
        //funciona para volver a elegir al paciene
        private void BtnCancelarOperacion_Click(object sender, EventArgs e)
        {
            idPacienteActual = -1;
            nombrePacienteActual = "";
            idPedidoSeleccionado = -1;
            totalPedido = 0;
            abonadoPedido = 0;

            lboxNombresPacientesPagosAbonos.SelectedIndex = -1;
            lboxPedidosPacientes.DataSource = null;
            lboxPedidosPacientes.Items.Clear();
            lblNombrePaciente.Text = "Nombre del paciente:";
        }

        //  actualizar en la base de datos Dios mio no muevan NADA POR FAVOR
        private void ActualizarPedidoBD(int idPedido, decimal nuevoAbonado, string estado, string tipoPago)
        {
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                string sql = "UPDATE pedidos SET abonado = @ab, estado = @est, tipo_pago = @tipo WHERE id_pedido = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ab", nuevoAbonado);
                cmd.Parameters.AddWithValue("@est", estado);
                cmd.Parameters.AddWithValue("@tipo", tipoPago);
                cmd.Parameters.AddWithValue("@id", idPedido);
                cmd.ExecuteNonQuery();
            }
        }

        //  generar .txt
        private void GenerarTicketTxt(PedidoItem item, string tipoOperacion, string tipoPago, decimal montoPagado, decimal saldo)
        {
            string carpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "SIGEO_Tickets");
            Directory.CreateDirectory(carpeta);

            string archivo = Path.Combine(carpeta,
                $"Ticket_Pedido_{item.IdPedido}_{DateTime.Now:yyyyMMdd_HHmm}.txt");

            // Obtener productos del pedido
            DataTable productos = new DataTable();
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                string query = @"SELECT CONCAT(p.codigo, ' - ', p.nombre) AS nombre_display, dp.precio_unitario
                                 FROM detalle_pedido dp
                                 JOIN productos p ON dp.id_producto = p.id_producto
                                 WHERE dp.id_pedido = @id";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", item.IdPedido);
                da.Fill(productos);
            }

            using (StreamWriter sw = new StreamWriter(archivo, false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine("========================================");
                sw.WriteLine("         SIGEO - Ortopedia              ");
                sw.WriteLine("         Comprobante de Pago            ");
                sw.WriteLine("========================================");
                sw.WriteLine($"Pedido #:    {item.IdPedido}");
                sw.WriteLine($"Fecha:       {DateTime.Now:dd/MM/yyyy HH:mm}");
                sw.WriteLine($"Paciente:    {nombrePacienteActual}");
                sw.WriteLine($"Operacion:   {tipoOperacion}");
                sw.WriteLine($"Tipo de pago:{tipoPago}");
                sw.WriteLine("----------------------------------------");
                sw.WriteLine($"{"Producto",-30} {"Precio",10}");
                sw.WriteLine("----------------------------------------");

                foreach (DataRow r in productos.Rows)
                    sw.WriteLine($"{r["nombre_display"],-30} ${Convert.ToDecimal(r["precio_unitario"]):F2,9}");

                sw.WriteLine("----------------------------------------");
                sw.WriteLine($"{"TOTAL:",-30} ${item.Total:F2,9}");
                sw.WriteLine($"{"Monto pagado:",-30} ${montoPagado:F2,9}");

                if (saldo > 0)
                    sw.WriteLine($"{"Saldo pendiente:",-30} ${saldo:F2,9}");
                else
                    sw.WriteLine($"{"PAGADO EN SU TOTALIDAD",-30}");

                sw.WriteLine("========================================");
                sw.WriteLine("     ¡Gracias por su preferencia!      ");
                sw.WriteLine("========================================");
            }

            MessageBox.Show($"Ticket guardado en:\n{archivo}", "Ticket generado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //  HELPERS
        private bool ValidarSeleccion()
        {
            if (idPacienteActual < 0)
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
            if (idPacienteActual >= 0)
                CargarPedidosPaciente(idPacienteActual);
        }

        // Eventos vacíos requeridos por el Designer
        private void lblNombrePaciente_Click(object sender, EventArgs e) { }
        private void btnCancelarOperacion_Click(object sender, EventArgs e) { }
    }

    // Clase auxiliar para items del listbox de pedidos
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