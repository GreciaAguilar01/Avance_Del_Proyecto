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
        }
    }
}
