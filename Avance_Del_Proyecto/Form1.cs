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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIS_Click(object sender, EventArgs e)
        {
            string Usuario = TbUsuario.TextValue;
            string Contrasena = TbContrasena.TextValue;

            if (Usuario == "Emiliano" && Contrasena == "1234")
            
            {
                MessageBox.Show("¡Bienvenida de nuevo, " + Usuario + "!", "Acceso Concedido");
                Menu_Interfaz ObjMenuInt = new Menu_Interfaz();
                ObjMenuInt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intenta de nuevo.", "Error");
            }
        }
    }
}
