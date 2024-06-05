using CadLicoreria;
using ClnLicoreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpLicoreria
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }


        private void FrmVenta_Load(object sender, EventArgs e)
        {
            List<Producto> productos = ProductoCln.listar();

            if (productos.Count > 0)
            {
                cbxProducto.DataSource = productos;
                cbxProducto.DisplayMember = "Nombre";
                cbxProducto.SelectedIndex = -1;

                tbxIdProducto.Enabled = false;
                txtPrecio.Enabled = false;
                txtCodigo.Enabled = false;
            }
        }

        decimal sumaTotal = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                int id = Convert.ToInt32(tbxIdProducto.Text.Trim());
                string producto = cbxProducto.Text.Trim();
                decimal precio = Convert.ToDecimal(txtPrecio.Text.Trim());
                int cantidad = (int)nudCantidadP.Value;
                decimal subtotal = precio * cantidad;

                dvgListaVenta.Rows.Add(id, producto, precio, cantidad, subtotal);
                sumaTotal += subtotal;

                txtTotal.Text = sumaTotal.ToString();


                limpiar();
            }
        }

        private bool validar()
        {
            bool esValido = true;
            erpCi.SetError(txtCi, "");
            erpRazonSocial.SetError(txtrazonSocial, "");
            erpCelular.SetError(txtCelular, "");
            erpProducto.SetError(cbxProducto, "");
            if (string.IsNullOrEmpty(txtCi.Text))
            {
                esValido = false;
                erpCi.SetError(txtCi, "El campo Carnet de Identidad es obligatorio");

            }
            if (string.IsNullOrEmpty(txtrazonSocial.Text))
            {
                esValido = false;
                erpCi.SetError(txtCi, "El campo Razon Social es obligatorio");

            }
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                esValido = false;
                erpCi.SetError(cbxProducto, "El campo celular es obligatorio");

            }
            if (string.IsNullOrEmpty(cbxProducto.Text))
            {
                esValido = false;
                erpCi.SetError(cbxProducto, "Debe seleccionar un producto");

            }
            return esValido;
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (dvgListaVenta.Rows.Count == 0)
            {
                MessageBox.Show("Debes agregar al menos un producto antes de crear la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cliente = new Cliente();
            cliente.razonSocial = txtrazonSocial.Text.Trim();
            cliente.cedulaIdentidad = txtCi.Text.Trim();
            cliente.celular = txtCelular.Text.Trim();
            cliente.usuarioRegistro = Util.usuario.usuario1;
            cliente.fechaRegistro = DateTime.Now;
            cliente.estado = 1;
            int idCliente = ClienteCln.insertar(cliente);



            var venta = new Venta();
            venta.idUsuario = Util.usuario.idUsuario;
            venta.idCliente = idCliente;
            venta.totalVenta = Convert.ToDecimal(txtTotal.Text.Trim());
            venta.fechaVenta = DateTime.Now;
            venta.usuarioRegistro = Util.usuario.usuario1;
            venta.fechaRegistro = DateTime.Now;
            venta.estado = 1;
            int idVenta = VentaCln.insertar(venta);

            foreach (DataGridViewRow row in dvgListaVenta.Rows)
            {
                var ventaDetalle = new VentaDetalle();
                ventaDetalle.idVenta = idVenta;
                ventaDetalle.idProducto = Convert.ToInt32(row.Cells["dvgIdProducto"].Value);
                ventaDetalle.cantidad = Convert.ToInt32(row.Cells["dvgCantidad"].Value);
                ventaDetalle.precioUnitario = Convert.ToDecimal(row.Cells["dvgPrecio"].Value);
                ventaDetalle.total = Convert.ToDecimal(row.Cells["dvgSubTotal"].Value);
                ventaDetalle.usuarioRegistro = Util.usuario.usuario1;
                ventaDetalle.fechaRegistro = DateTime.Now;
                ventaDetalle.estado = 1;

                VentaDetalleCln.insertar(ventaDetalle);
            }
            txtTotal.Text = string.Empty;
            dvgListaVenta.Rows.Clear();
            MessageBox.Show("Venta guardada exitosamente", "::: Cafeteria - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            cbxProducto.SelectedIndex = -1;
            txtPrecio.Text = string.Empty;
            nudCantidadP.Value = 1;
        }

        private void cbxProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxProducto.SelectedItem != null)
            {
                Producto productoSeleccionado = (Producto)cbxProducto.SelectedItem;
                tbxIdProducto.Text = productoSeleccionado.idProducto.ToString();
                txtPrecio.Text = productoSeleccionado.precio.ToString();
                txtCodigo.Text = productoSeleccionado.codigo.ToString();
            }
            else
            {
                limpiar();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.ShowDialog();
            this.Close();
        }
    }
}
