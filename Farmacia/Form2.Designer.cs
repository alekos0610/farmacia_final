
namespace Farmacia
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbInfoPto = new System.Windows.Forms.GroupBox();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblFechaInv = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEstante = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNomPto = new System.Windows.Forms.Label();
            this.lblConcentracion = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.gpbStock = new System.Windows.Forms.GroupBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.txbEstante = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.txbCtracion = new System.Windows.Forms.TextBox();
            this.txbPtacion = new System.Windows.Forms.TextBox();
            this.txbCant = new System.Windows.Forms.TextBox();
            this.txbVenc = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbInfoPto.SuspendLayout();
            this.gpbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // gpbInfoPto
            // 
            this.gpbInfoPto.BackColor = System.Drawing.Color.White;
            this.gpbInfoPto.Controls.Add(this.txbPtacion);
            this.gpbInfoPto.Controls.Add(this.lblPresentacion);
            this.gpbInfoPto.Controls.Add(this.txbCtracion);
            this.gpbInfoPto.Controls.Add(this.lblConcentracion);
            this.gpbInfoPto.Controls.Add(this.txbProducto);
            this.gpbInfoPto.Controls.Add(this.lblNomPto);
            this.gpbInfoPto.Controls.Add(this.txbCodigo);
            this.gpbInfoPto.Controls.Add(this.lblCodigo);
            this.gpbInfoPto.Controls.Add(this.lblEstante);
            this.gpbInfoPto.Controls.Add(this.txbEstante);
            this.gpbInfoPto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbInfoPto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoPto.ForeColor = System.Drawing.Color.Black;
            this.gpbInfoPto.Location = new System.Drawing.Point(39, 79);
            this.gpbInfoPto.Name = "gpbInfoPto";
            this.gpbInfoPto.Size = new System.Drawing.Size(474, 232);
            this.gpbInfoPto.TabIndex = 1;
            this.gpbInfoPto.TabStop = false;
            this.gpbInfoPto.Text = "Información del producto";
            this.gpbInfoPto.Enter += new System.EventHandler(this.gpbInfoPto_Enter);
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblInventario.Location = new System.Drawing.Point(81, 28);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInventario.Size = new System.Drawing.Size(436, 32);
            this.lblInventario.TabIndex = 3;
            this.lblInventario.Text = "INVENTARIO FARMACIA GALERAS";
            // 
            // lblFechaInv
            // 
            this.lblFechaInv.AutoSize = true;
            this.lblFechaInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInv.Location = new System.Drawing.Point(599, 44);
            this.lblFechaInv.Name = "lblFechaInv";
            this.lblFechaInv.Size = new System.Drawing.Size(52, 16);
            this.lblFechaInv.TabIndex = 4;
            this.lblFechaInv.Text = "Fecha: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(657, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblEstante
            // 
            this.lblEstante.AutoSize = true;
            this.lblEstante.BackColor = System.Drawing.Color.White;
            this.lblEstante.Location = new System.Drawing.Point(24, 41);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(122, 16);
            this.lblEstante.TabIndex = 0;
            this.lblEstante.Text = "Número de estante";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(24, 81);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(130, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código del producto";
            // 
            // lblNomPto
            // 
            this.lblNomPto.AutoSize = true;
            this.lblNomPto.BackColor = System.Drawing.Color.White;
            this.lblNomPto.Location = new System.Drawing.Point(24, 120);
            this.lblNomPto.Name = "lblNomPto";
            this.lblNomPto.Size = new System.Drawing.Size(135, 16);
            this.lblNomPto.TabIndex = 2;
            this.lblNomPto.Text = "Nombre del producto";
            // 
            // lblConcentracion
            // 
            this.lblConcentracion.AutoSize = true;
            this.lblConcentracion.BackColor = System.Drawing.Color.White;
            this.lblConcentracion.Location = new System.Drawing.Point(24, 160);
            this.lblConcentracion.Name = "lblConcentracion";
            this.lblConcentracion.Size = new System.Drawing.Size(94, 16);
            this.lblConcentracion.TabIndex = 3;
            this.lblConcentracion.Text = "Concentración";
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.BackColor = System.Drawing.Color.White;
            this.lblPresentacion.Location = new System.Drawing.Point(24, 194);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(87, 16);
            this.lblPresentacion.TabIndex = 4;
            this.lblPresentacion.Text = "Presentación";
            // 
            // gpbStock
            // 
            this.gpbStock.BackColor = System.Drawing.Color.White;
            this.gpbStock.Controls.Add(this.txbVenc);
            this.gpbStock.Controls.Add(this.txbCant);
            this.gpbStock.Controls.Add(this.lblVencimiento);
            this.gpbStock.Controls.Add(this.lblCant);
            this.gpbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStock.Location = new System.Drawing.Point(39, 317);
            this.gpbStock.Name = "gpbStock";
            this.gpbStock.Size = new System.Drawing.Size(474, 100);
            this.gpbStock.TabIndex = 6;
            this.gpbStock.TabStop = false;
            this.gpbStock.Text = "Stock";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(6, 35);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(128, 16);
            this.lblCant.TabIndex = 0;
            this.lblCant.Text = "Cantidad disponible";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(6, 70);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(140, 16);
            this.lblVencimiento.TabIndex = 1;
            this.lblVencimiento.Text = "Fecha de vencimiento";
            // 
            // txbEstante
            // 
            this.txbEstante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEstante.Location = new System.Drawing.Point(205, 41);
            this.txbEstante.Name = "txbEstante";
            this.txbEstante.Size = new System.Drawing.Size(249, 22);
            this.txbEstante.TabIndex = 5;
            // 
            // txbCodigo
            // 
            this.txbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodigo.Location = new System.Drawing.Point(205, 81);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(249, 22);
            this.txbCodigo.TabIndex = 6;
            // 
            // txbProducto
            // 
            this.txbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProducto.Location = new System.Drawing.Point(205, 120);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.Size = new System.Drawing.Size(249, 22);
            this.txbProducto.TabIndex = 7;
            // 
            // txbCtracion
            // 
            this.txbCtracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCtracion.Location = new System.Drawing.Point(205, 157);
            this.txbCtracion.Name = "txbCtracion";
            this.txbCtracion.Size = new System.Drawing.Size(249, 22);
            this.txbCtracion.TabIndex = 8;
            // 
            // txbPtacion
            // 
            this.txbPtacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPtacion.Location = new System.Drawing.Point(205, 191);
            this.txbPtacion.Name = "txbPtacion";
            this.txbPtacion.Size = new System.Drawing.Size(249, 22);
            this.txbPtacion.TabIndex = 9;
            // 
            // txbCant
            // 
            this.txbCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCant.Location = new System.Drawing.Point(205, 29);
            this.txbCant.Name = "txbCant";
            this.txbCant.Size = new System.Drawing.Size(249, 22);
            this.txbCant.TabIndex = 6;
            // 
            // txbVenc
            // 
            this.txbVenc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbVenc.Location = new System.Drawing.Point(205, 66);
            this.txbVenc.Name = "txbVenc";
            this.txbVenc.Size = new System.Drawing.Size(249, 22);
            this.txbVenc.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(602, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.Location = new System.Drawing.Point(682, 186);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 34);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNuevo.Location = new System.Drawing.Point(682, 110);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 36);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(682, 270);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 38);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(602, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(602, 270);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gpbStock);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFechaInv);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.gpbInfoPto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbInfoPto.ResumeLayout(false);
            this.gpbInfoPto.PerformLayout();
            this.gpbStock.ResumeLayout(false);
            this.gpbStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbInfoPto;
        private System.Windows.Forms.TextBox txbPtacion;
        private System.Windows.Forms.TextBox txbCtracion;
        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbEstante;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblConcentracion;
        private System.Windows.Forms.Label lblNomPto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEstante;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblFechaInv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gpbStock;
        private System.Windows.Forms.TextBox txbVenc;
        private System.Windows.Forms.TextBox txbCant;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}