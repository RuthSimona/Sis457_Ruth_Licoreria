using CadLicoreria;
using ClnLicoreria;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CpLicoreria
{
    public partial class FrmBusqueda : Form
    {
        public Producto ProductoSeleccionado { get; private set; }

        public FrmBusqueda()
        {
            InitializeComponent();
        }

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            List<Producto> productos = ProductoCln.listar();
            dgvListaProductos.DataSource = productos;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvListaProductos.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dgvListaProductos.SelectedRows[0].Cells["idProducto"].Value);
                ProductoSeleccionado = ProductoCln.get(idProducto);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
