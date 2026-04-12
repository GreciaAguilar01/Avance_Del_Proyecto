using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Avance_Del_Proyecto
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitulo_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            e.Graphics.SmoothingMode= SmoothingMode.AntiAlias;
            Color colorFondo = ColorTranslator.FromHtml("#0F1F7A");

            int radius = 25;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(lbl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(lbl.Width - radius, lbl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, lbl.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            using (SolidBrush brush = new SolidBrush(colorFondo))
            { e.Graphics.FillPath(brush, path); }

            TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, lbl.ClientRectangle, lbl.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

        }
    }
}
