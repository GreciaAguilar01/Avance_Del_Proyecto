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
            TbNombreP.Text = "";
            TBFnP.Text = "";
            TBNumCP.Text = "";
            TBCorreoP.Text = "";
            TbNombreF.Text = "";
            TBNumCF.Text = "";
            TBCorreoF.Text = "";
        }

        private void BtnGuardarInfP_Click(object sender, EventArgs e)
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

                    // Usamos .Trim() para que los dos nombres no causen problemas con espacios accidentales
                    cmd.Parameters.AddWithValue("@nomP", TbNombreP.Text.Trim());
                    cmd.Parameters.AddWithValue("@fecP", TBFnP.Text.Trim());
                    cmd.Parameters.AddWithValue("@celP", TBNumCP.Text.Trim());
                    cmd.Parameters.AddWithValue("@corP", TBCorreoP.Text.Trim());
                    cmd.Parameters.AddWithValue("@nomF", TbNombreF.Text.Trim());
                    cmd.Parameters.AddWithValue("@celF", TBNumCF.Text.Trim());
                    cmd.Parameters.AddWithValue("@corF", TBCorreoF.Text.Trim());

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

        private void BtnBorrarForm_Click(object sender, EventArgs e)
        {
            TbNombreP.Text = string.Empty;
            TbNombreP.TextValue = "";
            TBFnP.Text = string.Empty;
            TBFnP.TextValue = "";
            TBNumCP.Text = string.Empty;
            TBNumCP.TextValue = "";
            TBCorreoP.Text = string.Empty;
            TBCorreoP.TextValue = "";

            TbNombreF.Text = string.Empty;
            TbNombreF.TextValue = "";
            TBNumCF.Text = string.Empty;
            TBNumCF.TextValue = "";
            TBCorreoF.Text = string.Empty;
            TBCorreoF.TextValue = "";
            this.Refresh();
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
    }
}
