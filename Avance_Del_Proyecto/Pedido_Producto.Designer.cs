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
            this.panelRedondeado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxProductos
            // 
            this.lboxProductos.BackColor = System.Drawing.Color.White;
            this.lboxProductos.FormattingEnabled = true;
            this.lboxProductos.Location = new System.Drawing.Point(232, 43);
            this.lboxProductos.Name = "lboxProductos";
            this.lboxProductos.Size = new System.Drawing.Size(540, 160);
            this.lboxProductos.TabIndex = 0;
            // 
            // panelRedondeado1
            // 
            this.panelRedondeado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.panelRedondeado1.BorderRadius = 20;
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
            // lboxNombresPacientesPedido
            // 
            this.lboxNombresPacientesPedido.FormattingEnabled = true;
            this.lboxNombresPacientesPedido.Location = new System.Drawing.Point(30, 50);
            this.lboxNombresPacientesPedido.Name = "lboxNombresPacientesPedido";
            this.lboxNombresPacientesPedido.Size = new System.Drawing.Size(140, 30);
            this.lboxNombresPacientesPedido.TabIndex = 11;
            // 
            // lblOrden
            // 
            this.lblOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.lblOrden.BorderRadius = 20;
            this.lblOrden.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(30, 233);
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
            this.btnCancelar.Location = new System.Drawing.Point(29, 273);
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
            this.btnCancelarOrden.Location = new System.Drawing.Point(30, 313);
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
            this.btnPagar.Location = new System.Drawing.Point(30, 353);
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
            this.lblListaDeProductos.Location = new System.Drawing.Point(232, 12);
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
            this.lblOrdenProductos.Location = new System.Drawing.Point(232, 208);
            this.lblOrdenProductos.Name = "lblOrdenProductos";
            this.lblOrdenProductos.Size = new System.Drawing.Size(541, 28);
            this.lblOrdenProductos.TabIndex = 12;
            this.lblOrdenProductos.Text = "Orden del paciente";
            // 
            // lboxOrdenPaciente
            // 
            this.lboxOrdenPaciente.BackColor = System.Drawing.Color.White;
            this.lboxOrdenPaciente.FormattingEnabled = true;
            this.lboxOrdenPaciente.Location = new System.Drawing.Point(236, 239);
            this.lboxOrdenPaciente.Name = "lboxOrdenPaciente";
            this.lboxOrdenPaciente.Size = new System.Drawing.Size(540, 160);
            this.lboxOrdenPaciente.TabIndex = 13;
            // 
            // Pedido_Producto
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
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
    }
}