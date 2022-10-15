
namespace Farmacia
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.gpbInfoPto = new System.Windows.Forms.GroupBox();
            this.cmbEstante = new System.Windows.Forms.ComboBox();
            this.cmbPresentacion = new System.Windows.Forms.ComboBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.txtCtracion = new System.Windows.Forms.TextBox();
            this.lblConcentracion = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblNomPto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEstante = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblFechaInv = new System.Windows.Forms.Label();
            this.gpbStock = new System.Windows.Forms.GroupBox();
            this.txtVenc = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtpFechaInvetario = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarInventario = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbInfoPto.SuspendLayout();
            this.gpbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInfoPto
            // 
            this.gpbInfoPto.BackColor = System.Drawing.Color.White;
            this.gpbInfoPto.Controls.Add(this.cmbEstante);
            this.gpbInfoPto.Controls.Add(this.cmbPresentacion);
            this.gpbInfoPto.Controls.Add(this.lblPresentacion);
            this.gpbInfoPto.Controls.Add(this.txtCtracion);
            this.gpbInfoPto.Controls.Add(this.lblConcentracion);
            this.gpbInfoPto.Controls.Add(this.txtProducto);
            this.gpbInfoPto.Controls.Add(this.lblNomPto);
            this.gpbInfoPto.Controls.Add(this.txtCodigo);
            this.gpbInfoPto.Controls.Add(this.lblCodigo);
            this.gpbInfoPto.Controls.Add(this.lblEstante);
            this.gpbInfoPto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbInfoPto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoPto.ForeColor = System.Drawing.Color.Black;
            this.gpbInfoPto.Location = new System.Drawing.Point(39, 79);
            this.gpbInfoPto.Name = "gpbInfoPto";
            this.gpbInfoPto.Size = new System.Drawing.Size(490, 232);
            this.gpbInfoPto.TabIndex = 1;
            this.gpbInfoPto.TabStop = false;
            this.gpbInfoPto.Text = "Información del producto";
            // 
            // cmbEstante
            // 
            this.cmbEstante.FormattingEnabled = true;
            this.cmbEstante.Location = new System.Drawing.Point(205, 41);
            this.cmbEstante.Name = "cmbEstante";
            this.cmbEstante.Size = new System.Drawing.Size(249, 24);
            this.cmbEstante.TabIndex = 10;
            this.cmbEstante.SelectedIndexChanged += new System.EventHandler(this.CmbEstante_SelectedIndexChanged);
            // 
            // cmbPresentacion
            // 
            this.cmbPresentacion.FormattingEnabled = true;
            this.cmbPresentacion.Location = new System.Drawing.Point(205, 188);
            this.cmbPresentacion.Name = "cmbPresentacion";
            this.cmbPresentacion.Size = new System.Drawing.Size(249, 24);
            this.cmbPresentacion.TabIndex = 9;
            this.cmbPresentacion.SelectedIndexChanged += new System.EventHandler(this.CmbPresentacion_SelectedIndexChanged);
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.BackColor = System.Drawing.Color.White;
            this.lblPresentacion.Location = new System.Drawing.Point(24, 194);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(86, 16);
            this.lblPresentacion.TabIndex = 4;
            this.lblPresentacion.Text = "Presentación";
            // 
            // txtCtracion
            // 
            this.txtCtracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCtracion.Location = new System.Drawing.Point(205, 154);
            this.txtCtracion.Name = "txtCtracion";
            this.txtCtracion.Size = new System.Drawing.Size(249, 22);
            this.txtCtracion.TabIndex = 8;
            // 
            // lblConcentracion
            // 
            this.lblConcentracion.AutoSize = true;
            this.lblConcentracion.BackColor = System.Drawing.Color.White;
            this.lblConcentracion.Location = new System.Drawing.Point(24, 160);
            this.lblConcentracion.Name = "lblConcentracion";
            this.lblConcentracion.Size = new System.Drawing.Size(93, 16);
            this.lblConcentracion.TabIndex = 3;
            this.lblConcentracion.Text = "Concentración";
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Location = new System.Drawing.Point(205, 120);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(249, 22);
            this.txtProducto.TabIndex = 7;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // lblNomPto
            // 
            this.lblNomPto.AutoSize = true;
            this.lblNomPto.BackColor = System.Drawing.Color.White;
            this.lblNomPto.Location = new System.Drawing.Point(24, 120);
            this.lblNomPto.Name = "lblNomPto";
            this.lblNomPto.Size = new System.Drawing.Size(134, 16);
            this.lblNomPto.TabIndex = 2;
            this.lblNomPto.Text = "Nombre del producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(205, 81);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(249, 22);
            this.txtCodigo.TabIndex = 6;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(24, 81);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(129, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código del producto";
            // 
            // lblEstante
            // 
            this.lblEstante.AutoSize = true;
            this.lblEstante.BackColor = System.Drawing.Color.White;
            this.lblEstante.Location = new System.Drawing.Point(24, 41);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(121, 16);
            this.lblEstante.TabIndex = 0;
            this.lblEstante.Text = "Número de estante";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblInventario.Location = new System.Drawing.Point(81, 28);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInventario.Size = new System.Drawing.Size(435, 32);
            this.lblInventario.TabIndex = 3;
            this.lblInventario.Text = "INVENTARIO FARMACIA GALERAS";
            // 
            // lblFechaInv
            // 
            this.lblFechaInv.AutoSize = true;
            this.lblFechaInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInv.Location = new System.Drawing.Point(599, 44);
            this.lblFechaInv.Name = "lblFechaInv";
            this.lblFechaInv.Size = new System.Drawing.Size(51, 16);
            this.lblFechaInv.TabIndex = 4;
            this.lblFechaInv.Text = "Fecha: ";
            // 
            // gpbStock
            // 
            this.gpbStock.BackColor = System.Drawing.Color.White;
            this.gpbStock.Controls.Add(this.txtVenc);
            this.gpbStock.Controls.Add(this.txtCant);
            this.gpbStock.Controls.Add(this.lblVencimiento);
            this.gpbStock.Controls.Add(this.lblCant);
            this.gpbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStock.Location = new System.Drawing.Point(39, 317);
            this.gpbStock.Name = "gpbStock";
            this.gpbStock.Size = new System.Drawing.Size(490, 100);
            this.gpbStock.TabIndex = 6;
            this.gpbStock.TabStop = false;
            this.gpbStock.Text = "Stock";
            // 
            // txtVenc
            // 
            this.txtVenc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVenc.Location = new System.Drawing.Point(205, 66);
            this.txtVenc.Name = "txtVenc";
            this.txtVenc.Size = new System.Drawing.Size(249, 22);
            this.txtVenc.TabIndex = 7;
            // 
            // txtCant
            // 
            this.txtCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCant.Location = new System.Drawing.Point(205, 29);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(249, 22);
            this.txtCant.TabIndex = 6;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(6, 70);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(139, 16);
            this.lblVencimiento.TabIndex = 1;
            this.lblVencimiento.Text = "Fecha de vencimiento";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(6, 35);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(127, 16);
            this.lblCant.TabIndex = 0;
            this.lblCant.Text = "Cantidad disponible";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(583, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // dtpFechaInvetario
            // 
            this.dtpFechaInvetario.CustomFormat = "dd - mm - yyyy";
            this.dtpFechaInvetario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInvetario.Location = new System.Drawing.Point(656, 44);
            this.dtpFechaInvetario.Name = "dtpFechaInvetario";
            this.dtpFechaInvetario.Size = new System.Drawing.Size(92, 20);
            this.dtpFechaInvetario.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // btnCerrarInventario
            // 
            this.btnCerrarInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarInventario.Location = new System.Drawing.Point(656, 380);
            this.btnCerrarInventario.Name = "btnCerrarInventario";
            this.btnCerrarInventario.Size = new System.Drawing.Size(75, 37);
            this.btnCerrarInventario.TabIndex = 13;
            this.btnCerrarInventario.Text = "Cerrar";
            this.btnCerrarInventario.UseVisualStyleBackColor = false;
            this.btnCerrarInventario.Click += new System.EventHandler(this.btnCerrarInventario_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(568, 380);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 37);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.Location = new System.Drawing.Point(656, 294);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 34);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrarInventario);
            this.Controls.Add(this.dtpFechaInvetario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gpbStock);
            this.Controls.Add(this.lblFechaInv);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.gpbInfoPto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.gpbInfoPto.ResumeLayout(false);
            this.gpbInfoPto.PerformLayout();
            this.gpbStock.ResumeLayout(false);
            this.gpbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gpbStock;
        private System.Windows.Forms.GroupBox gpbInfoPto;
        private System.Windows.Forms.TextBox txtCtracion;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtVenc;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblConcentracion;
        private System.Windows.Forms.Label lblNomPto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEstante;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblFechaInv;   
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.DateTimePicker dtpFechaInvetario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbPresentacion;
        private System.Windows.Forms.Button btnCerrarInventario;
        private System.Windows.Forms.ComboBox cmbEstante;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
    }
}