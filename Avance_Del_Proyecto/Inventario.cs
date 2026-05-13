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
            ActualizaGrid();
            txtBuscar.TextChanged += new EventHandler(txtBuscar_TextChanged);
        }
        DataTable tablaDatos;

        string SQLConection = "Server=localhost; Port=3306; Database=Ortopedia; Uid=root; Pwd=root";
        public void ActualizaGrid()
        {
            using (MySqlConnection conectar = new MySqlConnection(SQLConection)) 
            {
                conectar.Open();
                string query = "select ID_prod as \"ID\", nombre, cantidad, codigo_barras as " +
                    "\"codigo de barras\", fecha_ingreso as \"fecha de ingreso\", precio from inventario";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conectar);
                tablaDatos = new DataTable();
                adapter.Fill(tablaDatos);

                dgvInventario.DataSource = tablaDatos;

            }

        }
        private void EliminarProducto(int id)
        {
            string query = "delete from inventario where id_prod = @id";
            using (MySqlConnection conectar = new MySqlConnection(SQLConection))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conectar)) 
                {
                    cmd.Connection = conectar;
                    conectar.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conectar.Close();
                }
            }
        }
        private void Inventario_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Refresh();
        }

        private void dgvInventario_Paint(object sender, PaintEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int radius = 30;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgv.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgv.Width-radius, dgv.Height-radius, radius, radius, 0, 90);
            path.AddArc(0, dgv.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            dgv.Region = new Region(path);

            using (Pen pen = new Pen(ColorTranslator.FromHtml("#00824A"))) 
            { e.Graphics.DrawPath(pen, path); }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (frmDetalleProducto ventana = new frmDetalleProducto())
            {
                ventana.EsEdicion = false;
                ventana.Text = "Nuevo Producto";
                if(ventana.ShowDialog() == DialogResult.OK)
                {
                    ActualizaGrid();
                }
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este producto?", "Eliminar produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes) 
                {
                    try
                    {
                        int idEliminado = Convert.ToInt32(dgvInventario.CurrentRow.Cells["ID"].Value);
                        EliminarProducto(idEliminado);
                        ActualizaGrid();
                    }
                    catch (Exception ex) { MessageBox.Show("Error al intentar borrar el producto" + ex.Message); }
                }

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
                //DateTime fecha_ingreso = Convert.ToDateTime(dgvInventario.CurrentRow.Cells["fecha de ingreso"].Value);
                int precio = Convert.ToInt32(dgvInventario.CurrentRow.Cells["precio"].Value); 

                ventana.IdProducto = id;
                ventana.LlenarCampos(nombre, codigo, cantidad, precio);
                if (ventana.ShowDialog() == DialogResult.OK) { ActualizaGrid(); }
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tablaDatos != null)
            {
                DataView dv = tablaDatos.DefaultView;
                dv.RowFilter = string.Format("nombre LIKE '%{0}%'", txtBuscar.Text);
            }
        }

        private void botonRedondeado1_Click(object sender, EventArgs e)
        {
            Menu_Interfaz VentanaManu = new Menu_Interfaz();
            VentanaManu.Show();
            this.Hide();
        }
    }
}
