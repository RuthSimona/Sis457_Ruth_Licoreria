using CadLicoreria;
using ClnLicoreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CpLicoreria
{
    public partial class FrmVenta : Form
    {
        private decimal sumaTotal = 0;

        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            List<Producto> productos = ProductoCln.listar();

            if (productos.Count > 0)
            {
                txtProductoCodigo.Enabled = false;
                txtPrecioUnidad.Enabled = false;
                txtProductoNombre.Enabled = false;
                txtDescripcion.Enabled = false;
                txtStock.Enabled = false;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var frmBusqueda = new FrmBusqueda())
            {
                if (frmBusqueda.ShowDialog() == DialogResult.OK)
                {
                    Producto productoSeleccionado = frmBusqueda.ProductoSeleccionado;
                    if (productoSeleccionado != null)
                    {
                        txtProductoCodigo.Text = productoSeleccionado.codigo;
                        txtIdProducto.Text = productoSeleccionado.idProducto.ToString();
                        txtProductoNombre.Text = productoSeleccionado.nombre;
                        txtDescripcion.Text = productoSeleccionado.descripcion;
                        txtStock.Text = productoSeleccionado.stock.ToString();
                        txtPrecioUnidad.Text = productoSeleccionado.precio.ToString();
                    }
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarProducto())
            {
                string codigoProducto = txtProductoCodigo.Text.Trim();
                string nombreProducto = txtProductoNombre.Text.Trim();
                decimal precioUnidad = Convert.ToDecimal(txtPrecioUnidad.Text.Trim());
                int cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
                decimal subtotal = precioUnidad * cantidad;
                string estado = txtStock.Text.Trim() == "0" ? "No disponible" : "Disponible";

                dvgListaVenta.Rows.Add(txtIdProducto.Text, nombreProducto, precioUnidad, cantidad, subtotal);
                sumaTotal += subtotal;

                txtTotal.Text = sumaTotal.ToString();

                LimpiarProducto();
            }
        }

        private bool ValidarProducto()
        {
            bool esValido = true;
            erpProducto.SetError(txtProductoCodigo, "");
            erpProducto.SetError(txtProductoNombre, "");
            erpProducto.SetError(txtPrecioUnidad, "");
            erpProducto.SetError(txtCantidad, "");

            if (string.IsNullOrEmpty(txtProductoCodigo.Text))
            {
                esValido = false;
                erpProducto.SetError(txtProductoCodigo, "El campo Código de Producto es obligatorio");
            }

            if (string.IsNullOrEmpty(txtPrecioUnidad.Text))
            {
                esValido = false;
                erpProducto.SetError(txtPrecioUnidad, "El campo Precio Unitario es obligatorio");
            }
            else if (!decimal.TryParse(txtPrecioUnidad.Text.Trim(), out _))
            {
                esValido = false;
                erpProducto.SetError(txtPrecioUnidad, "El campo Precio Unitario debe ser un número decimal");
            }

            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                esValido = false;
                erpProducto.SetError(txtCantidad, "El campo Cantidad es obligatorio");
            }
            else if (!int.TryParse(txtCantidad.Text.Trim(), out _))
            {
                esValido = false;
                erpProducto.SetError(txtCantidad, "El campo Cantidad debe ser un número entero");
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

            var cliente = new Cliente
            {
                razonSocial = txtRazonSocial.Text.Trim(),
                cedulaIdentidad = txtCi.Text.Trim(),
                celular = txtCelular.Text.Trim(),
                usuarioRegistro = Util.usuario.usuario1,
                fechaRegistro = DateTime.Now,
                estado = 1
            };

            int idCliente = ClienteCln.insertar(cliente);
            RegistrarVenta(idCliente);
        }

        private void RegistrarVenta(int idCliente)
        {
            var venta = new Venta
            {
                idUsuario = Util.usuario.idUsuario,
                idCliente = idCliente,
                totalVenta = Convert.ToDecimal(txtTotal.Text.Trim()),
                fechaVenta = DateTime.Now,
                usuarioRegistro = Util.usuario.usuario1,
                fechaRegistro = DateTime.Now,
                estado = 1
            };

            int idVenta = VentaCln.insertar(venta);

            foreach (DataGridViewRow row in dvgListaVenta.Rows)
            {
                if (row.IsNewRow) continue; 

                var ventaDetalle = new VentaDetalle
                {
                    idVenta = idVenta,
                    idProducto = Convert.ToInt32(row.Cells[0].Value),
                    cantidad = Convert.ToInt32(row.Cells[3].Value),  
                    precioUnitario = Convert.ToDecimal(row.Cells[2].Value),
                    total = Convert.ToDecimal(row.Cells[4].Value),
                    usuarioRegistro = Util.usuario.usuario1,
                    fechaRegistro = DateTime.Now,
                    estado = 1
                };

                VentaDetalleCln.insertar(ventaDetalle);
                Producto producto = ProductoCln.get(ventaDetalle.idProducto);
                producto.stock -= ventaDetalle.cantidad;
                ProductoCln.actualizar(producto);
            }

            MessageBox.Show("Venta registrada exitosamente", "::: Licorería - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarTodo();
        }

        private void LimpiarProducto()
        {
            txtProductoCodigo.Text = string.Empty;
            txtProductoNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtPrecioUnidad.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }

        private void LimpiarTodo()
        {
            LimpiarProducto();
            txtCi.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtTotal.Text = string.Empty;
            dvgListaVenta.Rows.Clear();
            sumaTotal = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
