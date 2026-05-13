using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Avance_Del_Proyecto
{
    public partial class Pedido_Producto : Form
    {
        string SQLconection = "Server=localhost;Port=3306;Database=Ortopedia;Uid=root;Pwd=root;";

        private DataTable tablaOrden = new DataTable();
        private int idPacienteSeleccionado = -1;
        private string nombrePacienteSeleccionado = "";

        public Pedido_Producto()
        {
            InitializeComponent();
        }
        private void Pedido_Producto_Load(object sender, EventArgs e)
        {
            tablaOrden.Columns.Add("id_prod", typeof(int));
            tablaOrden.Columns.Add("nombre_display", typeof(string));
            tablaOrden.Columns.Add("precio", typeof(decimal));
            CargarPacientes();
            CargarProductos();
            lboxNombresPacientesPedido.SelectedIndexChanged += LboxNombresPacientesPedido_SelectedIndexChanged;
        }

        private void CargarPacientes()
        {
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                string query = "SELECT id_paciente, nombre FROM pacientes ORDER BY nombre";
                lboxNombresPacientesPedido.DisplayMember = "nombre";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lboxNombresPacientesPedido.DisplayMember = "nombre";
                lboxNombresPacientesPedido.ValueMember = "id_paciente";
                lboxNombresPacientesPedido.DataSource = dt;
                lboxNombresPacientesPedido.SelectedIndex = -1;
                idPacienteSeleccionado = -1;
            }
        }

        private void CargarProductos()
        {
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();
                string query = "SELECT id_prod, precio, CONCAT(codigo_barras, ' - ', nombre) AS nombre_display FROM inventario";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lboxProductos.DataSource = dt;
                lboxProductos.DisplayMember = "nombre_display";
                lboxProductos.ValueMember = "id_prod";
            }
        }

        // Se elige el nombre del paciente
        private void LboxNombresPacientesPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxNombresPacientesPedido.SelectedItem is DataRowView drv)
            {
                idPacienteSeleccionado = Convert.ToInt32(drv["id_paciente"]);
                nombrePacienteSeleccionado = drv["nombre"].ToString();
            }
            else
            {
                idPacienteSeleccionado = -1;
                nombrePacienteSeleccionado = "";
            }
        }

        // Se agregan los productos desde el inventario
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (idPacienteSeleccionado < 0)
            {
                MessageBox.Show("Primero selecciona un paciente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lboxProductos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView fila = (DataRowView)lboxProductos.SelectedItem;
            int id = Convert.ToInt32(fila["id_prod"]);
            string nombre = fila["nombre_display"].ToString();
            decimal precio = Convert.ToDecimal(fila["precio"]);

            foreach (DataRow r in tablaOrden.Rows)
            {
                if (Convert.ToInt32(r["id_prod"]) == id)
                {
                    MessageBox.Show("Ese producto ya está en la orden.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            tablaOrden.Rows.Add(id, nombre, precio);
            ActualizarOrden();
        }

        // Cancelar el último pedido
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (tablaOrden.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la orden.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tablaOrden.Rows.RemoveAt(tablaOrden.Rows.Count - 1);
            ActualizarOrden();
        }

        // Cancelar la orden entera
        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("¿Cancelar toda la orden?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                ResetearTodo();
            }
        }

        // Se abre la pestaña de Pagos y Abonos
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (idPacienteSeleccionado < 0)
            {
                MessageBox.Show("Selecciona un paciente primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tablaOrden.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la orden.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var pagos = new Pagos_Abonos(idPacienteSeleccionado, nombrePacienteSeleccionado, tablaOrden))
            {
                pagos.ShowDialog();
            }

            ResetearTodo();
        }

        // Helpers
        private void ActualizarOrden()
        {
            lboxOrdenPaciente.Items.Clear();
            decimal total = 0;

            foreach (DataRow r in tablaOrden.Rows)
            {
                decimal precio = Convert.ToDecimal(r["precio"]);
                total += precio;
                lboxOrdenPaciente.Items.Add($"{r["nombre_display"]}  —  ${precio:F2}");
            }

            if (tablaOrden.Rows.Count > 0)
            {
                lboxOrdenPaciente.Items.Add("──────────────────────────────");
                lboxOrdenPaciente.Items.Add($"TOTAL: ${total:F2}");
            }
        }

        private void ResetearTodo()
        {
            tablaOrden.Clear();
            idPacienteSeleccionado = -1;
            nombrePacienteSeleccionado = "";
            lboxNombresPacientesPedido.SelectedIndex = -1;
            lboxOrdenPaciente.Items.Clear();
            lblNoDeOrden.Text = "En el ticket"; // No quiero quitarlo ya no me da el cerebro pa reoganizarlo
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu_Interfaz VentanaManu = new Menu_Interfaz();
            VentanaManu.Show();
            this.Hide();
        }
    }
}