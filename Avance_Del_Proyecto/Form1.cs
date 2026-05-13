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
    public partial class Form1 : Form
    {
        string SQLConection = "Server=localhost; Port=3306; Database=Ortopedia; Uid=root; Pwd=root";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIS_Click(object sender, EventArgs e)
        {
            string Usuario = TbUsuario.TextValue;
            string Contrasena = TbContrasena.TextValue;
            string query = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @nombre AND contrasena = @contrasena";

            try
            {
                using (MySqlConnection con = new MySqlConnection(SQLConection))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", TbUsuario.TextValue);
                        cmd.Parameters.AddWithValue("@contrasena", TbContrasena.TextValue);

                        int coincidencias = Convert.ToInt32(cmd.ExecuteScalar());

                        if (coincidencias > 0)
                        {
                            MessageBox.Show($"Bienvenido {Usuario}. Acceso concedido.");
                            Menu_Interfaz ObjMenuInt = new Menu_Interfaz();
                            ObjMenuInt.Show();
                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos. Intente de nuevo.");
                            TbUsuario.TextValue = "";
                            TbContrasena.TextValue = "";
                            TbUsuario.Focus();
                        }
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show("Error al conectar " + ex.Message); }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Registro ventana = new Registro()) 
            {
                if (ventana.ShowDialog() == DialogResult)
                {
                    TbUsuario.TextValue = "";
                    TbContrasena.TextValue = "";
                    TbUsuario.Focus();
                }
                this.Show();
            }
        }
    }
}
