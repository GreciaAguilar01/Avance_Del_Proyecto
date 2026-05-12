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
            this.flowPendientes = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPendiente = new Avance_Del_Proyecto.labelRedondeado();
            this.panelProceso = new Avance_Del_Proyecto.panelRedondeado();
            this.flowProceso = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProceso = new Avance_Del_Proyecto.labelRedondeado();
            this.panelTerminados = new Avance_Del_Proyecto.panelRedondeado();
            this.flowTerminados = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTerminados = new Avance_Del_Proyecto.labelRedondeado();
            this.panelControl = new Avance_Del_Proyecto.panelRedondeado();
            this.button1 = new System.Windows.Forms.Button();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.tblResumen = new System.Windows.Forms.TableLayoutPanel();
            this.lblUrgentes2 = new System.Windows.Forms.Label();
            this.lblUrgentes = new System.Windows.Forms.Label();
            this.lblTerminados2 = new System.Windows.Forms.Label();
            this.lblTerminadoss = new System.Windows.Forms.Label();
            this.lblEnProceso2 = new System.Windows.Forms.Label();
            this.lblEnProceso = new System.Windows.Forms.Label();
            this.lblPendientes2 = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
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
            this.panelPendientes.Controls.Add(this.flowPendientes);
            this.panelPendientes.Controls.Add(this.lblPendiente);
            this.panelPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPendientes.Location = new System.Drawing.Point(6, 3);
            this.panelPendientes.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelPendientes.Name = "panelPendientes";
            this.panelPendientes.Size = new System.Drawing.Size(260, 441);
            this.panelPendientes.TabIndex = 2;
            // 
            // flowPendientes
            // 
            this.flowPendientes.AutoScroll = true;
            this.flowPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPendientes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPendientes.Location = new System.Drawing.Point(0, 36);
            this.flowPendientes.Name = "flowPendientes";
            this.flowPendientes.Size = new System.Drawing.Size(260, 405);
            this.flowPendientes.TabIndex = 1;
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
            this.panelProceso.Controls.Add(this.flowProceso);
            this.panelProceso.Controls.Add(this.lblProceso);
            this.panelProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProceso.Location = new System.Drawing.Point(272, 3);
            this.panelProceso.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelProceso.Name = "panelProceso";
            this.panelProceso.Size = new System.Drawing.Size(260, 441);
            this.panelProceso.TabIndex = 4;
            // 
            // flowProceso
            // 
            this.flowProceso.AutoScroll = true;
            this.flowProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowProceso.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowProceso.Location = new System.Drawing.Point(0, 36);
            this.flowProceso.Name = "flowProceso";
            this.flowProceso.Size = new System.Drawing.Size(260, 405);
            this.flowProceso.TabIndex = 1;
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
            this.panelTerminados.Controls.Add(this.flowTerminados);
            this.panelTerminados.Controls.Add(this.lblTerminados);
            this.panelTerminados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTerminados.Location = new System.Drawing.Point(538, 3);
            this.panelTerminados.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelTerminados.Name = "panelTerminados";
            this.panelTerminados.Size = new System.Drawing.Size(260, 441);
            this.panelTerminados.TabIndex = 5;
            // 
            // flowTerminados
            // 
            this.flowTerminados.AutoScroll = true;
            this.flowTerminados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTerminados.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTerminados.Location = new System.Drawing.Point(0, 36);
            this.flowTerminados.Name = "flowTerminados";
            this.flowTerminados.Size = new System.Drawing.Size(260, 405);
            this.flowTerminados.TabIndex = 1;
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
            this.panelControl.Controls.Add(this.button1);
            this.panelControl.Controls.Add(this.gbResumen);
            this.panelControl.Controls.Add(this.lblControl);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(804, 3);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(260, 441);
            this.panelControl.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Menú";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.tblResumen);
            this.gbResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbResumen.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumen.Location = new System.Drawing.Point(12, 130);
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
            this.tblResumen.Controls.Add(this.lblUrgentes2, 1, 4);
            this.tblResumen.Controls.Add(this.lblUrgentes, 0, 4);
            this.tblResumen.Controls.Add(this.lblTerminados2, 1, 3);
            this.tblResumen.Controls.Add(this.lblTerminadoss, 0, 3);
            this.tblResumen.Controls.Add(this.lblEnProceso2, 1, 2);
            this.tblResumen.Controls.Add(this.lblEnProceso, 0, 2);
            this.tblResumen.Controls.Add(this.lblPendientes2, 1, 1);
            this.tblResumen.Controls.Add(this.lblPendientes, 0, 1);
            this.tblResumen.Controls.Add(this.lblTotal2, 1, 0);
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
            // lblUrgentes2
            // 
            this.lblUrgentes2.AutoSize = true;
            this.lblUrgentes2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUrgentes2.Location = new System.Drawing.Point(183, 112);
            this.lblUrgentes2.Name = "lblUrgentes2";
            this.lblUrgentes2.Size = new System.Drawing.Size(39, 30);
            this.lblUrgentes2.TabIndex = 9;
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
            // lblTerminados2
            // 
            this.lblTerminados2.AutoSize = true;
            this.lblTerminados2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTerminados2.Location = new System.Drawing.Point(183, 84);
            this.lblTerminados2.Name = "lblTerminados2";
            this.lblTerminados2.Size = new System.Drawing.Size(39, 28);
            this.lblTerminados2.TabIndex = 7;
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
            // lblEnProceso2
            // 
            this.lblEnProceso2.AutoSize = true;
            this.lblEnProceso2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnProceso2.Location = new System.Drawing.Point(183, 56);
            this.lblEnProceso2.Name = "lblEnProceso2";
            this.lblEnProceso2.Size = new System.Drawing.Size(39, 28);
            this.lblEnProceso2.TabIndex = 5;
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
            // lblPendientes2
            // 
            this.lblPendientes2.AutoSize = true;
            this.lblPendientes2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendientes2.Location = new System.Drawing.Point(183, 28);
            this.lblPendientes2.Name = "lblPendientes2";
            this.lblPendientes2.Size = new System.Drawing.Size(39, 28);
            this.lblPendientes2.TabIndex = 3;
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
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal2.Location = new System.Drawing.Point(183, 0);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(39, 28);
            this.lblTotal2.TabIndex = 1;
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
            this.lblControl.Text = "Resumen";
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
            this.MaximizeBox = false;
            this.Name = "Produccion";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion";
            this.Resize += new System.EventHandler(this.Produccion_Resize);
            this.tblGeneral.ResumeLayout(false);
            this.panelPendientes.ResumeLayout(false);
            this.panelProceso.ResumeLayout(false);
            this.panelTerminados.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TableLayoutPanel tblResumen;
        private System.Windows.Forms.Label lblEnProceso;
        private System.Windows.Forms.Label lblPendientes2;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblUrgentes2;
        private System.Windows.Forms.Label lblUrgentes;
        private System.Windows.Forms.Label lblTerminados2;
        private System.Windows.Forms.Label lblTerminadoss;
        private System.Windows.Forms.Label lblEnProceso2;
        private System.Windows.Forms.FlowLayoutPanel flowPendientes;
        private System.Windows.Forms.FlowLayoutPanel flowProceso;
        private System.Windows.Forms.FlowLayoutPanel flowTerminados;
        private System.Windows.Forms.Button button1;
    }
}