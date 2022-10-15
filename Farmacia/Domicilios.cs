using Modelo;
using Negocio;
using Repositorio;
using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmDomicilios : Form
    {
        public FrmDomicilios()
        {
            InitializeComponent();
        }

        private void FrmDomicilios_Load(object sender, EventArgs e)
        {
            // Se crea lista desplegable para selección de presentación en inventario.
            cmbPresentacion.Items.Add("Cápsula");
            cmbPresentacion.Items.Add("Comprimido");
            cmbPresentacion.Items.Add("Grajea");
            cmbPresentacion.Items.Add("Jarabe");
            cmbPresentacion.Items.Add("Suspensión");
            cmbPresentacion.Items.Add("Polvo");

            // Se crea lista desplegable para selección de tipo de documento en identificación del usuario del menú domicilios.
            cmbTipoID.Items.Add("Tarjeta de identidad");
            cmbTipoID.Items.Add("Cedula de ciudadanía");
            cmbTipoID.Items.Add("Pasaporte");
            cmbTipoID.Items.Add("Registro Civil");
            cmbTipoID.Items.Add("NIT");

            // Se crea lista Desplegable para selección de domiciliario.
            cmbDomiciliario.Items.Add("Michel Tarazona");
            cmbDomiciliario.Items.Add("Carlos Bustamante");
            cmbDomiciliario.Items.Add("Alejandra Medina");
            cmbDomiciliario.Items.Add("Sergio Silva");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Botón con opción de cerrar la ventana y retornar a menú principal
            this.Close();
        }
                
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidarCampos())
            {
                MessageBox.Show("Datos Ingresados correctamente");
            }
        }

        private object ValidarDatos()
        {
            throw new NotImplementedException();
        }

        // Validación de Campos.
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtProducto.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtProducto, "Ingresar nombre del Producto");
            }
                        
            if (txtCodigo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCodigo, "Ingresar Codigo del Medicamento");
            }

            if (txtConcentracion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtConcentracion, "Ingresar Concentración del medicamento");
            }

            if (txtCantidad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCantidad, "Ingresar la Cantidad");
            }

            if (txtValorUnd.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtValorUnd, "Ingresar Valor Unitario");
            }

            if (txtValorT.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtValorT, "Ingresar Valor total");
            }

            return ok;
        }

        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtProducto, "");           
            errorProvider1.SetError(txtCodigo, "");
            errorProvider1.SetError(txtConcentracion, "");
            errorProvider1.SetError(txtCantidad, "");
            errorProvider1.SetError(txtValorUnd, "");
            errorProvider1.SetError(txtValorT, "");                
        }

        private void txtCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int num;
            if(!int.TryParse(txtCantidad.Text, out num))
            {
                errorProvider1.SetError(txtCantidad, "Ingrese un valor númerico");
            }
            else
            {
                errorProvider1.SetError(txtCantidad, "");
            }
        }

        private void txtCodigo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtCodigo.Text, out num))
            {
                errorProvider1.SetError(txtCodigo, "Ingrese un valor númerico");
            }
            else
            {
                errorProvider1.SetError(txtCodigo, "");
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validación de datos númericos, mensaje de alerta de solo números.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validación de datos númericos, mensaje de alerta de solo números.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validación de datos númericos, mensaje de alerta de solo números.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validación de datos, mensaje de alerta de solo Letras.
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNomUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validación de datos, mensaje de alerta de solo Letras.
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtProducto.Focus();
            txtProducto.Clear();
            txtCodigo.Clear();
            txtConcentracion.Clear();
            txtCantidad.Clear();
            txtValorUnd.Clear();
            txtValorT.Clear();
            txtNomUsuario.Clear();
            txtBarrio.Clear();
            txtDireccion.Clear();
            txtNumId.Clear();
            txtTel.Clear();
        }
                
    }
}
