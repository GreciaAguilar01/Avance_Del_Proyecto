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
    public partial class Pagos_Abonos : Form
    {
        private botonRedondeado btnRecibirAbono;
        private botonRedondeado btnCancelarOperacion;
        private RadioButton rbtnEfectivo;
        private RadioButton rbtnPagoTarjetaDebito;
        private RadioButton rbtnPagoTarjetaCredito;
        private RadioButton rbtnTransferencia;
        private ListBox lboxNombresPacientes;
        private labelRedondeado lblNombrePaciente;
        private PictureBox pboxFotoPaciente;
        private panelRedondeado panelRedondeado1;
        private ListBox lboxPedidosPacientes;
        private botonRedondeado btnRecibirPago;

        public Pagos_Abonos() => InitializeComponent();

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos_Abonos));
            this.btnRecibirPago = new Avance_Del_Proyecto.botonRedondeado();
            this.btnRecibirAbono = new Avance_Del_Proyecto.botonRedondeado();
            this.btnCancelarOperacion = new Avance_Del_Proyecto.botonRedondeado();
            this.rbtnEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtnPagoTarjetaDebito = new System.Windows.Forms.RadioButton();
            this.rbtnPagoTarjetaCredito = new System.Windows.Forms.RadioButton();
            this.rbtnTransferencia = new System.Windows.Forms.RadioButton();
            this.lboxNombresPacientes = new System.Windows.Forms.ListBox();
            this.lblNombrePaciente = new Avance_Del_Proyecto.labelRedondeado();
            this.pboxFotoPaciente = new System.Windows.Forms.PictureBox();
            this.panelRedondeado1 = new Avance_Del_Proyecto.panelRedondeado();
            this.lboxPedidosPacientes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFotoPaciente)).BeginInit();
            this.panelRedondeado1.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // btnRecibirAbono
            // 
            this.btnRecibirAbono.BackColor = System.Drawing.Color.Yellow;
            this.btnRecibirAbono.BorderRadius = 20;
            this.btnRecibirAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibirAbono.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRecibirAbono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRecibirAbono.Location = new System.Drawing.Point(39, 285);
            this.btnRecibirAbono.Name = "btnRecibirAbono";
            this.btnRecibirAbono.Size = new System.Drawing.Size(140, 30);
            this.btnRecibirAbono.TabIndex = 1;
            this.btnRecibirAbono.Text = "Recibir abono";
            this.btnRecibirAbono.UseVisualStyleBackColor = false;
            // 
            // btnCancelarOperacion
            // 
            this.btnCancelarOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelarOperacion.BorderRadius = 20;
            this.btnCancelarOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarOperacion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelarOperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelarOperacion.Location = new System.Drawing.Point(39, 323);
            this.btnCancelarOperacion.Name = "btnCancelarOperacion";
            this.btnCancelarOperacion.Size = new System.Drawing.Size(140, 30);
            this.btnCancelarOperacion.TabIndex = 2;
            this.btnCancelarOperacion.Text = "Cancelar operación";
            this.btnCancelarOperacion.UseVisualStyleBackColor = false;
            this.btnCancelarOperacion.Click += new System.EventHandler(this.btnCancelarOperacion_Click);
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
            // lboxNombresPacientes
            // 
            this.lboxNombresPacientes.FormattingEnabled = true;
            this.lboxNombresPacientes.Location = new System.Drawing.Point(57, 39);
            this.lboxNombresPacientes.Name = "lboxNombresPacientes";
            this.lboxNombresPacientes.Size = new System.Drawing.Size(139, 30);
            this.lboxNombresPacientes.TabIndex = 7;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.BorderRadius = 20;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombrePaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblNombrePaciente.Location = new System.Drawing.Point(55, 13);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(139, 23);
            this.lblNombrePaciente.TabIndex = 8;
            this.lblNombrePaciente.Text = "Nombre del paciente:";
            this.lblNombrePaciente.Click += new System.EventHandler(this.lblNombrePaciente_Click);
            // 
            // pboxFotoPaciente
            // 
            this.pboxFotoPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pboxFotoPaciente.Location = new System.Drawing.Point(274, 12);
            this.pboxFotoPaciente.Name = "pboxFotoPaciente";
            this.pboxFotoPaciente.Size = new System.Drawing.Size(139, 123);
            this.pboxFotoPaciente.TabIndex = 9;
            this.pboxFotoPaciente.TabStop = false;
            // 
            // panelRedondeado1
            // 
            this.panelRedondeado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.panelRedondeado1.BorderRadius = 20;
            this.panelRedondeado1.Controls.Add(this.rbtnEfectivo);
            this.panelRedondeado1.Controls.Add(this.rbtnPagoTarjetaDebito);
            this.panelRedondeado1.Controls.Add(this.btnCancelarOperacion);
            this.panelRedondeado1.Controls.Add(this.btnRecibirAbono);
            this.panelRedondeado1.Controls.Add(this.rbtnPagoTarjetaCredito);
            this.panelRedondeado1.Controls.Add(this.btnRecibirPago);
            this.panelRedondeado1.Controls.Add(this.rbtnTransferencia);
            this.panelRedondeado1.Controls.Add(this.lboxNombresPacientes);
            this.panelRedondeado1.Controls.Add(this.lblNombrePaciente);
            this.panelRedondeado1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.panelRedondeado1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRedondeado1.Location = new System.Drawing.Point(0, 0);
            this.panelRedondeado1.Name = "panelRedondeado1";
            this.panelRedondeado1.Size = new System.Drawing.Size(233, 411);
            this.panelRedondeado1.TabIndex = 10;
            // 
            // lboxPedidosPacientes
            // 
            this.lboxPedidosPacientes.FormattingEnabled = true;
            this.lboxPedidosPacientes.Location = new System.Drawing.Point(274, 156);
            this.lboxPedidosPacientes.Name = "lboxPedidosPacientes";
            this.lboxPedidosPacientes.Size = new System.Drawing.Size(506, 251);
            this.lboxPedidosPacientes.TabIndex = 11;
            // 
            // Pagos_Abonos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lboxPedidosPacientes);
            this.Controls.Add(this.pboxFotoPaciente);
            this.Controls.Add(this.panelRedondeado1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pagos_Abonos";
            this.Text = "Pagos y abonos";
            ((System.ComponentModel.ISupportInitialize)(this.pboxFotoPaciente)).EndInit();
            this.panelRedondeado1.ResumeLayout(false);
            this.panelRedondeado1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void lblNombrePaciente_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarOperacion_Click(object sender, EventArgs e)
        {

        }
    }
}
