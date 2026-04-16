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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnIS = new System.Windows.Forms.Button();
            this.TbUsuario = new System.Windows.Forms.TextBox();
            this.TbContraseña = new System.Windows.Forms.TextBox();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.PanelTitulo.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(236, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ortopedia del niño y del diabetico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // BtnIS
            // 
            this.BtnIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(105)))), ((int)(((byte)(190)))));
            this.BtnIS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnIS.FlatAppearance.BorderSize = 0;
            this.BtnIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIS.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.BtnIS.Location = new System.Drawing.Point(62, 177);
            this.BtnIS.Name = "BtnIS";
            this.BtnIS.Size = new System.Drawing.Size(176, 36);
            this.BtnIS.TabIndex = 3;
            this.BtnIS.Text = "Iniciar Sesión";
            this.BtnIS.UseVisualStyleBackColor = false;
            this.BtnIS.Click += new System.EventHandler(this.BtnIS_Click);
            // 
            // TbUsuario
            // 
            this.TbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.TbUsuario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsuario.ForeColor = System.Drawing.Color.White;
            this.TbUsuario.Location = new System.Drawing.Point(21, 54);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.Size = new System.Drawing.Size(269, 30);
            this.TbUsuario.TabIndex = 4;
            // 
            // TbContraseña
            // 
            this.TbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.TbContraseña.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbContraseña.ForeColor = System.Drawing.Color.White;
            this.TbContraseña.Location = new System.Drawing.Point(27, 130);
            this.TbContraseña.Name = "TbContraseña";
            this.TbContraseña.Size = new System.Drawing.Size(263, 30);
            this.TbContraseña.TabIndex = 5;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.PanelTitulo.Controls.Add(this.label4);
            this.PanelTitulo.Controls.Add(this.label1);
            this.PanelTitulo.Location = new System.Drawing.Point(41, 12);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(765, 61);
            this.PanelTitulo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(336, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Inicio de Sesión";
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(118)))));
            this.PanelLogin.Controls.Add(this.label2);
            this.PanelLogin.Controls.Add(this.label3);
            this.PanelLogin.Controls.Add(this.BtnIS);
            this.PanelLogin.Controls.Add(this.TbContraseña);
            this.PanelLogin.Controls.Add(this.TbUsuario);
            this.PanelLogin.Location = new System.Drawing.Point(267, 98);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(311, 248);
            this.PanelLogin.TabIndex = 7;
            this.PanelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLogin_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(841, 453);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.PanelTitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnIS;
        private System.Windows.Forms.TextBox TbUsuario;
        private System.Windows.Forms.TextBox TbContraseña;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelLogin;
    }
}

