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
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.IO;

namespace Avance_Del_Proyecto
{
    public partial class Ingreso_Paciente : Form
    {
        private VideoCaptureDevice camara;
        private bool camaraActiva = false;
        private string _tipoFoto = ""; // "paciente" o "familiar"
        private string carpetaFotos = Path.Combine(Application.StartupPath, "FotosPacientes");
        public Ingreso_Paciente()
        {
            InitializeComponent();
            this.FormClosing += (s, e) => DetenerCamara();
            btnFotoPaciente.Click += (s, e) => { _tipoFoto = "paciente"; CapturarFoto(); };
            btnFotoFamiliar.Click += (s, e) => { _tipoFoto = "familiar"; CapturarFoto(); };
            this.KeyPreview = true;
            this.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Space)
                {
                    if (camaraActiva) DetenerCamara();
                    else IniciarCamara("");
                }
            };
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

        // Método para iniciar la cámara y mostrar la vista previa
        private void IniciarCamara(string tipo)
        {
            var camaras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (camaras.Count == 0) { MessageBox.Show("No se detectó cámara."); return; }

            _tipoFoto = tipo; // solo se asigna cuando viene de un botón, en este caso deberá ser del paciente o del familiar
            camara = new VideoCaptureDevice(camaras[2].MonikerString);
            camara.NewFrame += Camara_NewFrame;
            camara.Start();
            camaraActiva = true;
        }

        private void Camara_NewFrame(object sender, NewFrameEventArgs e)
        {
            if (!camaraActiva || pbVistaPrevia.IsDisposed) return;

            Bitmap frame = (Bitmap)e.Frame.Clone();
            try
            {
                pbVistaPrevia.Invoke((Action)(() =>
                {
                    if (!pbVistaPrevia.IsDisposed)
                    {
                        pbVistaPrevia.Image?.Dispose();
                        pbVistaPrevia.Image = frame;
                    }
                }));
            }
            catch { frame.Dispose(); }
        }

        private void Ingreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && camaraActiva)
                CapturarFoto();
        }

        private void CapturarFoto()
        {
            if (pbVistaPrevia.Image == null)
            {
                MessageBox.Show("Activa la cámara primero con la barra espaciadora.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxbNombreP.TextValue))
            {
                MessageBox.Show("Escribe el nombre del paciente antes de tomar la foto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxbNombreP.TextValue))
            {
                MessageBox.Show("Escribe el nombre del paciente antes de tomar la foto.");
                return;
            }

            Directory.CreateDirectory(carpetaFotos);

            string nombre = TxbNombreP.TextValue.Trim().Replace(" ", "_");
            string archivo = Path.Combine(carpetaFotos, $"{_tipoFoto}_{nombre}.jpg");

            // I M P O R T A N T E, no toquen absolutamente nada de acá, no era mi página pero era necesario para que pudiera salir la foto del paciente
            Bitmap copia = new Bitmap(pbVistaPrevia.Image);

            DetenerCamara();
            System.Threading.Thread.Sleep(200);

            if (_tipoFoto == "paciente") { pbPaciente.Image?.Dispose(); pbPaciente.Image = null; }
            else { pbFamiliar.Image?.Dispose(); pbFamiliar.Image = null; }

            using (var stream = new FileStream(archivo, FileMode.Create, FileAccess.Write))
                copia.Save(stream, ImageFormat.Jpeg);
            copia.Dispose();

            if (_tipoFoto == "paciente")
                pbPaciente.Image = Image.FromFile(archivo);
            else
                pbFamiliar.Image = Image.FromFile(archivo);
        }

        private void DetenerCamara()
        {
            camaraActiva = false;
            if (camara != null && camara.IsRunning)
            {
                camara.SignalToStop();
                camara = null;
            }

            if (pbVistaPrevia.InvokeRequired)
                pbVistaPrevia.Invoke((Action)(() => pbVistaPrevia.Image = null));
            else
                pbVistaPrevia.Image = null;
        }

        private void btnFotoPaciente_Click(object sender, EventArgs e)
        {
            if (camaraActiva) DetenerCamara();
            IniciarCamara("paciente");
        }

        private void btnFotoFamiliar_Click(object sender, EventArgs e)
        {
            if (camaraActiva) DetenerCamara();
            IniciarCamara("familiar");
        }

        private void BtnGuardarInf_Click(object sender, EventArgs e)
        {
            string conexionString = "server=localhost;port=3306;database=Ortopedia ;uid=root;pwd=root;";
            using (MySqlConnection con = new MySqlConnection(conexionString))
            {
                try
                {
                    con.Open();
                    string query = @"INSERT INTO Pacientes 
                                (nombre, fecha_naci, celular, correo, nombreFam, celularFam, correoFam, foto_paciente, foto_familiar) 
                                VALUES 
                                (@nomP, @fecP, @celP, @corP, @nomF, @celF, @corF, @fotoPac, @fotoFam)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nomP", TxbNombreP.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@fecP", TxbFechaNac.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@celP", TxbNumP.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@corP", TxbCorreoP.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@nomF", TxbNombreF.TextValue.Trim());
                    cmd.Parameters.AddWithValue("@celF", TxbNumF.TextValue .Trim());
                    cmd.Parameters.AddWithValue("@corF", TxbCorreoF.TextValue.Trim());
                    string nombre = TxbNombreP.TextValue.Trim().Replace(" ", "_");
                    string rutaPaciente = Path.Combine(carpetaFotos, $"paciente_{nombre}.jpg");
                    string rutaFamiliar = Path.Combine(carpetaFotos, $"familiar_{nombre}.jpg");

                    cmd.Parameters.AddWithValue("@fotoPac", File.Exists(rutaPaciente) ? rutaPaciente : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@fotoFam", File.Exists(rutaFamiliar) ? rutaFamiliar : (object)DBNull.Value);
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

        private void pbFamiliar_Click(object sender, EventArgs e)
        {

        }
    }
}
