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
        string SQLConection = "Server=localhost; Port=3306; Database=Formulario; Uid=root; Pwd=4444";
        public Productos ProductoNuevo = new Productos();
        public botonAgregar()
        {
            InitializeComponent();
        }

        private void insertarProductos(string nombre, string ID, string codigo, int cantidad, DateTime FechaIngreso)
        {
            using (MySqlConnection conectar = new MySqlConnection(SQLConection)) 
            { 

            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProductoNuevo = new Productos();
            ProductoNuevo.Nombre = txtNombre.Text;
            ProductoNuevo.IDproducto = txtID.Text;
            ProductoNuevo.Codigo = txtCodigo.Text;
            ProductoNuevo.Cantidad = int.Parse(txtCantidad.Text);
            ProductoNuevo.FechaIngreso = dtpIngreso.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
