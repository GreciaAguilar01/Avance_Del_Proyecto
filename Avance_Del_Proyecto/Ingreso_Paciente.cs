using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Avance_Del_Proyecto
{

    public partial class Ingreso_Paciente : Form
    {
        public Ingreso_Paciente()
        {
            InitializeComponent();
            
        }

        private void LimpiarFormulario()
        {
            TxbNombreP.Text = "";
            TxbFechaNac.Text = "";
            TxbNumP.Text = "";
            TxbCorreoP.Text = "";
            TxbNombreF.Text = "";
            TxbNumF.Text = "";
            TxbCorreoF.Text = "";
        }


        private void BtnRegresarMenu_Click(object sender, EventArgs e)
        {
            Form menu = Application.OpenForms["Menu_Interfaz"];
            if (menu != null)
            {
                menu.Show();
                this.Close();
            }
            else
            {
                Menu_Interfaz nuevoMenu = new Menu_Interfaz();
                nuevoMenu.Show();
                this.Close();
            }
        }

        private void BtnGuardarInf_Click(object sender, EventArgs e)
        {
            string conexionString = "server=localhost;port=3306;database=Ortopedia_Prueba1;uid=root;pwd=2496;";
            using (MySqlConnection con = new MySqlConnection(conexionString))
            {
                try
                {
                    con.Open();
                    string query = @"INSERT INTO IngresoPacientes 
                                (Nombre_Paciente, Fecha_NacimientoP, Celular_Paciente, Correo_Paciente, 
                                 Nombre_Familiar, Celular_Familiar, Correo_Familiar) 
                                VALUES 
                                (@nomP, @fecP, @celP, @corP, @nomF, @celF, @corF)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nomP", TxbNombreP.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@fecP", TxbFechaNac.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@celP", TxbNumP.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@corP", TxbCorreoP.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@nomF", TxbNombreF.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@celF", TxbNumF.TextValue .Trim());
                    cmd.Parameters.AddWithValue("@corF", TxbCorreoF.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("¡Paciente registrado con éxito!", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión o de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBorrarInf_Click(object sender, EventArgs e)
        {
            TxbNombreP.Text = string.Empty;
            TxbNombreP.TextValue = "";
            TxbFechaNac.Text = string.Empty;
            TxbFechaNac.TextValue = "";
            TxbNumP.Text = string.Empty;
            TxbNumP.TextValue = "";
            TxbCorreoP.Text = string.Empty;
            TxbCorreoP.TextValue = "";

            TxbNombreF.Text = string.Empty;
            TxbNombreF.TextValue = "";
            TxbNumF.Text = string.Empty;
            TxbNumF.TextValue = "";
            TxbCorreoF.Text = string.Empty;
            TxbCorreoF.TextValue = "";
            this.Refresh();
        }

        private void BtnRetornarMenu_Click(object sender, EventArgs e)
        {
            Menu_Interfaz VentanaManu = new Menu_Interfaz();
            VentanaManu.Show();
            this.Hide();
        }
    }
}
