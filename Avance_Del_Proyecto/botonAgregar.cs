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
    public partial class botonAgregar : Form
    {
        string SQLConection = "Server=localhost; Port=3306; Database=ejemplo_ortopedia; Uid=root; Pwd=4444";
        public Productos ProductoNuevo = new Productos();
        public botonAgregar()
        {
            InitializeComponent();
        }

        private void insertarProductos(string nombre, int ID, int codigo, int cantidad, DateTime FechaIngreso)
        {
            using (MySqlConnection conectar = new MySqlConnection(SQLConection)) 
            { 
                conectar.Open();
                string insertQuery = "INSERT INTO productos (ID_prod, nombre, cantidad, codigo_barras, fecha_ingreso)" +
                    "VALUES (@ID, @nombre, @cantidad, @codigo, @FechaIngreso)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conectar)) 
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                    cmd.ExecuteNonQuery();
                }
                conectar.Close();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtCantidad.TextValue, out int cantidad))
            { MessageBox.Show("La cantidad debe ser un número entero", "Error en cantidad"); return; }
            if (!int.TryParse(txtCodigo.TextValue, out int codigo))
            { MessageBox.Show("La cantidad debe ser un número entero", "Error en codigo"); return; }
            if (!int.TryParse(txtID.TextValue, out int id))
            { MessageBox.Show("La cantidad debe ser un número entero", "Error en ID"); return; }

            Productos ProductoNuevo = new Productos
            {
                Nombre = txtNombre.TextValue,
                IDproducto = id,
                Codigo = codigo,
                Cantidad = cantidad,
                FechaIngreso = dtpIngreso.Value,
            };
            

            insertarProductos(ProductoNuevo.Nombre,ProductoNuevo.IDproducto, ProductoNuevo.Cantidad, ProductoNuevo.Codigo, ProductoNuevo.FechaIngreso);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
