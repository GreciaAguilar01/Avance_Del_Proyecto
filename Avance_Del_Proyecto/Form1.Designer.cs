namespace Avance_Del_Proyecto
{
    //oal
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRedondeado2 = new Avance_Del_Proyecto.panelRedondeado();
            this.BtnIS = new Avance_Del_Proyecto.botonRedondeado();
            this.TbContrasena = new Avance_Del_Proyecto.textboxRedondeado();
            this.TbUsuario = new Avance_Del_Proyecto.textboxRedondeado();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRedondeado1 = new Avance_Del_Proyecto.panelRedondeado();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRedondeado2.SuspendLayout();
            this.panelRedondeado1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRedondeado2
            // 
            this.panelRedondeado2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(152)))), ((int)(((byte)(100)))));
            this.panelRedondeado2.BorderRadius = 20;
            this.panelRedondeado2.Controls.Add(this.BtnIS);
            this.panelRedondeado2.Controls.Add(this.TbContrasena);
            this.panelRedondeado2.Controls.Add(this.TbUsuario);
            this.panelRedondeado2.Controls.Add(this.label3);
            this.panelRedondeado2.Controls.Add(this.label2);
            this.panelRedondeado2.Location = new System.Drawing.Point(228, 154);
            this.panelRedondeado2.Name = "panelRedondeado2";
            this.panelRedondeado2.Size = new System.Drawing.Size(644, 297);
            this.panelRedondeado2.TabIndex = 2;
            // 
            // BtnIS
            // 
            this.BtnIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(155)))), ((int)(((byte)(85)))));
            this.BtnIS.BorderRadius = 35;
            this.BtnIS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(155)))), ((int)(((byte)(85)))));
            this.BtnIS.FlatAppearance.BorderSize = 0;
            this.BtnIS.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIS.Location = new System.Drawing.Point(30, 219);
            this.BtnIS.Name = "BtnIS";
            this.BtnIS.Size = new System.Drawing.Size(587, 62);
            this.BtnIS.TabIndex = 4;
            this.BtnIS.Text = "Iniciar Sesión";
            this.BtnIS.UseVisualStyleBackColor = false;
            this.BtnIS.Click += new System.EventHandler(this.BtnIS_Click);
            // 
            // TbContrasena
            // 
            this.TbContrasena.BorderRadius = 20;
            this.TbContrasena.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbContrasena.Location = new System.Drawing.Point(32, 156);
            this.TbContrasena.Name = "TbContrasena";
            this.TbContrasena.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TbContrasena.Size = new System.Drawing.Size(572, 36);
            this.TbContrasena.TabIndex = 3;
            this.TbContrasena.TextValue = "";
            // 
            // TbUsuario
            // 
            this.TbUsuario.BorderRadius = 20;
            this.TbUsuario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsuario.Location = new System.Drawing.Point(30, 67);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TbUsuario.Size = new System.Drawing.Size(572, 36);
            this.TbUsuario.TabIndex = 2;
            this.TbUsuario.TextValue = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // panelRedondeado1
            // 
            this.panelRedondeado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.panelRedondeado1.BorderRadius = 20;
            this.panelRedondeado1.Controls.Add(this.label1);
            this.panelRedondeado1.Location = new System.Drawing.Point(-6, -2);
            this.panelRedondeado1.Name = "panelRedondeado1";
            this.panelRedondeado1.Size = new System.Drawing.Size(1076, 100);
            this.panelRedondeado1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(214, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ortopedia del Niño y del Diabetico - Inicio de Sesión";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(1066, 477);
            this.Controls.Add(this.panelRedondeado2);
            this.Controls.Add(this.panelRedondeado1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1121, 558);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelRedondeado2.ResumeLayout(false);
            this.panelRedondeado2.PerformLayout();
            this.panelRedondeado1.ResumeLayout(false);

        private System.Windows.Forms.Label label1;
        private panelRedondeado panelRedondeado1;
        private panelRedondeado panelRedondeado2;
        private System.Windows.Forms.Label label2;
        private botonRedondeado BtnIS;
        private textboxRedondeado TbContrasena;
        private textboxRedondeado TbUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnIS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnIS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

