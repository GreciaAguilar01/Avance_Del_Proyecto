using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avance_Del_Proyecto
{
    public partial class Menu_Interfaz : Form
    {
        public Menu_Interfaz()
        {
            InitializeComponent();
        }

        private void BtnIngresarP_Click(object sender, EventArgs e)
        {
            Ingreso_Paciente ventanaPacientes = new Ingreso_Paciente();
            ventanaPacientes.Show();
            this.Hide();
        }
        private void BtnEditarinfP_Click(object sender, EventArgs e)
        {
            Editar_InfPaciente VentanaEditP = new Editar_InfPaciente();
            VentanaEditP.Show();
            this.Hide();
        }
        private void BtnInventario_Click(object sender, EventArgs e)
        {
            Inventario VentanaInvt = new Inventario();
            VentanaInvt.Show();
            this.Hide();
        }
        private void BtnProducccion_Click(object sender, EventArgs e)
        {
            Produccion VentanaProduccion = new Produccion();
            VentanaProduccion.Show();
            this.Hide();
        }

        private void BtnPagosAbonos_Click(object sender, EventArgs e)
        {
            Pagos_Abonos VentanaPagos_abonos = new Pagos_Abonos();
            VentanaPagos_abonos.Show();
            this.Hide();
        }
        private void BtnPedido_Click(object sender, EventArgs e)
        {
            Pedido_Producto VentanaPedidoProducto = new Pedido_Producto();
            VentanaPedidoProducto.Show();
            this.Hide();
        }
        private void BtnPedidos_Productos_Click(object sender, EventArgs e)
        {
            Pedido_Producto VentanaPedido_Producto = new Pedido_Producto();
            VentanaPedido_Producto.Show();
            this.Hide();
        }
    }
}
