using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Avance_Del_Proyecto
{
    
    public partial class Pedido_Producto : Form
    {
        string SQLconection = "Server=localhost;Port=3306; Database=sigeo_db; Uid=root; Pwd=root;";
       

        private botonRedondeado btnAgregar;
        private botonRedondeado btnCancelar;
        private botonRedondeado btnCancelarOrden;
        private botonRedondeado btnPagar;
        private labelRedondeado lblOrden;
        private labelRedondeado lblNoDeOrden;
        private labelRedondeado lblFecha;
        private DateTimePicker dateTimePicker1;
        private panelRedondeado panelRedondeado1;
        private labelRedondeado lblListaDeProductos;
        private ListBox listBox2;
        private labelRedondeado lblNombrePaciente;
        private ListBox lboxProductos;

        public Pedido_Producto()
        {
            InitializeComponent();
        }

        private void Pedido_Producto_Load(object sender, EventArgs e)
        {
            CargarListBox();
        }

        private void CargarListBox()
        {
            using (MySqlConnection con = new MySqlConnection(SQLconection))
            {
                con.Open();

                string query = "SELECT id_producto, precio, CONCAT(codigo, ' - ', nombre) AS nombre_display FROM productos";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lboxProductos.DataSource = dt;
                lboxProductos.DisplayMember = "nombre_display";
                lboxProductos.ValueMember = "id_producto";
            }
        }
        private void InitializeComponent()
        {
            this.lboxProductos = new System.Windows.Forms.ListBox();
            this.lblListaDeProductos = new Avance_Del_Proyecto.labelRedondeado();
            this.panelRedondeado1 = new Avance_Del_Proyecto.panelRedondeado();
            this.lblNombrePaciente = new Avance_Del_Proyecto.labelRedondeado();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblOrden = new Avance_Del_Proyecto.labelRedondeado();
            this.lblNoDeOrden = new Avance_Del_Proyecto.labelRedondeado();
            this.lblFecha = new Avance_Del_Proyecto.labelRedondeado();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new Avance_Del_Proyecto.botonRedondeado();
            this.btnCancelar = new Avance_Del_Proyecto.botonRedondeado();
            this.btnCancelarOrden = new Avance_Del_Proyecto.botonRedondeado();
            this.btnPagar = new Avance_Del_Proyecto.botonRedondeado();
            this.panelRedondeado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxProductos
            // 
            this.lboxProductos.BackColor = System.Drawing.Color.White;
            this.lboxProductos.FormattingEnabled = true;
            this.lboxProductos.Location = new System.Drawing.Point(229, 76);
            this.lboxProductos.Name = "lboxProductos";
            this.lboxProductos.Size = new System.Drawing.Size(540, 316);
            this.lboxProductos.TabIndex = 0;
            // 
            // lblListaDeProductos
            // 
            this.lblListaDeProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.lblListaDeProductos.BorderRadius = 20;
            this.lblListaDeProductos.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblListaDeProductos.Location = new System.Drawing.Point(228, 9);
            this.lblListaDeProductos.Name = "lblListaDeProductos";
            this.lblListaDeProductos.Size = new System.Drawing.Size(541, 59);
            this.lblListaDeProductos.TabIndex = 11;
            this.lblListaDeProductos.Text = "Lista de productos";
            // 
            // panelRedondeado1
            // 
            this.panelRedondeado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.panelRedondeado1.BorderRadius = 20;
            this.panelRedondeado1.Controls.Add(this.lblNombrePaciente);
            this.panelRedondeado1.Controls.Add(this.listBox2);
            this.panelRedondeado1.Controls.Add(this.lblOrden);
            this.panelRedondeado1.Controls.Add(this.lblNoDeOrden);
            this.panelRedondeado1.Controls.Add(this.lblFecha);
            this.panelRedondeado1.Controls.Add(this.dateTimePicker1);
            this.panelRedondeado1.Controls.Add(this.btnAgregar);
            this.panelRedondeado1.Controls.Add(this.btnCancelar);
            this.panelRedondeado1.Controls.Add(this.btnCancelarOrden);
            this.panelRedondeado1.Controls.Add(this.btnPagar);
            this.panelRedondeado1.Location = new System.Drawing.Point(12, 8);
            this.panelRedondeado1.Name = "panelRedondeado1";
            this.panelRedondeado1.Size = new System.Drawing.Size(201, 391);
            this.panelRedondeado1.TabIndex = 11;
            this.panelRedondeado1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRedondeado1_Paint);
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.BorderRadius = 20;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombrePaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblNombrePaciente.Location = new System.Drawing.Point(30, 20);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(140, 30);
            this.lblNombrePaciente.TabIndex = 12;
            this.lblNombrePaciente.Text = "Nombre del paciente:";
            this.lblNombrePaciente.Click += new System.EventHandler(this.lblNombrePaciente_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(30, 50);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(140, 30);
            this.listBox2.TabIndex = 11;
            // 
            // lblOrden
            // 
            this.lblOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.lblOrden.BorderRadius = 20;
            this.lblOrden.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblOrden.Location = new System.Drawing.Point(51, 86);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(98, 29);
            this.lblOrden.TabIndex = 7;
            this.lblOrden.Text = "No. de Orden:";
            // 
            // lblNoDeOrden
            // 
            this.lblNoDeOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblNoDeOrden.BorderRadius = 20;
            this.lblNoDeOrden.Location = new System.Drawing.Point(12, 115);
            this.lblNoDeOrden.Name = "lblNoDeOrden";
            this.lblNoDeOrden.Size = new System.Drawing.Size(177, 29);
            this.lblNoDeOrden.TabIndex = 8;
            this.lblNoDeOrden.Text = "XXXXXX";
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.lblFecha.BorderRadius = 20;
            this.lblFecha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblFecha.Location = new System.Drawing.Point(76, 158);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 29);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.BorderRadius = 30;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(30, 233);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelar.BorderRadius = 30;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(30, 269);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 30);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCancelarOrden
            // 
            this.btnCancelarOrden.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelarOrden.BorderRadius = 30;
            this.btnCancelarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarOrden.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelarOrden.Location = new System.Drawing.Point(30, 305);
            this.btnCancelarOrden.Name = "btnCancelarOrden";
            this.btnCancelarOrden.Size = new System.Drawing.Size(140, 30);
            this.btnCancelarOrden.TabIndex = 3;
            this.btnCancelarOrden.Text = "Cancelar Orden";
            this.btnCancelarOrden.UseVisualStyleBackColor = false;
            this.btnCancelarOrden.Click += new System.EventHandler(this.btnCancelarOrden_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Lime;
            this.btnPagar.BorderRadius = 30;
            this.btnPagar.CausesValidation = false;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPagar.Location = new System.Drawing.Point(30, 341);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(140, 30);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // Pedido_Producto
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lblListaDeProductos);
            this.Controls.Add(this.lboxProductos);
            this.Controls.Add(this.panelRedondeado1);
            this.Name = "Pedido_Producto";
            this.Text = "Pedido de productos";
            this.panelRedondeado1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }

        private void panelRedondeado1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void lblNombrePaciente_Click(object sender, EventArgs e)
        {

        }

        private void lblNombrePaciente_Click_1(object sender, EventArgs e)
        {

        }
    }
}
