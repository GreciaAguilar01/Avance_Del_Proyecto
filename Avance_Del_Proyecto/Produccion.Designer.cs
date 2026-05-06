namespace Avance_Del_Proyecto
{
    partial class Produccion
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
            this.tblGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.panelPendientes = new Avance_Del_Proyecto.panelRedondeado();
            this.lblPendiente = new Avance_Del_Proyecto.labelRedondeado();
            this.panelProceso = new Avance_Del_Proyecto.panelRedondeado();
            this.lblProceso = new Avance_Del_Proyecto.labelRedondeado();
            this.panelTerminados = new Avance_Del_Proyecto.panelRedondeado();
            this.lblTerminados = new Avance_Del_Proyecto.labelRedondeado();
            this.panelControl = new Avance_Del_Proyecto.panelRedondeado();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.tblResumen = new System.Windows.Forms.TableLayoutPanel();
            this.lblUrg = new System.Windows.Forms.Label();
            this.lblUrgentes = new System.Windows.Forms.Label();
            this.lblTrm = new System.Windows.Forms.Label();
            this.lblTerminadoss = new System.Windows.Forms.Label();
            this.lblPrc = new System.Windows.Forms.Label();
            this.lblEnProceso = new System.Windows.Forms.Label();
            this.lblPen = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblTtlR = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNuevoPedido = new Avance_Del_Proyecto.botonRedondeado();
            this.lblControl = new Avance_Del_Proyecto.labelRedondeado();
            this.lblProduccion = new Avance_Del_Proyecto.labelRedondeado();
            this.tblGeneral.SuspendLayout();
            this.panelPendientes.SuspendLayout();
            this.panelProceso.SuspendLayout();
            this.panelTerminados.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.gbResumen.SuspendLayout();
            this.tblResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblGeneral
            // 
            this.tblGeneral.ColumnCount = 4;
            this.tblGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGeneral.Controls.Add(this.panelPendientes, 0, 0);
            this.tblGeneral.Controls.Add(this.panelProceso, 1, 0);
            this.tblGeneral.Controls.Add(this.panelTerminados, 2, 0);
            this.tblGeneral.Controls.Add(this.panelControl, 3, 0);
            this.tblGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGeneral.Location = new System.Drawing.Point(2, 86);
            this.tblGeneral.Name = "tblGeneral";
            this.tblGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tblGeneral.RowCount = 1;
            this.tblGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGeneral.Size = new System.Drawing.Size(1070, 450);
            this.tblGeneral.TabIndex = 1;
            // 
            // panelPendientes
            // 
            this.panelPendientes.AutoScroll = true;
            this.panelPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.panelPendientes.BorderRadius = 20;
            this.panelPendientes.Controls.Add(this.lblPendiente);
            this.panelPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPendientes.Location = new System.Drawing.Point(6, 3);
            this.panelPendientes.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelPendientes.Name = "panelPendientes";
            this.panelPendientes.Size = new System.Drawing.Size(260, 441);
            this.panelPendientes.TabIndex = 2;
            // 
            // lblPendiente
            // 
            this.lblPendiente.BackColor = System.Drawing.Color.Silver;
            this.lblPendiente.BorderRadius = 20;
            this.lblPendiente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPendiente.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendiente.Location = new System.Drawing.Point(0, 0);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(260, 36);
            this.lblPendiente.TabIndex = 0;
            this.lblPendiente.Text = "Pedidos Pendientes";
            this.lblPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProceso
            // 
            this.panelProceso.AutoScroll = true;
            this.panelProceso.BorderRadius = 20;
            this.panelProceso.Controls.Add(this.lblProceso);
            this.panelProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProceso.Location = new System.Drawing.Point(272, 3);
            this.panelProceso.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelProceso.Name = "panelProceso";
            this.panelProceso.Size = new System.Drawing.Size(260, 441);
            this.panelProceso.TabIndex = 4;
            // 
            // lblProceso
            // 
            this.lblProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProceso.BorderRadius = 20;
            this.lblProceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProceso.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProceso.Location = new System.Drawing.Point(0, 0);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(260, 36);
            this.lblProceso.TabIndex = 0;
            this.lblProceso.Text = "En proceso";
            this.lblProceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTerminados
            // 
            this.panelTerminados.AutoScroll = true;
            this.panelTerminados.BorderRadius = 20;
            this.panelTerminados.Controls.Add(this.lblTerminados);
            this.panelTerminados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTerminados.Location = new System.Drawing.Point(538, 3);
            this.panelTerminados.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelTerminados.Name = "panelTerminados";
            this.panelTerminados.Size = new System.Drawing.Size(260, 441);
            this.panelTerminados.TabIndex = 5;
            // 
            // lblTerminados
            // 
            this.lblTerminados.BackColor = System.Drawing.Color.LimeGreen;
            this.lblTerminados.BorderRadius = 20;
            this.lblTerminados.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTerminados.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminados.Location = new System.Drawing.Point(0, 0);
            this.lblTerminados.Name = "lblTerminados";
            this.lblTerminados.Size = new System.Drawing.Size(260, 36);
            this.lblTerminados.TabIndex = 0;
            this.lblTerminados.Text = "Terminados";
            this.lblTerminados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl
            // 
            this.panelControl.AutoScroll = true;
            this.panelControl.BorderRadius = 20;
            this.panelControl.Controls.Add(this.gbResumen);
            this.panelControl.Controls.Add(this.lblBuscar);
            this.panelControl.Controls.Add(this.txtBuscar);
            this.panelControl.Controls.Add(this.btnNuevoPedido);
            this.panelControl.Controls.Add(this.lblControl);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(804, 3);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(260, 441);
            this.panelControl.TabIndex = 6;
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.tblResumen);
            this.gbResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbResumen.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumen.Location = new System.Drawing.Point(12, 187);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Size = new System.Drawing.Size(237, 175);
            this.gbResumen.TabIndex = 4;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = "Resumen";
            // 
            // tblResumen
            // 
            this.tblResumen.ColumnCount = 2;
            this.tblResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblResumen.Controls.Add(this.lblUrg, 1, 4);
            this.tblResumen.Controls.Add(this.lblUrgentes, 0, 4);
            this.tblResumen.Controls.Add(this.lblTrm, 1, 3);
            this.tblResumen.Controls.Add(this.lblTerminadoss, 0, 3);
            this.tblResumen.Controls.Add(this.lblPrc, 1, 2);
            this.tblResumen.Controls.Add(this.lblEnProceso, 0, 2);
            this.tblResumen.Controls.Add(this.lblPen, 1, 1);
            this.tblResumen.Controls.Add(this.lblPendientes, 0, 1);
            this.tblResumen.Controls.Add(this.lblTtlR, 1, 0);
            this.tblResumen.Controls.Add(this.lblTotal, 0, 0);
            this.tblResumen.Location = new System.Drawing.Point(6, 27);
            this.tblResumen.Name = "tblResumen";
            this.tblResumen.RowCount = 5;
            this.tblResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblResumen.Size = new System.Drawing.Size(225, 142);
            this.tblResumen.TabIndex = 3;
            // 
            // lblUrg
            // 
            this.lblUrg.AutoSize = true;
            this.lblUrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUrg.Location = new System.Drawing.Point(183, 112);
            this.lblUrg.Name = "lblUrg";
            this.lblUrg.Size = new System.Drawing.Size(39, 30);
            this.lblUrg.TabIndex = 9;
            // 
            // lblUrgentes
            // 
            this.lblUrgentes.AutoSize = true;
            this.lblUrgentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUrgentes.Location = new System.Drawing.Point(3, 112);
            this.lblUrgentes.Name = "lblUrgentes";
            this.lblUrgentes.Size = new System.Drawing.Size(174, 30);
            this.lblUrgentes.TabIndex = 8;
            this.lblUrgentes.Text = "Urgentes:";
            // 
            // lblTrm
            // 
            this.lblTrm.AutoSize = true;
            this.lblTrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrm.Location = new System.Drawing.Point(183, 84);
            this.lblTrm.Name = "lblTrm";
            this.lblTrm.Size = new System.Drawing.Size(39, 28);
            this.lblTrm.TabIndex = 7;
            // 
            // lblTerminadoss
            // 
            this.lblTerminadoss.AutoSize = true;
            this.lblTerminadoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTerminadoss.Location = new System.Drawing.Point(3, 84);
            this.lblTerminadoss.Name = "lblTerminadoss";
            this.lblTerminadoss.Size = new System.Drawing.Size(174, 28);
            this.lblTerminadoss.TabIndex = 6;
            this.lblTerminadoss.Text = "Terminados:";
            // 
            // lblPrc
            // 
            this.lblPrc.AutoSize = true;
            this.lblPrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrc.Location = new System.Drawing.Point(183, 56);
            this.lblPrc.Name = "lblPrc";
            this.lblPrc.Size = new System.Drawing.Size(39, 28);
            this.lblPrc.TabIndex = 5;
            // 
            // lblEnProceso
            // 
            this.lblEnProceso.AutoSize = true;
            this.lblEnProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnProceso.Location = new System.Drawing.Point(3, 56);
            this.lblEnProceso.Name = "lblEnProceso";
            this.lblEnProceso.Size = new System.Drawing.Size(174, 28);
            this.lblEnProceso.TabIndex = 4;
            this.lblEnProceso.Text = "En Proceso:";
            // 
            // lblPen
            // 
            this.lblPen.AutoSize = true;
            this.lblPen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPen.Location = new System.Drawing.Point(183, 28);
            this.lblPen.Name = "lblPen";
            this.lblPen.Size = new System.Drawing.Size(39, 28);
            this.lblPen.TabIndex = 3;
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendientes.Location = new System.Drawing.Point(3, 28);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(174, 28);
            this.lblPendientes.TabIndex = 2;
            this.lblPendientes.Text = "Pendientes:";
            // 
            // lblTtlR
            // 
            this.lblTtlR.AutoSize = true;
            this.lblTtlR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTtlR.Location = new System.Drawing.Point(183, 0);
            this.lblTtlR.Name = "lblTtlR";
            this.lblTtlR.Size = new System.Drawing.Size(39, 28);
            this.lblTtlR.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Location = new System.Drawing.Point(3, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(174, 28);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Pedidos:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(3, 129);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(56, 20);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(65, 129);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.btnNuevoPedido.BorderRadius = 20;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPedido.Location = new System.Drawing.Point(4, 65);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(252, 43);
            this.btnNuevoPedido.TabIndex = 1;
            this.btnNuevoPedido.Text = "Nuevo Pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = false;
            // 
            // lblControl
            // 
            this.lblControl.BackColor = System.Drawing.Color.Black;
            this.lblControl.BorderRadius = 20;
            this.lblControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblControl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.ForeColor = System.Drawing.Color.White;
            this.lblControl.Location = new System.Drawing.Point(0, 0);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(260, 36);
            this.lblControl.TabIndex = 0;
            this.lblControl.Text = "Control / Resumen";
            this.lblControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProduccion
            // 
            this.lblProduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.lblProduccion.BorderRadius = 20;
            this.lblProduccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProduccion.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblProduccion.Location = new System.Drawing.Point(2, 2);
            this.lblProduccion.Margin = new System.Windows.Forms.Padding(3);
            this.lblProduccion.Name = "lblProduccion";
            this.lblProduccion.Padding = new System.Windows.Forms.Padding(3);
            this.lblProduccion.Size = new System.Drawing.Size(1070, 84);
            this.lblProduccion.TabIndex = 0;
            this.lblProduccion.Text = "Producción";
            // 
            // Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(1074, 538);
            this.Controls.Add(this.tblGeneral);
            this.Controls.Add(this.lblProduccion);
            this.Name = "Produccion";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Produccion";
            this.Resize += new System.EventHandler(this.Produccion_Resize);
            this.tblGeneral.ResumeLayout(false);
            this.panelPendientes.ResumeLayout(false);
            this.panelProceso.ResumeLayout(false);
            this.panelTerminados.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.gbResumen.ResumeLayout(false);
            this.tblResumen.ResumeLayout(false);
            this.tblResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private labelRedondeado lblProduccion;
        private System.Windows.Forms.TableLayoutPanel tblGeneral;
        private panelRedondeado panelPendientes;
        private labelRedondeado lblPendiente;
        private panelRedondeado panelProceso;
        private labelRedondeado lblProceso;
        private panelRedondeado panelTerminados;
        private labelRedondeado lblTerminados;
        private panelRedondeado panelControl;
        private labelRedondeado lblControl;
        private botonRedondeado btnNuevoPedido;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TableLayoutPanel tblResumen;
        private System.Windows.Forms.Label lblEnProceso;
        private System.Windows.Forms.Label lblPen;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblTtlR;
        private System.Windows.Forms.Label lblUrg;
        private System.Windows.Forms.Label lblUrgentes;
        private System.Windows.Forms.Label lblTrm;
        private System.Windows.Forms.Label lblTerminadoss;
        private System.Windows.Forms.Label lblPrc;
    }
}