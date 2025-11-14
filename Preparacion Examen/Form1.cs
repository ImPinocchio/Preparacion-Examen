using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Preparacion_Examen.Models;

namespace Preparacion_Examen
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }
        private void LimpiarPantalla()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtMail.Clear();
            txtCelular.Clear();
            txtDocumento.Clear();
            labelEstado.Text = "";
            rbSexoM.Checked = false;
            rbSexoF.Checked = false;
            cmbTipoDocumento.SelectedIndex = -1;
            txtDocumento.ReadOnly = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                crearCliente();
            }
        }

        private void crearCliente()
        {
            using var db = new BdExamenContext();

            var numero = txtDocumento.Text.Trim();
            if (db.Clientes.Any(x => x.NumeroDocumento == numero))
            {
                MessageBox.Show("Ya existe un cliente con ese número de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var cli = ConstruirClienteDesdeFormulario();
            cli.FechaCreaccion = DateTime.Now;
            db.Clientes.Add(cli);
            db.SaveChanges();

            PintarEstado(cli.Estado);
            MessageBox.Show("Cliente creado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDocumento.ReadOnly = true;
        }

        private bool validaciones()
        {
            if (cmbTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento", "Error");
                cmbTipoDocumento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                MessageBox.Show("Debe ingresar un número de documento", "Error");
                txtDocumento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Error");
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar un apellido", "Error");
                txtApellido.Focus();
                return false;
            }
            if (!rbSexoF.Checked && !rbSexoM.Checked)
            {
                MessageBox.Show("Debe seleccionar un sexo", "Error");
                rbSexoF.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Debe ingresar un mail", "Error");
                txtMail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                MessageBox.Show("Debe ingresar un celular", "Error");
                txtCelular.Focus();
                return false;
            }

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                actualizarCliente();
            }
        }

        private void actualizarCliente()
        {
            using var db = new BdExamenContext();

            var numero = txtDocumento.Text.Trim();
            var cli = db.Clientes.Find(numero);

            if (cli == null)
            {
                MessageBox.Show("No se encontró el cliente a actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cli.TipoDocumento = (cmbTipoDocumento.SelectedItem?.ToString() ?? "").Trim().Substring(0, 1);
            cli.Nombres = txtNombre.Text.Trim();
            cli.Apellidos = txtApellido.Text.Trim();
            cli.Sexo = SexoSeleccionado();
            cli.Celular = txtCelular.Text.Trim();
            cli.Mail = txtMail.Text.Trim();
            cli.FechaModificacion = DateTime.Now;

            db.SaveChanges();

            PintarEstado(cli.Estado);
            MessageBox.Show("Cliente actualizado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea inactivar el cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                inactivarCliente();
            }
        }

        private void inactivarCliente()
        {
            using var db = new BdExamenContext();

            var numero = txtDocumento.Text.Trim();
            var cli = db.Clientes.Find(numero);

            if (cli == null)
            {
                MessageBox.Show("No se encontró el cliente.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cli.Estado == "I")
            {
                MessageBox.Show("El cliente ya está inactivo.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cli.Estado = "I";
            cli.FechaModificacion = DateTime.Now;
            db.SaveChanges();

            PintarEstado(cli.Estado);
            MessageBox.Show("Cliente inactivado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Helpers adaptados al formulario actual
        private string SexoSeleccionado()
        {
            if (rbSexoM.Checked)
            {
                return "M";
            }
            else if (rbSexoF.Checked)
            {
                return "F";
            }
            else
            {
                return null;
            }
        }

        private void PintarEstado(string estado)
        {
            if (estado == "A")
            {
                labelEstado.Text = "Activo";
                labelEstado.ForeColor = Color.Green;
                labelEstado.Font = new Font(labelEstado.Font, FontStyle.Bold);
            }
            else if (estado == "I")
            {
                labelEstado.Text = "Inactivo";
                labelEstado.ForeColor = Color.Red;
                labelEstado.Font = new Font(labelEstado.Font, FontStyle.Bold);
            }
            else
            {
                labelEstado.Text = "";
                labelEstado.ForeColor = SystemColors.ControlText;
                labelEstado.Font = new Font(labelEstado.Font, FontStyle.Regular);
            }
        }

        private void LlenarFormulario(Cliente c)
        {
            if (c.TipoDocumento == "C")
            {
                cmbTipoDocumento.SelectedItem = "CEDULA";
            }
            else
            {
                cmbTipoDocumento.SelectedItem = "RUC";
            }
            txtDocumento.Text = c.NumeroDocumento;
            txtNombre.Text = c.Nombres;
            txtApellido.Text = c.Apellidos;
            rbSexoM.Checked = c.Sexo == "M";
            rbSexoF.Checked = c.Sexo == "F";
            txtCelular.Text = c.Celular;
            txtMail.Text = c.Mail;
            PintarEstado(c.Estado);
            txtDocumento.ReadOnly = true;
        }

        private Cliente ConstruirClienteDesdeFormulario()
        {
            return new Cliente
            {
                NumeroDocumento = txtDocumento.Text.Trim(),
                TipoDocumento = (cmbTipoDocumento.SelectedItem?.ToString() ?? "").Trim().Substring(0, 1),
                Nombres = txtNombre.Text.Trim(),
                Apellidos = txtApellido.Text.Trim(),
                Sexo = SexoSeleccionado(),
                Celular = txtCelular.Text.Trim(),
                Mail = txtMail.Text.Trim(),
                Estado = "A"
            };
        }

        // Opcional: método para consultar cliente por documento (si tienes botón asociado)
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var numero = txtDocumento.Text.Trim();
            if (string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Ingrese el número de documento para consultar.");
                return;
            }

            using var db = new BdExamenContext();
            var cli = db.Clientes.Find(numero);

            if (cli == null)
            {
                MessageBox.Show("No se encontró el cliente. Puede crearlo.");
                txtDocumento.ReadOnly = false;
                labelEstado.Text = "";
                return;
            }

            LlenarFormulario(cli);
        }
    }
}
