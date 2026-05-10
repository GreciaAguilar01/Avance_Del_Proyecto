namespace Avance_Del_Proyecto
{
    partial class Registro
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
            this.lblTitulo = new Avance_Del_Proyecto.labelRedondeado();
            this.panelRedondeado2 = new Avance_Del_Proyecto.panelRedondeado();
            this.btnGuardar = new Avance_Del_Proyecto.botonRedondeado();
            this.TbContrasena = new Avance_Del_Proyecto.textboxRedondeado();
            this.TbUsuario = new Avance_Del_Proyecto.textboxRedondeado();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRedondeado2.SuspendLayout();
            this.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(693, 57);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro";
            // 
            // panelRedondeado2
            // 
            this.panelRedondeado2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(131)))));
            this.panelRedondeado2.BorderRadius = 20;
            this.panelRedondeado2.Controls.Add(this.btnGuardar);
            this.panelRedondeado2.Controls.Add(this.TbContrasena);
            this.panelRedondeado2.Controls.Add(this.TbUsuario);
            this.panelRedondeado2.Controls.Add(this.label3);
            this.panelRedondeado2.Controls.Add(this.label2);
            this.panelRedondeado2.Location = new System.Drawing.Point(105, 89);
            this.panelRedondeado2.Margin = new System.Windows.Forms.Padding(2);
            this.panelRedondeado2.Name = "panelRedondeado2";
            this.panelRedondeado2.Size = new System.Drawing.Size(483, 241);
            this.panelRedondeado2.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(155)))), ((int)(((byte)(85)))));
            this.btnGuardar.BorderRadius = 35;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(132, 175);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(218, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TbContrasena
            // 
            this.TbContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.TbContrasena.BorderRadius = 20;
            this.TbContrasena.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.TbContrasena.Location = new System.Drawing.Point(24, 127);
            this.TbContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.TbContrasena.Name = "TbContrasena";
            this.TbContrasena.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TbContrasena.Size = new System.Drawing.Size(429, 30);
            this.TbContrasena.TabIndex = 3;
            this.TbContrasena.TextValue = "";
            // 
            // TbUsuario
            // 
            this.TbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.TbUsuario.BorderRadius = 20;
            this.TbUsuario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.TbUsuario.Location = new System.Drawing.Point(22, 54);
            this.TbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TbUsuario.Size = new System.Drawing.Size(429, 29);
            this.TbUsuario.TabIndex = 2;
            this.TbUsuario.TextValue = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Crear Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nuevo Usuario:";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(693, 419);
            this.Controls.Add(this.panelRedondeado2);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.panelRedondeado2.ResumeLayout(false);
            this.panelRedondeado2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private labelRedondeado lblTitulo;
        private panelRedondeado panelRedondeado2;
        private botonRedondeado btnGuardar;
        private textboxRedondeado TbContrasena;
        private textboxRedondeado TbUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}