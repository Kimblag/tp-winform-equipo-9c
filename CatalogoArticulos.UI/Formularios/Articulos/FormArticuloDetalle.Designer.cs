namespace CatalogoArticulos.UI.Formularios.Articulos
{
    partial class FormArticuloDetalle
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
            this.lblAgregarArticulo = new System.Windows.Forms.Label();
            this.btnCancelarArticulo = new System.Windows.Forms.Button();
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.gbDetallesArticulo = new System.Windows.Forms.GroupBox();
            this.lblMarcaArticulo = new System.Windows.Forms.Label();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.cmbMarcaArticulo = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaArticulo = new System.Windows.Forms.ComboBox();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbDetallesArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAgregarArticulo
            // 
            this.lblAgregarArticulo.AutoSize = true;
            this.lblAgregarArticulo.BackColor = System.Drawing.Color.Beige;
            this.lblAgregarArticulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarArticulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAgregarArticulo.Location = new System.Drawing.Point(187, 9);
            this.lblAgregarArticulo.Name = "lblAgregarArticulo";
            this.lblAgregarArticulo.Size = new System.Drawing.Size(159, 25);
            this.lblAgregarArticulo.TabIndex = 0;
            this.lblAgregarArticulo.Text = "Agregar articulo";
            // 
            // btnCancelarArticulo
            // 
            this.btnCancelarArticulo.Location = new System.Drawing.Point(425, 393);
            this.btnCancelarArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelarArticulo.Name = "btnCancelarArticulo";
            this.btnCancelarArticulo.Size = new System.Drawing.Size(100, 30);
            this.btnCancelarArticulo.TabIndex = 2;
            this.btnCancelarArticulo.Text = "Cancelar";
            this.btnCancelarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Location = new System.Drawing.Point(315, 393);
            this.btnGuardarArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarArticulo.TabIndex = 3;
            this.btnGuardarArticulo.Text = "Guardar";
            this.btnGuardarArticulo.UseVisualStyleBackColor = true;
            // 
            // gbDetallesArticulo
            // 
            this.gbDetallesArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetallesArticulo.Controls.Add(this.textBox1);
            this.gbDetallesArticulo.Controls.Add(this.lblPrecioArticulo);
            this.gbDetallesArticulo.Controls.Add(this.lblCategoriaArticulo);
            this.gbDetallesArticulo.Controls.Add(this.cmbCategoriaArticulo);
            this.gbDetallesArticulo.Controls.Add(this.cmbMarcaArticulo);
            this.gbDetallesArticulo.Controls.Add(this.lblMarcaArticulo);
            this.gbDetallesArticulo.Controls.Add(this.txtDescripcionArticulo);
            this.gbDetallesArticulo.Controls.Add(this.lblDescripcionArticulo);
            this.gbDetallesArticulo.Controls.Add(this.txtNombreArticulo);
            this.gbDetallesArticulo.Controls.Add(this.lblNombreArticulo);
            this.gbDetallesArticulo.Controls.Add(this.txtCodigoArticulo);
            this.gbDetallesArticulo.Controls.Add(this.lblCodigoArticulo);
            this.gbDetallesArticulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetallesArticulo.Location = new System.Drawing.Point(15, 52);
            this.gbDetallesArticulo.Name = "gbDetallesArticulo";
            this.gbDetallesArticulo.Size = new System.Drawing.Size(500, 333);
            this.gbDetallesArticulo.TabIndex = 4;
            this.gbDetallesArticulo.TabStop = false;
            this.gbDetallesArticulo.Text = "Detalles del Articulo";
            // 
            // lblMarcaArticulo
            // 
            this.lblMarcaArticulo.AutoSize = true;
            this.lblMarcaArticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMarcaArticulo.Location = new System.Drawing.Point(20, 205);
            this.lblMarcaArticulo.Name = "lblMarcaArticulo";
            this.lblMarcaArticulo.Size = new System.Drawing.Size(45, 17);
            this.lblMarcaArticulo.TabIndex = 6;
            this.lblMarcaArticulo.Text = "Marca";
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(23, 141);
            this.txtDescripcionArticulo.Multiline = true;
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(450, 53);
            this.txtDescripcionArticulo.TabIndex = 5;
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(20, 106);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(76, 17);
            this.lblDescripcionArticulo.TabIndex = 4;
            this.lblDescripcionArticulo.Text = "Descripcion";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreArticulo.Location = new System.Drawing.Point(264, 62);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(209, 29);
            this.txtNombreArticulo.TabIndex = 3;
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNombreArticulo.Location = new System.Drawing.Point(261, 37);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(57, 17);
            this.lblNombreArticulo.TabIndex = 2;
            this.lblNombreArticulo.Text = "Nombre";
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoArticulo.Location = new System.Drawing.Point(23, 62);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(209, 29);
            this.txtCodigoArticulo.TabIndex = 1;
            this.txtCodigoArticulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCodigoArticulo.Location = new System.Drawing.Point(20, 37);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(51, 17);
            this.lblCodigoArticulo.TabIndex = 0;
            this.lblCodigoArticulo.Text = "Código";
            // 
            // cmbMarcaArticulo
            // 
            this.cmbMarcaArticulo.FormattingEnabled = true;
            this.cmbMarcaArticulo.Location = new System.Drawing.Point(23, 225);
            this.cmbMarcaArticulo.Name = "cmbMarcaArticulo";
            this.cmbMarcaArticulo.Size = new System.Drawing.Size(145, 29);
            this.cmbMarcaArticulo.TabIndex = 7;
            // 
            // cmbCategoriaArticulo
            // 
            this.cmbCategoriaArticulo.FormattingEnabled = true;
            this.cmbCategoriaArticulo.Location = new System.Drawing.Point(328, 225);
            this.cmbCategoriaArticulo.Name = "cmbCategoriaArticulo";
            this.cmbCategoriaArticulo.Size = new System.Drawing.Size(145, 29);
            this.cmbCategoriaArticulo.TabIndex = 8;
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(325, 205);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(65, 17);
            this.lblCategoriaArticulo.TabIndex = 9;
            this.lblCategoriaArticulo.Text = "Categoría";
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPrecioArticulo.Location = new System.Drawing.Point(20, 257);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(44, 17);
            this.lblPrecioArticulo.TabIndex = 10;
            this.lblPrecioArticulo.Text = "Precio";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(23, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 29);
            this.textBox1.TabIndex = 11;
            // 
            // FormArticuloDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 437);
            this.Controls.Add(this.gbDetallesArticulo);
            this.Controls.Add(this.btnGuardarArticulo);
            this.Controls.Add(this.btnCancelarArticulo);
            this.Controls.Add(this.lblAgregarArticulo);
            this.Name = "FormArticuloDetalle";
            this.Text = "FormArticuloDetalle";
            this.gbDetallesArticulo.ResumeLayout(false);
            this.gbDetallesArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarArticulo;
        private System.Windows.Forms.Button btnCancelarArticulo;
        private System.Windows.Forms.Button btnGuardarArticulo;
        private System.Windows.Forms.GroupBox gbDetallesArticulo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.TextBox txtDescripcionArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Label lblMarcaArticulo;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.ComboBox cmbCategoriaArticulo;
        private System.Windows.Forms.ComboBox cmbMarcaArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.TextBox textBox1;
    }
}