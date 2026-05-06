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
            this.lblProduccion = new Avance_Del_Proyecto.labelRedondeado();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPendientes = new Avance_Del_Proyecto.panelRedondeado();
            this.lblPendiente = new Avance_Del_Proyecto.labelRedondeado();
            this.panelProceso = new Avance_Del_Proyecto.panelRedondeado();
            this.lblProceso = new Avance_Del_Proyecto.labelRedondeado();
            this.panelTerminados = new Avance_Del_Proyecto.panelRedondeado();
            this.lblTerminados = new Avance_Del_Proyecto.labelRedondeado();
            this.panelControl = new Avance_Del_Proyecto.panelRedondeado();
            this.lblControl = new Avance_Del_Proyecto.labelRedondeado();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelPendientes.SuspendLayout();
            this.panelProceso.SuspendLayout();
            this.panelTerminados.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panelPendientes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelProceso, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelTerminados, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1070, 450);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.lblProceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProceso.BorderRadius = 20;
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
            this.lblTerminados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTerminados.BackColor = System.Drawing.Color.LimeGreen;
            this.lblTerminados.BorderRadius = 20;
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
            this.panelControl.Controls.Add(this.lblControl);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(804, 3);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(260, 441);
            this.panelControl.TabIndex = 6;
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
            // Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(1074, 538);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblProduccion);
            this.Name = "Produccion";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Produccion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelPendientes.ResumeLayout(false);
            this.panelProceso.ResumeLayout(false);
            this.panelTerminados.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private labelRedondeado lblProduccion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private panelRedondeado panelPendientes;
        private labelRedondeado lblPendiente;
        private panelRedondeado panelProceso;
        private labelRedondeado lblProceso;
        private panelRedondeado panelTerminados;
        private labelRedondeado lblTerminados;
        private panelRedondeado panelControl;
        private labelRedondeado lblControl;
    }
}