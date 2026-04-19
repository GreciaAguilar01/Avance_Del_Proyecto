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
    public partial class Ingreso_Paciente : Form
    {
        public Ingreso_Paciente()
        {
            InitializeComponent();
            //oal
        }
        private void RedonearControl(Control control, int radio)
        {
            System.Drawing.Drawing2D.GraphicsPath silueta = new System.Drawing.Drawing2D.GraphicsPath();
            silueta.AddArc(0, 0, radio, radio, 180, 90);
            silueta.AddArc(control.Width - radio, 0, radio, radio, 270, 90);
            silueta.AddArc(control.Width - radio, control.Height - radio, radio, radio, 0, 90);
            silueta.AddArc(0, control.Height - radio, radio, radio, 90, 90);
            silueta.CloseAllFigures();
            control.Region = new Region(silueta);
        }


        private void Ingreso_Paciente_Load_1(object sender, EventArgs e)
        {
            RedonearControl(BtnGuardarPaciente, 15);
            RedonearControl(BtnBorrarFormulario, 15);
            RedonearControl(PanelFormulario, 30);
            RedonearControl(PanelBotones, 30);
            RedonearControl(BtnEditarPaciente, 15);
        }

        private void BtnGuardarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Recopilamos la info de los TextBox
                // Asegúrate que estos nombres sean los que pusiste en el diseño
                string datos = $"Nombre del Paciente: {TBNombrePaciente.Text} | " + $"Fecha de Nacimiento: {TBFechaNacimiento.Text} | " + 
                $"Numero del Paciente: {TBNumerodelPaciente.Text} | " + $"Correo del Paciente: {TBCorreoPaciente.Text} | " + 
                $"Nombre del Familiar: {TBNombreFamiliar.Text} | " + $"Telefono del Familiar: {TBNumerodelFamiliar.Text}" + $"Correo del Paciente: {TBCorreoFamiliar.Text} |";

                // 2. Ruta del archivo (se creará en la carpeta del proyecto)
                string ruta = "PruebaPacientes.txt";

                // 3. Escribimos en el archivo (append: true para que no borre lo anterior)
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(ruta, true))
                {
                    file.WriteLine(datos);
                }

                // 4. Avisamos que todo salió bien
                MessageBox.Show("¡Paciente guardado en el TXT con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al guardar: " + ex.Message);
            }
        }

        private void BtnBorrarFormulario_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Segura que quieres limpiar todo el formulario?",
                              "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                TBNombrePaciente.Clear();
                TBFechaNacimiento.Clear();
                TBNumerodelPaciente.Clear();
                TBCorreoPaciente.Clear();
                TBNombreFamiliar.Clear();
                TBNumerodelFamiliar.Clear();
                TBCorreoFamiliar.Clear();

                TBNombrePaciente.Focus();
            }
        }

        private void BtnEditarPaciente_Click(object sender, EventArgs e)
        {
            Editar_InfPaciente VentanaEditarPaciente = new Editar_InfPaciente();
            VentanaEditarPaciente.Show();
            this.Hide();
        }
    }
}
