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

        private void PanelLogin_Paint(object sender, PaintEventArgs e)
        {
            int radioEsquina = 30;
            Rectangle rect = new Rectangle(0, 0, PanelLogin.Width, PanelLogin.Height);

            System.Drawing.Drawing2D.GraphicsPath forma = new System.Drawing.Drawing2D.GraphicsPath();
            forma.AddArc(rect.X, rect.Y, radioEsquina, radioEsquina, 180, 90);
            forma.AddArc(rect.X + rect.Width - radioEsquina, rect.Y, radioEsquina, radioEsquina, 270, 90);
            forma.AddArc(rect.X + rect.Width - radioEsquina, rect.Y + rect.Height - radioEsquina, radioEsquina, radioEsquina, 0, 90);
            forma.AddArc(rect.X, rect.Y + rect.Height - radioEsquina, radioEsquina, radioEsquina, 90, 90);
            forma.CloseAllFigures();

            PanelLogin.Region = new Region(forma);
            ConfigurarBotonModerno(BtnIS);
            TbUsuario.BorderStyle = BorderStyle.None;
            TbContraseña.BorderStyle = BorderStyle.None;
            TbUsuario.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, TbUsuario.Width, TbUsuario.Height, 15, 15));
            TbContraseña.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, TbContraseña.Width, TbContraseña.Height, 15, 15));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     
                int nTopRect,     
                int nRightRect,    
                int nBottomRect,   
                int nWidthEllipse, 
                int nHeightEllipse 
            );

        public void ConfigurarBotonModerno(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            // Aquí es donde sucede la magia del suavizado
            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Creamos la forma redondeada
                int radio = 20; // Ajusta a tu gusto
                Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
                path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
                path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path); 

              
                using (Pen pen = new Pen(btn.BackColor, 1.5f)) 
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }
        private void BtnIS_Click(object sender, EventArgs e)
        {
            string usuario = TbUsuario.Text;
            string pass = TbContraseña.Text;

            if (usuario == "Emiliano" && pass == "1234")
            {
                MessageBox.Show("Acceso Concedido. Bienvenido");

                Ingreso_Paciente ventanaInventario = new Ingreso_Paciente();
                ventanaInventario.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intenta de nuevo, no te alteres.");
                TbUsuario.Clear();
                TbContraseña.Clear();
                TbUsuario.Focus(); 
            }
        }
    }
}
