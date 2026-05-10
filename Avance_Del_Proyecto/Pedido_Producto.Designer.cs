namespace Avance_Del_Proyecto
{
    partial class Pedido_Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboxProductos = new System.Windows.Forms.ListBox();
            this.panelRedondeado1 = new Avance_Del_Proyecto.panelRedondeado();
            this.btnMenu = new Avance_Del_Proyecto.botonRedondeado();
            this.lblNombrePaciente = new Avance_Del_Proyecto.labelRedondeado();
            this.lboxNombresPacientesPedido = new System.Windows.Forms.ListBox();
            this.lblOrden = new Avance_Del_Proyecto.labelRedondeado();
            this.lblNoDeOrden = new Avance_Del_Proyecto.labelRedondeado();
            this.lblFecha = new Avance_Del_Proyecto.labelRedondeado();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new Avance_Del_Proyecto.botonRedondeado();
            this.btnCancelar = new Avance_Del_Proyecto.botonRedondeado();
            this.btnCancelarOrden = new Avance_Del_Proyecto.botonRedondeado();
            this.btnPagar = new Avance_Del_Proyecto.botonRedondeado();
            this.lblListaDeProductos = new Avance_Del_Proyecto.labelRedondeado();
            this.lblOrdenProductos = new Avance_Del_Proyecto.labelRedondeado();
            this.lboxOrdenPaciente = new System.Windows.Forms.ListBox();
            this.labelRedondeado1 = new Avance_Del_Proyecto.labelRedondeado();
            this.panelRedondeado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxProductos
            // 
            this.lboxProductos.BackColor = System.Drawing.Color.White;
            this.lboxProductos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxProductos.FormattingEnabled = true;
            this.lboxProductos.ItemHeight = 15;
            this.lboxProductos.Location = new System.Drawing.Point(232, 110);
            this.lboxProductos.Name = "lboxProductos";
            this.lboxProductos.Size = new System.Drawing.Size(540, 154);
            this.lboxProductos.TabIndex = 0;
            // 
            // panelRedondeado1
            // 
            this.panelRedondeado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.panelRedondeado1.BorderRadius = 20;
            this.panelRedondeado1.Controls.Add(this.btnMenu);
            this.panelRedondeado1.Controls.Add(this.lblNombrePaciente);
            this.panelRedondeado1.Controls.Add(this.lboxNombresPacientesPedido);
            this.panelRedondeado1.Controls.Add(this.lblOrden);
            this.panelRedondeado1.Controls.Add(this.lblNoDeOrden);
            this.panelRedondeado1.Controls.Add(this.lblFecha);
            this.panelRedondeado1.Controls.Add(this.dateTimePicker1);
            this.panelRedondeado1.Controls.Add(this.btnAgregar);
            this.panelRedondeado1.Controls.Add(this.btnCancelar);
            this.panelRedondeado1.Controls.Add(this.btnCancelarOrden);
            this.panelRedondeado1.Controls.Add(this.btnPagar);
            this.panelRedondeado1.Location = new System.Drawing.Point(12, 75);
            this.panelRedondeado1.Name = "panelRedondeado1";
            this.panelRedondeado1.Size = new System.Drawing.Size(201, 391);
            this.panelRedondeado1.TabIndex = 11;
            this.panelRedondeado1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRedondeado1_Paint);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMenu.BorderRadius = 30;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMenu.Location = new System.Drawing.Point(31, 346);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(140, 29);
            this.btnMenu.TabIndex = 13;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            // lboxNombresPacientesPedido
            // 
            this.lboxNombresPacientesPedido.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxNombresPacientesPedido.FormattingEnabled = true;
            this.lboxNombresPacientesPedido.ItemHeight = 15;
            this.lboxNombresPacientesPedido.Location = new System.Drawing.Point(30, 50);
            this.lboxNombresPacientesPedido.Name = "lboxNombresPacientesPedido";
            this.lboxNombresPacientesPedido.Size = new System.Drawing.Size(140, 19);
            this.lboxNombresPacientesPedido.TabIndex = 11;
            // 
            // lblOrden
            // 
            this.lblOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.lblOrden.BorderRadius = 20;
            this.lblOrden.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblOrden.Location = new System.Drawing.Point(51, 72);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(98, 29);
            this.lblOrden.TabIndex = 7;
            this.lblOrden.Text = "No. de Orden:";
            // 
            // lblNoDeOrden
            // 
            this.lblNoDeOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblNoDeOrden.BorderRadius = 20;
            this.lblNoDeOrden.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDeOrden.Location = new System.Drawing.Point(12, 101);
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
            this.lblFecha.Location = new System.Drawing.Point(76, 133);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 29);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregar.BorderRadius = 30;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(30, 218);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 29);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.BorderRadius = 30;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(29, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 29);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCancelarOrden
            // 
            this.btnCancelarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelarOrden.BorderRadius = 30;
            this.btnCancelarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarOrden.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelarOrden.Location = new System.Drawing.Point(30, 282);
            this.btnCancelarOrden.Name = "btnCancelarOrden";
            this.btnCancelarOrden.Size = new System.Drawing.Size(140, 29);
            this.btnCancelarOrden.TabIndex = 5;
            this.btnCancelarOrden.Text = "Cancelar orden";
            this.btnCancelarOrden.UseVisualStyleBackColor = false;
            this.btnCancelarOrden.Click += new System.EventHandler(this.btnCancelarOrden_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Lime;
            this.btnPagar.BorderRadius = 30;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPagar.Location = new System.Drawing.Point(30, 314);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(140, 29);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblListaDeProductos
            // 
            this.lblListaDeProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.lblListaDeProductos.BorderRadius = 20;
            this.lblListaDeProductos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblListaDeProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblListaDeProductos.Location = new System.Drawing.Point(232, 79);
            this.lblListaDeProductos.Name = "lblListaDeProductos";
            this.lblListaDeProductos.Size = new System.Drawing.Size(541, 28);
            this.lblListaDeProductos.TabIndex = 11;
            this.lblListaDeProductos.Text = "Lista de productos";
            this.lblListaDeProductos.Click += new System.EventHandler(this.lblListaDeProductos_Click);
            // 
            // lblOrdenProductos
            // 
            this.lblOrdenProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.lblOrdenProductos.BorderRadius = 20;
            this.lblOrdenProductos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOrdenProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblOrdenProductos.Location = new System.Drawing.Point(232, 275);
            this.lblOrdenProductos.Name = "lblOrdenProductos";
            this.lblOrdenProductos.Size = new System.Drawing.Size(541, 28);
            this.lblOrdenProductos.TabIndex = 12;
            this.lblOrdenProductos.Text = "Orden del paciente";
            // 
            // lboxOrdenPaciente
            // 
            this.lboxOrdenPaciente.BackColor = System.Drawing.Color.White;
            this.lboxOrdenPaciente.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxOrdenPaciente.FormattingEnabled = true;
            this.lboxOrdenPaciente.ItemHeight = 15;
            this.lboxOrdenPaciente.Location = new System.Drawing.Point(236, 306);
            this.lboxOrdenPaciente.Name = "lboxOrdenPaciente";
            this.lboxOrdenPaciente.Size = new System.Drawing.Size(540, 154);
            this.lboxOrdenPaciente.TabIndex = 13;
            // 
            // labelRedondeado1
            // 
            this.labelRedondeado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.labelRedondeado1.BorderRadius = 20;
            this.labelRedondeado1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRedondeado1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRedondeado1.ForeColor = System.Drawing.Color.White;
            this.labelRedondeado1.Location = new System.Drawing.Point(0, 0);
            this.labelRedondeado1.Name = "labelRedondeado1";
            this.labelRedondeado1.Size = new System.Drawing.Size(784, 72);
            this.labelRedondeado1.TabIndex = 14;
            this.labelRedondeado1.Text = "Pedido del producto";
            // 
            // Pedido_Producto
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(784, 473);
            this.Controls.Add(this.labelRedondeado1);
            this.Controls.Add(this.lboxOrdenPaciente);
            this.Controls.Add(this.lblOrdenProductos);
            this.Controls.Add(this.panelRedondeado1);
            this.Controls.Add(this.lblListaDeProductos);
            this.Controls.Add(this.lboxProductos);
            this.Name = "Pedido_Producto";
            this.Text = "Pedido de Producto";
            this.Load += new System.EventHandler(this.Pedido_Producto_Load);
            this.panelRedondeado1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxProductos;
        private labelRedondeado lblListaDeProductos;
        private panelRedondeado panelRedondeado1;
        private labelRedondeado lblNombrePaciente;
        private System.Windows.Forms.ListBox lboxNombresPacientesPedido;
        private labelRedondeado lblOrden;
        private labelRedondeado lblNoDeOrden;
        private labelRedondeado lblFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private botonRedondeado btnAgregar;
        private botonRedondeado btnCancelar;
        private botonRedondeado btnCancelarOrden;
        private botonRedondeado btnPagar;
        private labelRedondeado lblOrdenProductos;
        private System.Windows.Forms.ListBox lboxOrdenPaciente;
        private botonRedondeado btnMenu;
        private labelRedondeado labelRedondeado1;
    }
}