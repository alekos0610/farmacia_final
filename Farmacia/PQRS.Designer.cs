
namespace Farmacia
{
    partial class FrmPQRS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPQRS));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpbPQR = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cmbTipoDocPQRS = new System.Windows.Forms.ComboBox();
            this.cmbTipoRecurso = new System.Windows.Forms.ComboBox();
            this.btnCerrarPQRS = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNumId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblTipId = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtSituacion = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpbPQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(511, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // gpbPQR
            // 
            this.gpbPQR.Controls.Add(this.btnLimpiar);
            this.gpbPQR.Controls.Add(this.btnEnviar);
            this.gpbPQR.Controls.Add(this.cmbTipoDocPQRS);
            this.gpbPQR.Controls.Add(this.cmbTipoRecurso);
            this.gpbPQR.Controls.Add(this.btnCerrarPQRS);
            this.gpbPQR.Controls.Add(this.lblDireccion);
            this.gpbPQR.Controls.Add(this.label2);
            this.gpbPQR.Controls.Add(this.txtDireccion);
            this.gpbPQR.Controls.Add(this.txtNumId);
            this.gpbPQR.Controls.Add(this.label1);
            this.gpbPQR.Controls.Add(this.txtNombres);
            this.gpbPQR.Controls.Add(this.lblNombres);
            this.gpbPQR.Controls.Add(this.txtEmail);
            this.gpbPQR.Controls.Add(this.txtTel);
            this.gpbPQR.Controls.Add(this.lblEmail);
            this.gpbPQR.Controls.Add(this.lblTel);
            this.gpbPQR.Controls.Add(this.lblTipId);
            this.gpbPQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPQR.Location = new System.Drawing.Point(12, 67);
            this.gpbPQR.Name = "gpbPQR";
            this.gpbPQR.Size = new System.Drawing.Size(403, 321);
            this.gpbPQR.TabIndex = 2;
            this.gpbPQR.TabStop = false;
            this.gpbPQR.Text = "Información PQR";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(228, 270);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 27);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnviar.Location = new System.Drawing.Point(142, 270);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 27);
            this.btnEnviar.TabIndex = 26;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cmbTipoDocPQRS
            // 
            this.cmbTipoDocPQRS.FormattingEnabled = true;
            this.cmbTipoDocPQRS.Items.AddRange(new object[] {
            ""});
            this.cmbTipoDocPQRS.Location = new System.Drawing.Point(186, 67);
            this.cmbTipoDocPQRS.Name = "cmbTipoDocPQRS";
            this.cmbTipoDocPQRS.Size = new System.Drawing.Size(168, 24);
            this.cmbTipoDocPQRS.TabIndex = 25;
            // 
            // cmbTipoRecurso
            // 
            this.cmbTipoRecurso.FormattingEnabled = true;
            this.cmbTipoRecurso.Items.AddRange(new object[] {
            ""});
            this.cmbTipoRecurso.Location = new System.Drawing.Point(186, 37);
            this.cmbTipoRecurso.Name = "cmbTipoRecurso";
            this.cmbTipoRecurso.Size = new System.Drawing.Size(168, 24);
            this.cmbTipoRecurso.TabIndex = 24;
            // 
            // btnCerrarPQRS
            // 
            this.btnCerrarPQRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrarPQRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPQRS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarPQRS.Location = new System.Drawing.Point(309, 270);
            this.btnCerrarPQRS.Name = "btnCerrarPQRS";
            this.btnCerrarPQRS.Size = new System.Drawing.Size(75, 27);
            this.btnCerrarPQRS.TabIndex = 22;
            this.btnCerrarPQRS.Text = "Cerrar";
            this.btnCerrarPQRS.UseVisualStyleBackColor = false;
            this.btnCerrarPQRS.Click += new System.EventHandler(this.btnCerrarPQRS_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Location = new System.Drawing.Point(116, 189);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(72, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de Solicitud";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(186, 187);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(168, 22);
            this.txtDireccion.TabIndex = 13;
            // 
            // txtNumId
            // 
            this.txtNumId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumId.Location = new System.Drawing.Point(186, 99);
            this.txtNumId.Name = "txtNumId";
            this.txtNumId.Size = new System.Drawing.Size(168, 22);
            this.txtNumId.TabIndex = 11;
            this.txtNumId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumId_KeyPress);
            this.txtNumId.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumId_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(25, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de identificación";
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.Location = new System.Drawing.Point(186, 129);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(168, 22);
            this.txtNombres.TabIndex = 9;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Location = new System.Drawing.Point(51, 131);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(129, 16);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres completos";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(186, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Location = new System.Drawing.Point(186, 159);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(168, 22);
            this.txtTel.TabIndex = 12;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            this.txtTel.Validating += new System.ComponentModel.CancelEventHandler(this.txtTel_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblEmail.Location = new System.Drawing.Point(139, 217);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTel.Location = new System.Drawing.Point(119, 161);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(61, 16);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Télefono";
            // 
            // lblTipId
            // 
            this.lblTipId.AutoSize = true;
            this.lblTipId.Location = new System.Drawing.Point(45, 67);
            this.lblTipId.Name = "lblTipId";
            this.lblTipId.Size = new System.Drawing.Size(135, 16);
            this.lblTipId.TabIndex = 1;
            this.lblTipId.Text = "Tipo de identificación";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.BackColor = System.Drawing.Color.White;
            this.lblInventario.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblInventario.Location = new System.Drawing.Point(104, -1);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInventario.Size = new System.Drawing.Size(581, 32);
            this.lblInventario.TabIndex = 5;
            this.lblInventario.Text = "SUGERENCIAS Y QUEJAS FARMACIA GALERAS";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(434, 241);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(164, 16);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción de la solicitud";
            // 
            // txtSituacion
            // 
            this.txtSituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSituacion.Location = new System.Drawing.Point(421, 260);
            this.txtSituacion.Multiline = true;
            this.txtSituacion.Name = "txtSituacion";
            this.txtSituacion.Size = new System.Drawing.Size(367, 178);
            this.txtSituacion.TabIndex = 23;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPQRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.txtSituacion);
            this.Controls.Add(this.gpbPQR);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmPQRS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PQRS";
            this.Load += new System.EventHandler(this.FrmPQRS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpbPQR.ResumeLayout(false);
            this.gpbPQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gpbPQR;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipId;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNumId;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtSituacion;
        private System.Windows.Forms.Button btnCerrarPQRS;
        private System.Windows.Forms.ComboBox cmbTipoRecurso;
        private System.Windows.Forms.ComboBox cmbTipoDocPQRS;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}