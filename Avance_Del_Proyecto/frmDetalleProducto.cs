using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Avance_Del_Proyecto
{
    public partial class frmDetalleProducto : Form
    {
        public bool EsEdicion { get; set; } = false;
        public int? IdProducto { get; set; }
        string SQLConection = "Server=localhost; Port=3306; Database=Ortopedia; Uid=root; Pwd=4444";
        public Productos ProductoNuevo = new Productos();
        public frmDetalleProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtCantidad.TextValue, out int cantidad))
            { MessageBox.Show("La cantidad debe ser un número entero", "Error en cantidad"); return; }
            if (!int.TryParse(txtCodigo.TextValue, out int codigo))
            { MessageBox.Show("El codigo debe ser un número válido", "Error en codigo"); return; }
            if (!int.TryParse(txtPrecio.TextValue, out int precio))
            { MessageBox.Show("El precio debe ser un número válido", "Error en precio"); return; }

            string query;
            if (this.EsEdicion)
            { query = "UPDATE productos SET nombre = @nombre, cantidad = @cantidad, codigo_barras = @codigo, precio = @precio WHERE ID_prod = @ID"; }
            else
            { query = "INSERT INTO productos (nombre, cantidad, codigo_barras, precio) VALUES (@nombre, @cantidad, @codigo, @precio)"; }

            try
            {
                using (MySqlConnection conectar = new MySqlConnection(SQLConection))
                {
                    conectar.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conectar))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.TextValue);
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Producto guardado");
                    }
                    
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
        public void LlenarCampos(string nombre, int codigo, int cantidad, int precio)
        {
            txtNombre.TextValue = nombre;
            txtCodigo.TextValue = codigo.ToString();
            txtCantidad.TextValue = cantidad.ToString();
            txtPrecio.TextValue = precio.ToString();

            this.Text = "Editando producto" + nombre;
        }
    }
}
