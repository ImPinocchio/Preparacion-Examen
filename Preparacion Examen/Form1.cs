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
            throw new NotImplementedException();
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
            
        }
    }
}
