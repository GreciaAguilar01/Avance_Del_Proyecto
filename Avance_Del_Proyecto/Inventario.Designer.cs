namespace Avance_Del_Proyecto
{
    partial class Inventario
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelProductos = new Avance_Del_Proyecto.panelRedondeado();
            this.txtBuscar = new Avance_Del_Proyecto.textboxRedondeado();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.panelBotones = new Avance_Del_Proyecto.panelRedondeado();
            this.btnLimpiar = new Avance_Del_Proyecto.botonRedondeado();
            this.btnEliminar = new Avance_Del_Proyecto.botonRedondeado();
            this.btnEditar = new Avance_Del_Proyecto.botonRedondeado();
            this.btnAgregar = new Avance_Del_Proyecto.botonRedondeado();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new Avance_Del_Proyecto.textboxRedondeado();
            this.txtCodigo = new Avance_Del_Proyecto.textboxRedondeado();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new Avance_Del_Proyecto.textboxRedondeado();
            this.txtCantidad = new Avance_Del_Proyecto.textboxRedondeado();
            this.lblTitulo = new Avance_Del_Proyecto.labelRedondeado();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.72093F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.27907F));
            this.tableLayoutPanel1.Controls.Add(this.panelProductos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelBotones, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 55);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 351);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelProductos
            // 
            this.panelProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProductos.AutoScroll = true;
            this.panelProductos.BackColor = System.Drawing.Color.White;
            this.panelProductos.BorderRadius = 20;
            this.panelProductos.Controls.Add(this.txtBuscar);
            this.panelProductos.Controls.Add(this.dgvInventario);
            this.panelProductos.Location = new System.Drawing.Point(266, 5);
            this.panelProductos.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Padding = new System.Windows.Forms.Padding(10);
            this.panelProductos.Size = new System.Drawing.Size(508, 341);
            this.panelProductos.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.txtBuscar.BorderRadius = 15;
            this.txtBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.txtBuscar.Location = new System.Drawing.Point(345, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscar.Size = new System.Drawing.Size(150, 25);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextValue = "";
            // 
            // dgvInventario
            // 
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvInventario.Location = new System.Drawing.Point(10, 32);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(10);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(488, 301);
            this.dgvInventario.TabIndex = 0;
            this.dgvInventario.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvInventario_Paint);
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.AutoScroll = true;
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(74)))));
            this.panelBotones.BorderRadius = 30;
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Controls.Add(this.btnAgregar);
            this.panelBotones.Controls.Add(this.lblCodigoBarras);
            this.panelBotones.Controls.Add(this.lblFecha);
            this.panelBotones.Controls.Add(this.txtFecha);
            this.panelBotones.Controls.Add(this.txtCodigo);
            this.panelBotones.Controls.Add(this.lblCantidad);
            this.panelBotones.Controls.Add(this.lblProducto);
            this.panelBotones.Controls.Add(this.txtProducto);
            this.panelBotones.Controls.Add(this.txtCantidad);
            this.panelBotones.Location = new System.Drawing.Point(0, 5);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelBotones.Size = new System.Drawing.Size(256, 341);
            this.panelBotones.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(61)))));
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(61)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(15, 297);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(227, 30);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(61)))));
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(61)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(15, 265);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(227, 30);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(61)))));
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(61)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(14, 233);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(227, 30);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(61)))));
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(135)))), ((int)(((byte)(61)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(15, 201);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(227, 30);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarras.ForeColor = System.Drawing.Color.Aqua;
            this.lblCodigoBarras.Location = new System.Drawing.Point(17, 144);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(123, 19);
            this.lblCodigoBarras.TabIndex = 7;
            this.lblCodigoBarras.Text = "Código de barras:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Aqua;
            this.lblFecha.Location = new System.Drawing.Point(17, 98);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(123, 19);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de ingreso:";
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.txtFecha.BorderRadius = 15;
            this.txtFecha.Location = new System.Drawing.Point(15, 118);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFecha.Size = new System.Drawing.Size(227, 25);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.TextValue = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.txtCodigo.BorderRadius = 15;
            this.txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.txtCodigo.Location = new System.Drawing.Point(15, 164);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigo.Size = new System.Drawing.Size(227, 25);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextValue = "";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Aqua;
            this.lblCantidad.Location = new System.Drawing.Point(16, 52);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 19);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Aqua;
            this.lblProducto.Location = new System.Drawing.Point(16, 6);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(150, 19);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Nombre del producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.txtProducto.BorderRadius = 15;
            this.txtProducto.Location = new System.Drawing.Point(15, 26);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProducto.Size = new System.Drawing.Size(227, 25);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.TextValue = "";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.txtCantidad.BorderRadius = 15;
            this.txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.txtCantidad.Location = new System.Drawing.Point(15, 72);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCantidad.Size = new System.Drawing.Size(227, 25);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.TextValue = "";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.lblTitulo.BorderRadius = 20;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.lblTitulo.Location = new System.Drawing.Point(5, 5);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(20);
            this.lblTitulo.Size = new System.Drawing.Size(774, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTIÓN DE INVENTARIO";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Inventario";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Inventario";
            this.Resize += new System.EventHandler(this.Inventario_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private labelRedondeado lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private panelRedondeado panelProductos;
        private panelRedondeado panelBotones;
        private textboxRedondeado txtCantidad;
        private System.Windows.Forms.Label lblProducto;
        private textboxRedondeado txtProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.Label lblFecha;
        private textboxRedondeado txtFecha;
        private textboxRedondeado txtCodigo;
        private botonRedondeado btnAgregar;
        private botonRedondeado btnLimpiar;
        private botonRedondeado btnEliminar;
        private botonRedondeado btnEditar;
        private System.Windows.Forms.DataGridView dgvInventario;
        private textboxRedondeado txtBuscar;
    }
}