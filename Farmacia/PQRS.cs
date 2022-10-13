using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmPQRS : Form
    {
        public FrmPQRS()
        {
            InitializeComponent();
        }

        private void btnCerrarPQRS_Click(object sender, EventArgs e)
        {
            //Botón para cerrar ventana y retornar a menú principal
            this.Close();
        }

        private void FrmPQRS_Load(object sender, EventArgs e)
        {
            // Se crea lista desplegable para elección del tipo de solicitud
            cmbTipoRecurso.Items.Add("Sugerencia");
            cmbTipoRecurso.Items.Add("Queja");
            cmbTipoRecurso.Items.Add("Reclamo");
            cmbTipoRecurso.Items.Add("Petición de Consulta");
            cmbTipoRecurso.Items.Add("Petición de Documentación");
            cmbTipoRecurso.Items.Add("Petición de Información");
            cmbTipoRecurso.Items.Add("Felicitaciónes");
            cmbTipoRecurso.Items.Add("Denuncia");

            // Se crea menú desplegable para elección de Documento para PQRS           
            cmbTipoDocPQRS.Items.Add("Anonimo");
            cmbTipoDocPQRS.Items.Add("Cedula de ciudadanía");
            cmbTipoDocPQRS.Items.Add("Tarjeta de identidad");
            cmbTipoDocPQRS.Items.Add("Pasaporte");
            cmbTipoDocPQRS.Items.Add("Registro Civil");
            cmbTipoDocPQRS.Items.Add("NIT");

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if(ValidarCampos())
            {
                MessageBox.Show("Datos ingresados Correctamente");
            }
        }      
                
        // se crea el metodo de tipo booleano con el nombre Validar campos
        private bool ValidarCampos()
        {
            // Se declara variable de tipo booleano =  a true
            bool ok = true;

            // Si texbox numero Id se encuentra vacío, ok toma el valor False
            if (txtNumId.Text == "")
            {
                ok = false;
                // Error provider se posiciona en texbox pidiendo ingresar datos correctos
                errorProvider1.SetError(txtNumId, "Ingrese Número de identificación");
            }

             // Si texbox Nombres Completos se encuentra vacío, ok toma el valor False
            if (txtNombres.Text == "")
            {
                ok = false;
                // Error provider se posiciona en texbox pidiendo ingresar datos correctos
                errorProvider1.SetError(txtNombres, "Ingrese Su Nombre");
            }

            // Si texbox Nombres Completos se encuentra vacío, ok toma el valor False
            if (txtTel.Text == "")
            {
                ok = false;
                // Error provider se posiciona en texbox pidiendo ingresar datos correctos
                errorProvider1.SetError(txtTel, "Ingrese Número de telefono");
            }

            // Si texbox Nombres Completos se encuentra vacío, ok toma el valor False
            if (txtDireccion.Text == "")
            {
                ok = false;
                // Error provider se posiciona en texbox pidiendo ingresar datos correctos
                errorProvider1.SetError(txtDireccion, "Ingrese Dirección");
            }

            // Si texbox Nombres Completos se encuentra vacío, ok toma el valor False
            if (txtEmail.Text == "")
            {
                ok = false;
                // Error provider se posiciona en texbox pidiendo ingresar datos correctos
                errorProvider1.SetError(txtEmail, "Ingrese Dirección de Correo");
            }

            //Retur del valor ok
            return ok;
        }

        // Se crea evento borrar mensaje error
        // cuando se ingresen datos correctos se elimina el icono de validación 
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNumId, "");
            errorProvider1.SetError(txtNombres, "");
            errorProvider1.SetError(txtTel, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtEmail, "");
        }

        // Validación de datos númericos en TexNumId
        private void txtNumId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int num;
            if(!int.TryParse(txtNumId.Text, out num))
            {
                errorProvider1.SetError(txtNumId, "Ingrese Valor Númerico");
            }
            else
            {
                errorProvider1.SetError(txtNumId, "");
            }
        }

        private void txtTel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtTel.Text, out num))
            {
                errorProvider1.SetError(txtTel, "Ingrese Valor Númerico");
            }
            else
            {
                errorProvider1.SetError(txtTel, "");
            }
        }

        private void txtNumId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validación de datos, mensaje de alerta de solo números.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validación de datos, mensaje de alerta de solo números
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
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
            cmbTipoRecurso.Focus();                      
            txtNumId.Clear();
            txtNumId.Clear();
            txtNombres.Clear();
            txtTel.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
        }
    }
}
