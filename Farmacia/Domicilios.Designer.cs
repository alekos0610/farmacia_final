
namespace Farmacia
{
    partial class FrmDomicilios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDomicilios));
            this.lblInventario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbInfoPedido = new System.Windows.Forms.GroupBox();
            this.cmbPresentacion = new System.Windows.Forms.ComboBox();
            this.cmbDomiciliario = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtValorT = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtValorUnd = new System.Windows.Forms.TextBox();
            this.lblVUnd = new System.Windows.Forms.Label();
            this.lblNomDomiciliario = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtConcentracion = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblConcentracion = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.gpbInfousuario = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cmbTipoID = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtNumId = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNumId = new System.Windows.Forms.Label();
            this.lblTipoId = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbInfoPedido.SuspendLayout();
            this.gpbInfousuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.BackColor = System.Drawing.Color.White;
            this.lblInventario.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblInventario.Location = new System.Drawing.Point(196, 32);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInventario.Size = new System.Drawing.Size(427, 32);
            this.lblInventario.TabIndex = 4;
            this.lblInventario.Text = "DOMICILIOS FARMACIA GALERAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gpbInfoPedido
            // 
            this.gpbInfoPedido.Controls.Add(this.cmbPresentacion);
            this.gpbInfoPedido.Controls.Add(this.cmbDomiciliario);
            this.gpbInfoPedido.Controls.Add(this.lblTotal);
            this.gpbInfoPedido.Controls.Add(this.txtValorT);
            this.gpbInfoPedido.Controls.Add(this.txtCantidad);
            this.gpbInfoPedido.Controls.Add(this.lblCantidad);
            this.gpbInfoPedido.Controls.Add(this.txtValorUnd);
            this.gpbInfoPedido.Controls.Add(this.lblVUnd);
            this.gpbInfoPedido.Controls.Add(this.lblNomDomiciliario);
            this.gpbInfoPedido.Controls.Add(this.txtCodigo);
            this.gpbInfoPedido.Controls.Add(this.lblCodigo);
            this.gpbInfoPedido.Controls.Add(this.txtConcentracion);
            this.gpbInfoPedido.Controls.Add(this.txtProducto);
            this.gpbInfoPedido.Controls.Add(this.lblPresentacion);
            this.gpbInfoPedido.Controls.Add(this.lblConcentracion);
            this.gpbInfoPedido.Controls.Add(this.lblProducto);
            this.gpbInfoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoPedido.Location = new System.Drawing.Point(90, 67);
            this.gpbInfoPedido.Name = "gpbInfoPedido";
            this.gpbInfoPedido.Size = new System.Drawing.Size(667, 172);
            this.gpbInfoPedido.TabIndex = 6;
            this.gpbInfoPedido.TabStop = false;
            this.gpbInfoPedido.Text = "Información del pedido";
            // 
            // cmbPresentacion
            // 
            this.cmbPresentacion.FormattingEnabled = true;
            this.cmbPresentacion.Location = new System.Drawing.Point(165, 68);
            this.cmbPresentacion.Name = "cmbPresentacion";
            this.cmbPresentacion.Size = new System.Drawing.Size(162, 24);
            this.cmbPresentacion.TabIndex = 29;
            // 
            // cmbDomiciliario
            // 
            this.cmbDomiciliario.FormattingEnabled = true;
            this.cmbDomiciliario.Location = new System.Drawing.Point(165, 136);
            this.cmbDomiciliario.Name = "cmbDomiciliario";
            this.cmbDomiciliario.Size = new System.Drawing.Size(162, 24);
            this.cmbDomiciliario.TabIndex = 28;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(385, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 16);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Valor total";
            // 
            // txtValorT
            // 
            this.txtValorT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorT.Location = new System.Drawing.Point(484, 130);
            this.txtValorT.Name = "txtValorT";
            this.txtValorT.Size = new System.Drawing.Size(139, 22);
            this.txtValorT.TabIndex = 12;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(484, 68);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(139, 22);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantidad_Validating);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(385, 70);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 16);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtValorUnd
            // 
            this.txtValorUnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorUnd.Location = new System.Drawing.Point(484, 100);
            this.txtValorUnd.Name = "txtValorUnd";
            this.txtValorUnd.Size = new System.Drawing.Size(139, 22);
            this.txtValorUnd.TabIndex = 9;
            // 
            // lblVUnd
            // 
            this.lblVUnd.AutoSize = true;
            this.lblVUnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVUnd.Location = new System.Drawing.Point(385, 100);
            this.lblVUnd.Name = "lblVUnd";
            this.lblVUnd.Size = new System.Drawing.Size(85, 16);
            this.lblVUnd.TabIndex = 8;
            this.lblVUnd.Text = "Valor unitario";
            // 
            // lblNomDomiciliario
            // 
            this.lblNomDomiciliario.AutoSize = true;
            this.lblNomDomiciliario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDomiciliario.Location = new System.Drawing.Point(6, 136);
            this.lblNomDomiciliario.Name = "lblNomDomiciliario";
            this.lblNomDomiciliario.Size = new System.Drawing.Size(153, 16);
            this.lblNomDomiciliario.TabIndex = 21;
            this.lblNomDomiciliario.Text = "Domiciliario que entrega";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(165, 102);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(162, 22);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 102);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(129, 16);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código del producto";
            // 
            // txtConcentracion
            // 
            this.txtConcentracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConcentracion.Location = new System.Drawing.Point(484, 40);
            this.txtConcentracion.Name = "txtConcentracion";
            this.txtConcentracion.Size = new System.Drawing.Size(139, 22);
            this.txtConcentracion.TabIndex = 4;
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Location = new System.Drawing.Point(165, 40);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(162, 22);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(6, 68);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(86, 16);
            this.lblPresentacion.TabIndex = 2;
            this.lblPresentacion.Text = "Presentación";
            // 
            // lblConcentracion
            // 
            this.lblConcentracion.AutoSize = true;
            this.lblConcentracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcentracion.Location = new System.Drawing.Point(385, 42);
            this.lblConcentracion.Name = "lblConcentracion";
            this.lblConcentracion.Size = new System.Drawing.Size(93, 16);
            this.lblConcentracion.TabIndex = 1;
            this.lblConcentracion.Text = "Concentración";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(6, 42);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(134, 16);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Nombre del producto";
            // 
            // gpbInfousuario
            // 
            this.gpbInfousuario.Controls.Add(this.btnLimpiar);
            this.gpbInfousuario.Controls.Add(this.btnEnviar);
            this.gpbInfousuario.Controls.Add(this.cmbTipoID);
            this.gpbInfousuario.Controls.Add(this.btnCerrar);
            this.gpbInfousuario.Controls.Add(this.txtTel);
            this.gpbInfousuario.Controls.Add(this.txtDireccion);
            this.gpbInfousuario.Controls.Add(this.txtBarrio);
            this.gpbInfousuario.Controls.Add(this.txtNomUsuario);
            this.gpbInfousuario.Controls.Add(this.txtNumId);
            this.gpbInfousuario.Controls.Add(this.lblTel);
            this.gpbInfousuario.Controls.Add(this.lblBarrio);
            this.gpbInfousuario.Controls.Add(this.lblDireccion);
            this.gpbInfousuario.Controls.Add(this.lblNumId);
            this.gpbInfousuario.Controls.Add(this.lblTipoId);
            this.gpbInfousuario.Controls.Add(this.lblNomUsuario);
            this.gpbInfousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfousuario.Location = new System.Drawing.Point(90, 245);
            this.gpbInfousuario.Name = "gpbInfousuario";
            this.gpbInfousuario.Size = new System.Drawing.Size(667, 188);
            this.gpbInfousuario.TabIndex = 7;
            this.gpbInfousuario.TabStop = false;
            this.gpbInfousuario.Text = "Información del usuario";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(395, 142);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(79, 34);
            this.btnEnviar.TabIndex = 28;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cmbTipoID
            // 
            this.cmbTipoID.FormattingEnabled = true;
            this.cmbTipoID.Location = new System.Drawing.Point(170, 56);
            this.cmbTipoID.Name = "cmbTipoID";
            this.cmbTipoID.Size = new System.Drawing.Size(162, 24);
            this.cmbTipoID.TabIndex = 15;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(565, 142);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(79, 34);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Location = new System.Drawing.Point(484, 86);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(139, 22);
            this.txtTel.TabIndex = 27;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(484, 56);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(139, 22);
            this.txtDireccion.TabIndex = 26;
            // 
            // txtBarrio
            // 
            this.txtBarrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarrio.Location = new System.Drawing.Point(484, 25);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(139, 22);
            this.txtBarrio.TabIndex = 25;
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomUsuario.Location = new System.Drawing.Point(170, 27);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(162, 22);
            this.txtNomUsuario.TabIndex = 23;
            this.txtNomUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomUsuario_KeyPress);
            // 
            // txtNumId
            // 
            this.txtNumId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumId.Location = new System.Drawing.Point(170, 90);
            this.txtNumId.Name = "txtNumId";
            this.txtNumId.Size = new System.Drawing.Size(162, 22);
            this.txtNumId.TabIndex = 15;
            this.txtNumId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumId_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(385, 92);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(61, 16);
            this.lblTel.TabIndex = 20;
            this.lblTel.Text = "Télefono";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(387, 27);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(43, 16);
            this.lblBarrio.TabIndex = 19;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(388, 58);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNumId
            // 
            this.lblNumId.AutoSize = true;
            this.lblNumId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumId.Location = new System.Drawing.Point(6, 92);
            this.lblNumId.Name = "lblNumId";
            this.lblNumId.Size = new System.Drawing.Size(132, 16);
            this.lblNumId.TabIndex = 17;
            this.lblNumId.Text = "Nro  de identificación";
            // 
            // lblTipoId
            // 
            this.lblTipoId.AutoSize = true;
            this.lblTipoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoId.Location = new System.Drawing.Point(6, 63);
            this.lblTipoId.Name = "lblTipoId";
            this.lblTipoId.Size = new System.Drawing.Size(135, 16);
            this.lblTipoId.TabIndex = 16;
            this.lblTipoId.Text = "Tipo de identificación";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsuario.Location = new System.Drawing.Point(6, 29);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(115, 16);
            this.lblNomUsuario.TabIndex = 15;
            this.lblNomUsuario.Text = "Nombre completo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(480, 142);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 34);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmDomicilios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbInfoPedido);
            this.Controls.Add(this.gpbInfousuario);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmDomicilios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domicilios";
            this.Load += new System.EventHandler(this.FrmDomicilios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbInfoPedido.ResumeLayout(false);
            this.gpbInfoPedido.PerformLayout();
            this.gpbInfousuario.ResumeLayout(false);
            this.gpbInfousuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbInfoPedido;
        private System.Windows.Forms.GroupBox gpbInfousuario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtConcentracion;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblConcentracion;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtValorT;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtValorUnd;
        private System.Windows.Forms.Label lblVUnd;
        private System.Windows.Forms.Label lblNomDomiciliario;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNumId;
        private System.Windows.Forms.Label lblTipoId;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtNumId;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbTipoID;
        private System.Windows.Forms.ComboBox cmbDomiciliario;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbPresentacion;
        private System.Windows.Forms.Button btnLimpiar;
    }
}