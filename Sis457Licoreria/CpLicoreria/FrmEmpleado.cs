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
    public partial class FrmEmpleado : Form
    {
        bool esNuevo = false;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var empleados = EmpleadoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = empleados;
            dgvLista.Columns["idEmpleado"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Nombre";
            dgvLista.Columns["apellidos"].HeaderText = "Apellidos";
            dgvLista.Columns["telefono"].HeaderText = "Telefono";
            dgvLista.Columns["cargo"].HeaderText = "Cargo";
            dgvLista.Columns["salario"].HeaderText = "Salario";
            btnEditar.Enabled = empleados.Count > 0;
            btnEliminar.Enabled = empleados.Count > 0;
            if (empleados.Count > 0) dgvLista.Rows[0].Cells["nombre"].Selected = true;
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(775, 644);
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(775, 644);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["idEmpleado"].Value);
            var empleado = EmpleadoCln.get(id);
            txtNombre.Text = empleado.nombre;
            txtApellidos.Text = empleado.apellidos;
            txtTelefono.Text = empleado.telefono;
            cbxCargo.Text = empleado.cargo;
            nudSalario.Value = Convert.ToUInt32(empleado.salario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(775, 441);
            limpiar();
        }

        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cbxCargo.SelectedIndex = -1;
            nudSalario.Value = 0;
            txtUsuario.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //FrmPrincipal principal = new FrmPrincipal();
            //principal.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private bool validar()
        {
            bool esValido = true;
            erpNombre.SetError(txtNombre, "");
            erpApellidos.SetError(txtApellidos, "");
            erpTelefono.SetError(txtTelefono, "");
            erpCargo.SetError(cbxCargo, "");
            erpSalario.SetError(nudSalario, "");
            erpUsuario.SetError(txtUsuario, "");
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo Nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                esValido = false;
                erpApellidos.SetError(txtApellidos, "El campo Apellidos es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                esValido = false;
                erpTelefono.SetError(txtTelefono, "El campo Telefono de Medida es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxCargo.Text))
            {
                esValido = false;
                erpCargo.SetError(cbxCargo, "El campo Cargo es obligatorio");
            }
            if (string.IsNullOrEmpty(nudSalario.Text))
            {
                esValido = false;
                erpSalario.SetError(nudSalario, "El Salario Cargo es obligatorio");
            }
            if (chkUsuario.Checked && string.IsNullOrEmpty(txtUsuario.Text))
            {
                esValido = false;
                erpUsuario.SetError(txtUsuario, "El campo Saldo debe ser mayor o igual a 0");
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var empleado = new Empleado();
                empleado.nombre = txtNombre.Text.Trim();
                empleado.apellidos = txtApellidos.Text.Trim();
                empleado.telefono = txtTelefono.Text;
                empleado.cargo = cbxCargo.Text;
                empleado.salario = (double)nudSalario.Value;
                empleado.usuarioRegistro = Util.usuario.usuario1;

                if (esNuevo)
                {
                    empleado.fechaRegistro = DateTime.Now;
                    empleado.estado = 1;
                    int id = EmpleadoCln.insertar(empleado);

                    if (chkUsuario.Checked)
                    {
                        var usuario = new Usuario();
                        usuario.usuario1 = txtUsuario.Text.Trim();
                        usuario.clave = Util.Encrypt("CAFE123");
                        usuario.idEmpleado = id;
                        usuario.usuarioRegistro = "cafeCapital";
                        usuario.fechaRegistro = DateTime.Now;
                        usuario.estado = 1;
                        UsuarioCln.insertar(usuario);
                    }
                }
                else
                {
                    chkUsuario.Visible = false; ;
                    int index = dgvLista.CurrentCell.RowIndex;
                    empleado.idEmpleado = Convert.ToInt32(dgvLista.Rows[index].Cells["idEmpleado"].Value);
                    EmpleadoCln.actualizar(empleado);

                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("empleado guardado correctamente", "::: Minerva - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int idEmpleado = Convert.ToInt32(dgvLista.Rows[index].Cells["idEmpleado"].Value);
            string nombre = dgvLista.Rows[index].Cells["nombre"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja el empleado {nombre}?",
                "::: Cafeteria - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                EmpleadoCln.eliminar(idEmpleado, "cafeCapital");
                listar();
                MessageBox.Show("empleado dado de baja correctamente", "::: Cafeteria - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Visible = chkUsuario.Checked;
        }

        private void FrmEmpleado_Load_1(object sender, EventArgs e)
        {
            Size = new Size(775, 441);
            listar();
        }
    }
}
