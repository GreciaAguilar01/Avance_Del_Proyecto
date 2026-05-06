using MySql.Data.MySqlClient;
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
    public partial class Editar_InfPaciente : Form
    {
        public Editar_InfPaciente()
        {
            InitializeComponent();
        }

        private void BtnRetornarMenu_Click(object sender, EventArgs e)
        {
            Menu_Interfaz VentanaManu = new Menu_Interfaz();
            VentanaManu.Show();
            this.Hide();
        }

        private void BtnBorrarInf_Click(object sender, EventArgs e)
        {
            TxbNombreP_Edit.Text = string.Empty;
            TxbNombreP_Edit.TextValue = "";
            TxbFechaNac_Edit.Text = string.Empty;
            TxbFechaNac_Edit.TextValue = "";
            TxbNumP_Edit.Text = string.Empty;
            TxbNumP_Edit.TextValue = "";
            TxbCorreoP_Edit.Text = string.Empty;
            TxbCorreoP_Edit.TextValue = "";

            TxbNombreF_Edit.Text = string.Empty;
            TxbNombreF_Edit.TextValue = "";
            TxbNumF_Edit.Text = string.Empty;
            TxbNumF_Edit.TextValue = "";
            TxbCorreoF_Edit.Text = string.Empty;
            TxbCorreoF_Edit.TextValue = "";
            this.Refresh();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string conexionString = "server=localhost;port=3306;database=Ortopedia_Prueba1;uid=root;pwd=2496;";
            using (MySqlConnection con = new MySqlConnection(conexionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM IngresoPacientes WHERE Nombre_Paciente = @busqueda";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@busqueda", TbBuscarNombre.TextValue.Trim()); 

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TxbNombreP_Edit.TextValue = reader["Nombre_Paciente"].ToString();
                            TxbFechaNac_Edit.TextValue = reader["Fecha_NacimientoP"].ToString();
                            TxbNumP_Edit.TextValue = reader["Celular_Paciente"].ToString();
                            TxbCorreoP_Edit.TextValue = reader["Correo_Paciente"].ToString();
                            TxbNombreF_Edit.TextValue = reader["Nombre_Familiar"].ToString();
                            TxbNumF_Edit.TextValue = reader["Celular_Familiar"].ToString();
                            TxbCorreoF_Edit.TextValue = reader["Correo_Familiar"].ToString();

                            MessageBox.Show("Paciente encontrado. Puedes editar su información.", "Éxito");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún paciente con ese nombre.", "Aviso");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
            }
        }

        private void BtnGuardarInf_Editada_Click(object sender, EventArgs e)
        {
            string conexionString = "server=localhost;port=3306;database=Ortopedia_Prueba1;uid=root;pwd=2496;";

            using (MySqlConnection con = new MySqlConnection(conexionString))
            {
                try
                {
                    con.Open();
                    string query = @"UPDATE IngresoPacientes 
                            SET Nombre_Paciente = @nomP,
                                Fecha_NacimientoP = @fecP, 
                                Celular_Paciente = @celP, 
                                Correo_Paciente = @corP, 
                                Nombre_Familiar = @nomF, 
                                Celular_Familiar = @celF, 
                                Correo_Familiar = @corF 
                            WHERE Nombre_Paciente = @nomP_Original";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nomP_Original", TbBuscarNombre.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@nomP", TxbNombreP_Edit.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@fecP", TxbFechaNac_Edit.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@celP", TxbNumP_Edit.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@corP", TxbCorreoP_Edit.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@nomF", TxbNombreF_Edit.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@celF", TxbNumF_Edit.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@corF", TxbCorreoF_Edit.TextValue.Trim());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("¡Toda la información ha sido actualizada!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron cambios. Verifica que el nombre en la barra de búsqueda sea el correcto.", "Aviso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message, "Error");
                }
            }
        }
    }
}
