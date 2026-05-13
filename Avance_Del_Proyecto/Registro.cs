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
    public partial class Registro : Form
    {
        string SQLConection = "Server=localhost; Port=3306; Database=Ortopedia; Uid=root; Pwd=root";
        public Registro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string query = "insert into usuarios (nombre_usuario, contrasena) values (@nombre, @contrasena)";
            try 
            {
                using (MySqlConnection conn = new MySqlConnection(SQLConection))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", TbUsuario.TextValue);
                        cmd.Parameters.AddWithValue("@contrasena", TbContrasena.TextValue);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario guardado.");

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception es) { MessageBox.Show("Error al ingresar " + es.Message); }
            
        }
    }
}
