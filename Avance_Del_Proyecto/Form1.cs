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
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,     // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // width of ellipse
                int nHeightEllipse // height of ellipse
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

                btn.Region = new Region(path); // Recorta para que el click respete la forma

                // Dibujamos un borde sutil para que "disimule" el pixelado
                using (Pen pen = new Pen(btn.BackColor, 1.5f)) // Un borde del mismo color
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }

        private void BtnIS_Click(object sender, EventArgs e)
        {

        }
    }
}
