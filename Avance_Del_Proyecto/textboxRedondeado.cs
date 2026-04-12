using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Avance_Del_Proyecto
{
    [ToolboxItem(true)]
    public class textboxRedondeado : UserControl
    {
        private TextBox textBox1;
        private int borderRadius = 20;
        private Color borderColor = Color.Gray;

        public textboxRedondeado()
        {
            textBox1 = new TextBox();
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Comic Sans MS", 10);
            textBox1.BackColor = ColorTranslator.FromHtml("#F2CFB0");
            textBox1.Location = new Point(10, 7);

            this.Controls.Add(textBox1);
            this.Padding = new Padding(10, 7, 10, 7);
            this.Size = new Size(200,30);
            this.BackColor = ColorTranslator.FromHtml("#F2CFB0");
        }
        public string TextValue { get => textBox1.Text; set => textBox1.Text = value; }

        public int BorderRadius
        {get => borderRadius; set { borderRadius = value; this.Invalidate(); }}
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(Width - borderRadius, Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using (Pen pen = new Pen(this.Parent.BackColor, 2))
            {pevent.Graphics.DrawPath(pen, path);}
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            textBox1.Width = this.Width - 20;
        }
    }
}