using System;
using System.Data;
using System.IO;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace Avance_Del_Proyecto
{
    public partial class Pagos_Abonos : Form
    {
        string SQLConection = "Server=localhost;Port=3306;Database=Ortopedia; Uid=root;Pwd=root;";

        private int idPacienteActual = -1;
        private string nombrePacienteActual = "";
        private DataTable tablaOrdenRecibida;   // Orden que viene de Pedido_Producto
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
            this.idPacienteActual = idPaciente;
            this.nombrePacienteActual = nombrePaciente;
            this.tablaOrdenRecibida = orden;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            lboxNombresPacientesPagosAbonos.SelectedIndexChanged -= LboxPacientes_SelectedIndexChanged;

            CargarPacientes();

            if (idPacienteActual >= 0 && tablaOrdenRecibida != null)
            {
                GuardarNuevoPedido(this.idPacienteActual);
                PreseleccionarPaciente();
                lblNombrePaciente.Text = nombrePacienteActual;
                CargarPedidosPaciente(idPacienteActual);
            }

            lboxNombresPacientesPagosAbonos.SelectedIndexChanged += LboxPacientes_SelectedIndexChanged;
        }

        // Se carga la lista de los pacientes
        private void CargarPacientes()
        {
            using (MySqlConnection con = new MySqlConnection(SQLConection))
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

        // Guarda el pedido que viene de Pedido_Producto)
        private void GuardarNuevoPedido(int idParaGuardar)
        {
            decimal total = 0;
            foreach (DataRow r in tablaOrdenRecibida.Rows)
                total += Convert.ToDecimal(r["precio"]);

            using (MySqlConnection con = new MySqlConnection(SQLConection))
            {
                con.Open();
                MySqlTransaction trans = con.BeginTransaction();
                try
                {
                    // Preguntamos antes de guardar
                    DialogResult respuesta = MessageBox.Show("¿Este pedido es URGENTE?", "Prioridad de Producción",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    string prioridadSeleccionada = (respuesta == DialogResult.Yes) ? "Urgente" : "Normal";

                    // Ahora usamos esa variable en el parámetro del INSERT
                    string sqlPedido = @"INSERT INTO pedidos (Id_Paciente, fecha_pedido, tipo_pago, total, abonado, estado, prioridad)
                                         VALUES (@idp, @fecha_pedido, 'Pendiente', @total, 0, 'pendiente', @prio);
                                         SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd = new MySqlCommand(sqlPedido, con, trans);
                    //cmd.Parameters.AddWithValue("@idp", idPacienteActual);
                    cmd.Parameters.AddWithValue("@fecha_pedido", DateTime.Now);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@prio", prioridadSeleccionada);
                    cmd.Parameters.AddWithValue("@idp", idParaGuardar);
                    int idPedido = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (DataRow r in tablaOrdenRecibida.Rows)
                    {
                        int idProd = Convert.ToInt32(r["id_prod"]);
                        decimal precio = Convert.ToDecimal(r["precio"]);

                        string sqlDetalle = "INSERT INTO detalle_pedido (id_pedido, Id_prod, precio_unitario) VALUES (@idPed, @idProd, @precio)";
                        MySqlCommand cmdD = new MySqlCommand(sqlDetalle, con, trans);
                        cmdD.Parameters.AddWithValue("@idPed", idPedido);
                        cmdD.Parameters.AddWithValue("@idProd", Convert.ToInt32(r["id_prod"]));
                        cmdD.Parameters.AddWithValue("@precio", Convert.ToDecimal(r["precio"]));
                        cmdD.ExecuteNonQuery();

                        string sqlRestarStock = "UPDATE inventario SET cantidad = cantidad - 1 WHERE id_prod = @idProd";
                        
                        MySqlCommand cmdStock = new MySqlCommand(sqlRestarStock, con, trans);
                        cmdStock.Parameters.AddWithValue("@idProd", idProd);
                        cmdStock.ExecuteNonQuery();
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

        // Se cargan los pedidos del paciente al seleccionar al paciente
        private void LboxPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxNombresPacientesPagosAbonos.SelectedItem == null) return;

            DataRowView drv = (DataRowView)lboxNombresPacientesPagosAbonos.SelectedItem;
            idPacienteActual = Convert.ToInt32(drv["id_paciente"]);
            nombrePacienteActual = drv["nombre"].ToString();
            lblNombrePaciente.Text = nombrePacienteActual;

            idPedidoSeleccionado = -1;
            CargarPedidosPaciente(idPacienteActual);

            using (MySqlConnection con = new MySqlConnection(SQLConection))
            {
                con.Open();
                string q = "SELECT foto_paciente FROM pacientes WHERE Id_Paciente = @id";
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@id", idPacienteActual);
                    string ruta = cmd.ExecuteScalar()?.ToString();

                    if (!string.IsNullOrEmpty(ruta) && File.Exists(ruta))
                    {
                        using (var stream = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                            pbPacientePedido.Image = Image.FromStream(stream);
                    }
                    else
                        pbPacientePedido.Image = null;
                }
            }
        }

        private void CargarPedidosPaciente(int idPaciente)
        {
            using (MySqlConnection con = new MySqlConnection(SQLConection))
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

        // Al seleccionar un pedido, el programa lo mantiene con el pedido que debe de pagarse o abonarse para no hacer pagos o abonos a otros pedidos
        private void LboxPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxPedidosPacientes.SelectedItem is PedidoItem item)
            {
                idPedidoSeleccionado = item.IdPedido;
                totalPedido = item.Total;
                abonadoPedido = item.Abonado;
            }
        }

        // Se recibe el pago, si está completo, se salda la deuda, si es menos, se pregunta si quieres abonar
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

        // Se recibe el abono, se resta X cantidad de dinero de la deuda O te avisa si ya está pagado el pedido
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

        // Cancelar/reiniciar la ventana
        // Funciona para volver a elegir al paciene
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

        // Actualizar en la base de datos Dios mio no muevan NADA POR FAVOR
        private void ActualizarPedidoBD(int idPedido, decimal nuevoAbonado, string estado, string tipoPago)
        {
            using (MySqlConnection con = new MySqlConnection(SQLConection))
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

        // generar .txt
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
            using (MySqlConnection con = new MySqlConnection(SQLConection))
            {
                con.Open();
                string query = @"SELECT CONCAT(p.codigo_barras, ' - ', p.nombre) AS nombre_display, dp.precio_unitario
                                 FROM detalle_pedido dp
                                 JOIN inventario p ON dp.id_prod = p.id_prod
                                 WHERE dp.id_pedido = @id";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", item.IdPedido);
                da.Fill(productos);
            }

            // El ticket se genera de esta forma, de preferencia no tocar nada... Por ahora al menos
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

        // Algunas cosas necesarias
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu_Interfaz VentanaManu = new Menu_Interfaz();
            VentanaManu.Show();
            this.Hide();
        }

        private void labelRedondeado1_Click(object sender, EventArgs e)
        {

        }
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