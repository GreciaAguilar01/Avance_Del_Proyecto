using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;

namespace Avance_Del_Proyecto
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        }

        private void dgvInventario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInventario.ClearSelection();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                frmDetalleProducto ventana = new frmDetalleProducto();
                ventana.EsEdicion = true;
                
                int id = Convert.ToInt32(dgvInventario.CurrentRow.Cells["ID"].Value);
                string nombre = dgvInventario.CurrentRow.Cells["nombre"].Value.ToString();
                int codigo = Convert.ToInt32(dgvInventario.CurrentRow.Cells["Codigo de barras"].Value);
                int cantidad = Convert.ToInt32(dgvInventario.CurrentRow.Cells["cantidad"].Value);
                DateTime fecha_ingreso = Convert.ToDateTime(dgvInventario.CurrentRow.Cells["fecha de ingreso"].Value);

                ventana.IdProducto = id;
                ventana.LlenarCampos(nombre, codigo, cantidad, fecha_ingreso, id);
                if (ventana.ShowDialog() == DialogResult.OK) { actualizaGrid(); }
            }
        }
    }
}
