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
    }
}
