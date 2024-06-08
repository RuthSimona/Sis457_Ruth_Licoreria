namespace CpLicoreria
{
    partial class FrmBusqueda
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
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.gbxListaProductos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.gbxListaProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(21, 21);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowHeadersWidth = 51;
            this.dgvListaProductos.RowTemplate.Height = 24;
            this.dgvListaProductos.Size = new System.Drawing.Size(988, 315);
            this.dgvListaProductos.TabIndex = 0;
            this.dgvListaProductos.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // gbxListaProductos
            // 
            this.gbxListaProductos.Controls.Add(this.dgvListaProductos);
            this.gbxListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListaProductos.Location = new System.Drawing.Point(5, 47);
            this.gbxListaProductos.Name = "gbxListaProductos";
            this.gbxListaProductos.Size = new System.Drawing.Size(1047, 391);
            this.gbxListaProductos.TabIndex = 1;
            this.gbxListaProductos.TabStop = false;
            this.gbxListaProductos.Text = "Lista de Productos ";
            // 
            // FrmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.gbxListaProductos);
            this.Name = "FrmBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.gbxListaProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.GroupBox gbxListaProductos;
    }
}