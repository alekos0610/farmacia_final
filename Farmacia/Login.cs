using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class login : Form
    {
        // Se declaran dos variables globales para la Validación
        // Esto a futuro será reemplazado por la validación desde la base de datos
        string Usuario = "as";
        string Contraseña = "as";

        public login()
        {
            InitializeComponent();
        }              

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            // Imagen ocultar la mandamos al frente
            pbOcultar.BringToFront();

            //Se muestra la contraseña
            txtContraseña.PasswordChar = '*';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            // Se manda al frente imagen mostrar la contraseña
            pbMostrar.BringToFront();
            // Se oculta la contraseña
            txtContraseña.PasswordChar = '\0';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Si el usuario es diferente a datos de validación
            // si la contraseña es diferente a datos declarados en la validación
            if (txtUsuario.Text != Usuario || txtContraseña.Text != Contraseña)
            {
                if (txtUsuario.Text != Usuario)
                {
                    //Mostrar mensaje emergente de Usuario incorrecto
                    MessageBox.Show("Usuario Incorrecto");
                    //Limpiar Linea de texto Usuario
                    txtUsuario.Clear();
                    //Poner el cursor en la caja de texto
                    txtUsuario.Focus();
                    //Acción return para que no continúe ejecutandose el codigo siguiente
                    return;
                }

                //Se verifica la caja de texto contraseña
                if (txtContraseña.Text != Contraseña)
                {
                    //Mostrar mensaje emergente de Contraseña Incorrecta
                    MessageBox.Show("Contraseña incorrecta");
                    //limpiar caja de texto Contraseña
                    txtContraseña.Clear();
                    //Poner el cursor en la caja de texto contraseña
                    txtContraseña.Focus();
                    //Acción return para que no continúe ejecutandose el codigo siguiente
                    return;
                }
            }
            else
            {
                //Limpiar los formularios
                txtUsuario.Clear();
                txtContraseña.Clear();

                // Si se cumplen las condiciones anteriores, saltar al siguiente formulario = principal
                FrmPrincipal Form = new FrmPrincipal();
                // ShowDialog para solo poder interactuar con el formulario nuevo y no saltar de uno a otro.
                Form.ShowDialog();
            }
        }              

        private void lnkrecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Si se da click se salta al formulario de recuperación de usuario
            FrmRecuperación Form = new FrmRecuperación();
            // ShowDialog para solo poder interactuar con el formulario nuevo y no saltar de uno a otro.
            Form.ShowDialog();
        }

        private void pibLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
