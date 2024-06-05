namespace CpLicoreria
{
    partial class FrmVenta
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
            this.components = new System.ComponentModel.Container();
            this.dvgListaVenta = new System.Windows.Forms.DataGridView();
            this.dvgIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.tbxIdProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.nudCantidadP = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbxProducto = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new C1.Win.C1Input.C1TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCi = new System.Windows.Forms.Label();
            this.txtrazonSocial = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbxVenta = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new C1.Win.C1Input.C1TextBox();
            this.erpCi = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpRazonSocial = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCodigo = new C1.Win.C1Input.C1TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListaVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadP)).BeginInit();
            this.gbxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            this.gbxCliente.SuspendLayout();
            this.gbxVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgListaVenta
            // 
            this.dvgListaVenta.AllowUserToAddRows = false;
            this.dvgListaVenta.AllowUserToDeleteRows = false;
            this.dvgListaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgIdProducto,
            this.dvgProducto,
            this.dvgPrecio,
            this.dvgCantidad,
            this.dvgSubTotal});
            this.dvgListaVenta.Location = new System.Drawing.Point(125, 382);
            this.dvgListaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dvgListaVenta.Name = "dvgListaVenta";
            this.dvgListaVenta.ReadOnly = true;
            this.dvgListaVenta.RowHeadersWidth = 51;
            this.dvgListaVenta.Size = new System.Drawing.Size(807, 185);
            this.dvgListaVenta.TabIndex = 23;
            // 
            // dvgIdProducto
            // 
            this.dvgIdProducto.HeaderText = "IdProducto";
            this.dvgIdProducto.MinimumWidth = 6;
            this.dvgIdProducto.Name = "dvgIdProducto";
            this.dvgIdProducto.ReadOnly = true;
            this.dvgIdProducto.Visible = false;
            this.dvgIdProducto.Width = 125;
            // 
            // dvgProducto
            // 
            this.dvgProducto.HeaderText = "Producto";
            this.dvgProducto.MinimumWidth = 6;
            this.dvgProducto.Name = "dvgProducto";
            this.dvgProducto.ReadOnly = true;
            this.dvgProducto.Width = 200;
            // 
            // dvgPrecio
            // 
            this.dvgPrecio.HeaderText = "Precio";
            this.dvgPrecio.MinimumWidth = 6;
            this.dvgPrecio.Name = "dvgPrecio";
            this.dvgPrecio.ReadOnly = true;
            this.dvgPrecio.Width = 120;
            // 
            // dvgCantidad
            // 
            this.dvgCantidad.HeaderText = "Cantidad";
            this.dvgCantidad.MinimumWidth = 6;
            this.dvgCantidad.Name = "dvgCantidad";
            this.dvgCantidad.ReadOnly = true;
            this.dvgCantidad.Width = 120;
            // 
            // dvgSubTotal
            // 
            this.dvgSubTotal.HeaderText = "Sub Total";
            this.dvgSubTotal.MinimumWidth = 6;
            this.dvgSubTotal.Name = "dvgSubTotal";
            this.dvgSubTotal.ReadOnly = true;
            this.dvgSubTotal.Width = 120;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(960, 421);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(962, 489);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(163, 63);
            this.btnRegistrarVenta.TabIndex = 21;
            this.btnRegistrarVenta.Text = " Registrar\r\nVenta";
            this.btnRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(92, 88);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(999, 38);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Registro Venta";
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(196, 49);
            this.cbxProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(160, 24);
            this.cbxProducto.TabIndex = 8;
            // 
            // tbxIdProducto
            // 
            this.tbxIdProducto.Location = new System.Drawing.Point(111, 20);
            this.tbxIdProducto.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIdProducto.Name = "tbxIdProducto";
            this.tbxIdProducto.Size = new System.Drawing.Size(31, 22);
            this.tbxIdProducto.TabIndex = 6;
            this.tbxIdProducto.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(581, 20);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 16);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(387, 25);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(192, 30);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 25);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            // 
            // nudCantidadP
            // 
            this.nudCantidadP.Location = new System.Drawing.Point(585, 47);
            this.nudCantidadP.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidadP.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCantidadP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadP.Name = "nudCantidadP";
            this.nudCantidadP.Size = new System.Drawing.Size(160, 22);
            this.nudCantidadP.TabIndex = 3;
            this.nudCantidadP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(968, 270);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 78);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // gbxProducto
            // 
            this.gbxProducto.Controls.Add(this.txtCodigo);
            this.gbxProducto.Controls.Add(this.txtPrecio);
            this.gbxProducto.Controls.Add(this.cbxProducto);
            this.gbxProducto.Controls.Add(this.tbxIdProducto);
            this.gbxProducto.Controls.Add(this.lblCantidad);
            this.gbxProducto.Controls.Add(this.lblPrecio);
            this.gbxProducto.Controls.Add(this.lblNombre);
            this.gbxProducto.Controls.Add(this.lblCodigo);
            this.gbxProducto.Controls.Add(this.nudCantidadP);
            this.gbxProducto.Location = new System.Drawing.Point(125, 248);
            this.gbxProducto.Margin = new System.Windows.Forms.Padding(4);
            this.gbxProducto.Name = "gbxProducto";
            this.gbxProducto.Padding = new System.Windows.Forms.Padding(4);
            this.gbxProducto.Size = new System.Drawing.Size(835, 100);
            this.gbxProducto.TabIndex = 19;
            this.gbxProducto.TabStop = false;
            this.gbxProducto.Text = "Información del Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(390, 47);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(133, 20);
            this.txtPrecio.TabIndex = 26;
            this.txtPrecio.Tag = null;
            this.txtPrecio.Value = "";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(408, 46);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(132, 22);
            this.txtCelular.TabIndex = 7;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(404, 25);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(49, 16);
            this.lblCelular.TabIndex = 6;
            this.lblCelular.Text = "Celular";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(228, 20);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(140, 16);
            this.lblRazonSocial.TabIndex = 3;
            this.lblRazonSocial.Text = "Nombre/Razón Social";
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Location = new System.Drawing.Point(8, 25);
            this.lblCi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(124, 16);
            this.lblCi.TabIndex = 2;
            this.lblCi.Text = "Carnet de Identidad";
            // 
            // txtrazonSocial
            // 
            this.txtrazonSocial.Location = new System.Drawing.Point(232, 44);
            this.txtrazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtrazonSocial.Name = "txtrazonSocial";
            this.txtrazonSocial.Size = new System.Drawing.Size(132, 22);
            this.txtrazonSocial.TabIndex = 1;
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(8, 44);
            this.txtCi.Margin = new System.Windows.Forms.Padding(4);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(132, 22);
            this.txtCi.TabIndex = 0;
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.txtCelular);
            this.gbxCliente.Controls.Add(this.lblCelular);
            this.gbxCliente.Controls.Add(this.lblRazonSocial);
            this.gbxCliente.Controls.Add(this.lblCi);
            this.gbxCliente.Controls.Add(this.txtrazonSocial);
            this.gbxCliente.Controls.Add(this.txtCi);
            this.gbxCliente.Location = new System.Drawing.Point(545, 142);
            this.gbxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCliente.Size = new System.Drawing.Size(545, 76);
            this.gbxCliente.TabIndex = 18;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Informacion del Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(8, 20);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(962, 559);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 63);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // gbxVenta
            // 
            this.gbxVenta.Controls.Add(this.dtpFecha);
            this.gbxVenta.Controls.Add(this.lblFecha);
            this.gbxVenta.Location = new System.Drawing.Point(125, 150);
            this.gbxVenta.Margin = new System.Windows.Forms.Padding(4);
            this.gbxVenta.Name = "gbxVenta";
            this.gbxVenta.Padding = new System.Windows.Forms.Padding(4);
            this.gbxVenta.Size = new System.Drawing.Size(267, 76);
            this.gbxVenta.TabIndex = 17;
            this.gbxVenta.TabStop = false;
            this.gbxVenta.Text = "Infromación Venta";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(9, 37);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(139, 22);
            this.dtpFecha.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(963, 450);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(181, 20);
            this.txtTotal.TabIndex = 25;
            this.txtTotal.Tag = null;
            // 
            // erpCi
            // 
            this.erpCi.ContainerControl = this;
            // 
            // erpRazonSocial
            // 
            this.erpRazonSocial.ContainerControl = this;
            // 
            // erpCelular
            // 
            this.erpCelular.ContainerControl = this;
            // 
            // erpProducto
            // 
            this.erpProducto.ContainerControl = this;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 53);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(133, 20);
            this.txtCodigo.TabIndex = 26;
            this.txtCodigo.Tag = null;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 710);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dvgListaVenta);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbxProducto);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbxVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dvgListaVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadP)).EndInit();
            this.gbxProducto.ResumeLayout(false);
            this.gbxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxVenta.ResumeLayout(false);
            this.gbxVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgListaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.TextBox tbxIdProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.NumericUpDown nudCantidadP;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbxProducto;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.TextBox txtrazonSocial;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gbxVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private C1.Win.C1Input.C1TextBox txtTotal;
        private System.Windows.Forms.ErrorProvider erpCi;
        private System.Windows.Forms.ErrorProvider erpRazonSocial;
        private System.Windows.Forms.ErrorProvider erpCelular;
        private System.Windows.Forms.ErrorProvider erpProducto;
        private C1.Win.C1Input.C1TextBox txtPrecio;
        private C1.Win.C1Input.C1TextBox txtCodigo;
    }
}