namespace Avance_Del_Proyecto
{
    partial class Pagos_Abonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos_Abonos));
            this.lboxPedidosPacientes = new System.Windows.Forms.ListBox();
            this.panelRedondeado1 = new Avance_Del_Proyecto.panelRedondeado();
            this.btnMenu = new Avance_Del_Proyecto.botonRedondeado();
            this.rbtnEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtnPagoTarjetaDebito = new System.Windows.Forms.RadioButton();
            this.btnCancelarOperacion = new Avance_Del_Proyecto.botonRedondeado();
            this.btnRecibirAbono = new Avance_Del_Proyecto.botonRedondeado();
            this.rbtnPagoTarjetaCredito = new System.Windows.Forms.RadioButton();
            this.btnRecibirPago = new Avance_Del_Proyecto.botonRedondeado();
            this.rbtnTransferencia = new System.Windows.Forms.RadioButton();
            this.lboxNombresPacientesPagosAbonos = new System.Windows.Forms.ListBox();
            this.lblNombrePaciente = new Avance_Del_Proyecto.labelRedondeado();
            this.lblTitulo = new Avance_Del_Proyecto.labelRedondeado();
            this.pbPacientePedido = new System.Windows.Forms.PictureBox();
            this.labelRedondeado1 = new Avance_Del_Proyecto.labelRedondeado();
            this.panelRedondeado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacientePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxPedidosPacientes
            // 
            this.lboxPedidosPacientes.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxPedidosPacientes.FormattingEnabled = true;
            this.lboxPedidosPacientes.ItemHeight = 15;
            this.lboxPedidosPacientes.Location = new System.Drawing.Point(239, 215);
            this.lboxPedidosPacientes.Name = "lboxPedidosPacientes";
            this.lboxPedidosPacientes.Size = new System.Drawing.Size(541, 244);
            this.lboxPedidosPacientes.TabIndex = 11;
            this.lboxPedidosPacientes.SelectedIndexChanged += new System.EventHandler(this.LboxPedidos_SelectedIndexChanged);
            // 
            // panelRedondeado1
            // 
            this.panelRedondeado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.panelRedondeado1.BorderRadius = 20;
            this.panelRedondeado1.Controls.Add(this.btnMenu);
            this.panelRedondeado1.Controls.Add(this.rbtnEfectivo);
            this.panelRedondeado1.Controls.Add(this.rbtnPagoTarjetaDebito);
            this.panelRedondeado1.Controls.Add(this.btnCancelarOperacion);
            this.panelRedondeado1.Controls.Add(this.btnRecibirAbono);
            this.panelRedondeado1.Controls.Add(this.rbtnPagoTarjetaCredito);
            this.panelRedondeado1.Controls.Add(this.btnRecibirPago);
            this.panelRedondeado1.Controls.Add(this.rbtnTransferencia);
            this.panelRedondeado1.Controls.Add(this.lboxNombresPacientesPagosAbonos);
            this.panelRedondeado1.Controls.Add(this.lblNombrePaciente);
            this.panelRedondeado1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelRedondeado1.Location = new System.Drawing.Point(0, 56);
            this.panelRedondeado1.Name = "panelRedondeado1";
            this.panelRedondeado1.Size = new System.Drawing.Size(233, 411);
            this.panelRedondeado1.TabIndex = 10;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Khaki;
            this.btnMenu.BorderRadius = 20;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMenu.Location = new System.Drawing.Point(39, 358);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(140, 30);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Regresar al Menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // rbtnEfectivo
            // 
            this.rbtnEfectivo.AutoSize = true;
            this.rbtnEfectivo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnEfectivo.Location = new System.Drawing.Point(39, 90);
            this.rbtnEfectivo.Name = "rbtnEfectivo";
            this.rbtnEfectivo.Size = new System.Drawing.Size(114, 20);
            this.rbtnEfectivo.TabIndex = 3;
            this.rbtnEfectivo.TabStop = true;
            this.rbtnEfectivo.Text = "Pago en efectivo";
            this.rbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtnPagoTarjetaDebito
            // 
            this.rbtnPagoTarjetaDebito.AutoSize = true;
            this.rbtnPagoTarjetaDebito.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnPagoTarjetaDebito.Location = new System.Drawing.Point(39, 126);
            this.rbtnPagoTarjetaDebito.Name = "rbtnPagoTarjetaDebito";
            this.rbtnPagoTarjetaDebito.Size = new System.Drawing.Size(169, 20);
            this.rbtnPagoTarjetaDebito.TabIndex = 4;
            this.rbtnPagoTarjetaDebito.TabStop = true;
            this.rbtnPagoTarjetaDebito.Text = "Pago con tarjeta de débito";
            this.rbtnPagoTarjetaDebito.UseVisualStyleBackColor = true;
            // 
            // btnCancelarOperacion
            // 
            this.btnCancelarOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelarOperacion.BorderRadius = 20;
            this.btnCancelarOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarOperacion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelarOperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelarOperacion.Location = new System.Drawing.Point(39, 321);
            this.btnCancelarOperacion.Name = "btnCancelarOperacion";
            this.btnCancelarOperacion.Size = new System.Drawing.Size(140, 30);
            this.btnCancelarOperacion.TabIndex = 2;
            this.btnCancelarOperacion.Text = "Cancelar operación";
            this.btnCancelarOperacion.UseVisualStyleBackColor = false;
            this.btnCancelarOperacion.Click += new System.EventHandler(this.btnCancelarOperacion_Click);
            // 
            // btnRecibirAbono
            // 
            this.btnRecibirAbono.BackColor = System.Drawing.Color.Yellow;
            this.btnRecibirAbono.BorderRadius = 20;
            this.btnRecibirAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibirAbono.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRecibirAbono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRecibirAbono.Location = new System.Drawing.Point(39, 284);
            this.btnRecibirAbono.Name = "btnRecibirAbono";
            this.btnRecibirAbono.Size = new System.Drawing.Size(140, 30);
            this.btnRecibirAbono.TabIndex = 1;
            this.btnRecibirAbono.Text = "Recibir abono";
            this.btnRecibirAbono.UseVisualStyleBackColor = false;
            this.btnRecibirAbono.Click += new System.EventHandler(this.BtnRecibirAbono_Click);
            // 
            // rbtnPagoTarjetaCredito
            // 
            this.rbtnPagoTarjetaCredito.AutoSize = true;
            this.rbtnPagoTarjetaCredito.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnPagoTarjetaCredito.Location = new System.Drawing.Point(39, 162);
            this.rbtnPagoTarjetaCredito.Name = "rbtnPagoTarjetaCredito";
            this.rbtnPagoTarjetaCredito.Size = new System.Drawing.Size(173, 20);
            this.rbtnPagoTarjetaCredito.TabIndex = 5;
            this.rbtnPagoTarjetaCredito.TabStop = true;
            this.rbtnPagoTarjetaCredito.Text = "Pago con tarjeta de crédito";
            this.rbtnPagoTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // btnRecibirPago
            // 
            this.btnRecibirPago.BackColor = System.Drawing.Color.Lime;
            this.btnRecibirPago.BorderRadius = 20;
            this.btnRecibirPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibirPago.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRecibirPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRecibirPago.Location = new System.Drawing.Point(39, 247);
            this.btnRecibirPago.Name = "btnRecibirPago";
            this.btnRecibirPago.Size = new System.Drawing.Size(140, 30);
            this.btnRecibirPago.TabIndex = 0;
            this.btnRecibirPago.Text = "Recibir pago";
            this.btnRecibirPago.UseVisualStyleBackColor = false;
            this.btnRecibirPago.Click += new System.EventHandler(this.BtnRecibirPago_Click);
            // 
            // rbtnTransferencia
            // 
            this.rbtnTransferencia.AutoSize = true;
            this.rbtnTransferencia.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnTransferencia.Location = new System.Drawing.Point(39, 198);
            this.rbtnTransferencia.Name = "rbtnTransferencia";
            this.rbtnTransferencia.Size = new System.Drawing.Size(142, 20);
            this.rbtnTransferencia.TabIndex = 6;
            this.rbtnTransferencia.TabStop = true;
            this.rbtnTransferencia.Text = "Pago en transferencia";
            this.rbtnTransferencia.UseVisualStyleBackColor = true;
            // 
            // lboxNombresPacientesPagosAbonos
            // 
            this.lboxNombresPacientesPagosAbonos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxNombresPacientesPagosAbonos.FormattingEnabled = true;
            this.lboxNombresPacientesPagosAbonos.ItemHeight = 15;
            this.lboxNombresPacientesPagosAbonos.Location = new System.Drawing.Point(47, 39);
            this.lboxNombresPacientesPagosAbonos.Name = "lboxNombresPacientesPagosAbonos";
            this.lboxNombresPacientesPagosAbonos.Size = new System.Drawing.Size(139, 19);
            this.lboxNombresPacientesPagosAbonos.TabIndex = 7;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.BorderRadius = 20;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombrePaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblNombrePaciente.Location = new System.Drawing.Point(47, 13);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(139, 23);
            this.lblNombrePaciente.TabIndex = 8;
            this.lblNombrePaciente.Text = "Nombre del paciente:";
            this.lblNombrePaciente.Click += new System.EventHandler(this.lblNombrePaciente_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.lblTitulo.BorderRadius = 20;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(784, 53);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Pagos y abonos";
            // 
            // pbPacientePedido
            // 
            this.pbPacientePedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPacientePedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPacientePedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPacientePedido.Location = new System.Drawing.Point(239, 66);
            this.pbPacientePedido.Name = "pbPacientePedido";
            this.pbPacientePedido.Size = new System.Drawing.Size(140, 100);
            this.pbPacientePedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPacientePedido.TabIndex = 13;
            this.pbPacientePedido.TabStop = false;
            // 
            // labelRedondeado1
            // 
            this.labelRedondeado1.BorderRadius = 20;
            this.labelRedondeado1.Location = new System.Drawing.Point(236, 169);
            this.labelRedondeado1.Name = "labelRedondeado1";
            this.labelRedondeado1.Size = new System.Drawing.Size(143, 20);
            this.labelRedondeado1.TabIndex = 14;
            this.labelRedondeado1.Text = "Foto del paciente";
            this.labelRedondeado1.Click += new System.EventHandler(this.labelRedondeado1_Click);
            // 
            // Pagos_Abonos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(784, 470);
            this.Controls.Add(this.labelRedondeado1);
            this.Controls.Add(this.pbPacientePedido);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lboxPedidosPacientes);
            this.Controls.Add(this.panelRedondeado1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pagos_Abonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos y abonos";
            this.panelRedondeado1.ResumeLayout(false);
            this.panelRedondeado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacientePedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private botonRedondeado btnRecibirAbono;
        private botonRedondeado btnCancelarOperacion;
        private System.Windows.Forms.RadioButton rbtnEfectivo;
        private System.Windows.Forms.RadioButton rbtnPagoTarjetaDebito;
        private System.Windows.Forms.RadioButton rbtnPagoTarjetaCredito;
        private System.Windows.Forms.RadioButton rbtnTransferencia;
        private System.Windows.Forms.ListBox lboxNombresPacientesPagosAbonos;
        private labelRedondeado lblNombrePaciente;
        private panelRedondeado panelRedondeado1;
        private System.Windows.Forms.ListBox lboxPedidosPacientes;
        private botonRedondeado btnRecibirPago;
        private botonRedondeado btnMenu;
        private labelRedondeado lblTitulo;
        private System.Windows.Forms.PictureBox pbPacientePedido;
        private labelRedondeado labelRedondeado1;
    }
}