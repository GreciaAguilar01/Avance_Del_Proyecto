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
using MySql.Data.MySqlClient;

namespace Avance_Del_Proyecto
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Refresh();
        }

        private void dgvInventario_Paint(object sender, PaintEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int radius = 30;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(dgv.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(dgv.Width-radius, dgv.Height-radius, radius, radius, 0, 90);
            path.AddArc(0, dgv.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            dgv.Region = new Region(path);

            using (Pen pen = new Pen(ColorTranslator.FromHtml("#00824A"))) 
            { e.Graphics.DrawPath(pen, path); }
        }
    }
}
