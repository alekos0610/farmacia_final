using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmInventario : Form
    {
        private object txtcmbEstante;

        public FrmInventario()
        {
            InitializeComponent();
        }                              

        private void FrmInventario_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarInventario_Click(object sender, EventArgs e)
        {
            //Botón para cerrar ventana y retornar a menú principal
            this.Close();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbEstante.Focus();
            cmbEstante.DataSource = null;
            cmbEstante.Items.Clear();
            cmbPresentacion.DataSource = null;
            cmbPresentacion.Items.Clear();
            txtProducto.Clear();
            txtCodigo.Clear();
            txtCtracion.Clear();            
            txtCant.Clear();
            txtVenc.Clear();
            
        }
      
        private void CmbEstante_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstante.Items.Add("1");
            cmbEstante.Items.Add("2");
            cmbEstante.Items.Add("3");
            cmbEstante.Items.Add("4");
          
        }

        private void CmbPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPresentacion.Items.Add("Grajea");
            cmbPresentacion.Items.Add("polvo");
            cmbPresentacion.Items.Add("tableta");
            cmbPresentacion.Items.Add("Ampolla");
            cmbPresentacion.Items.Add("Jarabe");
        }
    }
}

