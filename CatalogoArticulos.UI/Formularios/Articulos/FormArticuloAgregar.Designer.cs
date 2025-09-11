namespace CatalogoArticulos.UI.Formularios.Articulos
{
    partial class FormArticuloAgregar
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
            this.gpArticulos = new System.Windows.Forms.GroupBox();
            this.pbxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.lblImagenArticulo = new System.Windows.Forms.Label();
            this.txtImagenArticulo = new System.Windows.Forms.TextBox();
            this.tbPrecioArticulo = new System.Windows.Forms.TextBox();
            this.btnCancelarArticulo = new System.Windows.Forms.Button();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.cmbCategoriaArticulo = new System.Windows.Forms.ComboBox();
            this.cmbMarcaArticulo = new System.Windows.Forms.ComboBox();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblMarcaArticulo = new System.Windows.Forms.Label();
            this.tbDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.tbNombreArticulo = new System.Windows.Forms.TextBox();
            this.tbCodigoArticulo = new System.Windows.Forms.TextBox();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblAgregarArticulos = new System.Windows.Forms.Label();
            this.gpArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // gpArticulos
            // 
            this.gpArticulos.Controls.Add(this.pbxImagenArticulo);
            this.gpArticulos.Controls.Add(this.lblImagenArticulo);
            this.gpArticulos.Controls.Add(this.txtImagenArticulo);
            this.gpArticulos.Controls.Add(this.tbPrecioArticulo);
            this.gpArticulos.Controls.Add(this.btnCancelarArticulo);
            this.gpArticulos.Controls.Add(this.lblPrecioArticulo);
            this.gpArticulos.Controls.Add(this.btnGuardarArticulo);
            this.gpArticulos.Controls.Add(this.cmbCategoriaArticulo);
            this.gpArticulos.Controls.Add(this.cmbMarcaArticulo);
            this.gpArticulos.Controls.Add(this.lblCategoriaArticulo);
            this.gpArticulos.Controls.Add(this.lblMarcaArticulo);
            this.gpArticulos.Controls.Add(this.tbDescripcionArticulo);
            this.gpArticulos.Controls.Add(this.tbNombreArticulo);
            this.gpArticulos.Controls.Add(this.tbCodigoArticulo);
            this.gpArticulos.Controls.Add(this.lblDescripcionArticulo);
            this.gpArticulos.Controls.Add(this.lblNombreArticulo);
            this.gpArticulos.Controls.Add(this.lblCodigoArticulo);
            this.gpArticulos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpArticulos.Location = new System.Drawing.Point(27, 69);
            this.gpArticulos.Name = "gpArticulos";
            this.gpArticulos.Size = new System.Drawing.Size(479, 562);
            this.gpArticulos.TabIndex = 0;
            this.gpArticulos.TabStop = false;
            this.gpArticulos.Text = "Detalles del Articulo";
            // 
            // pbxImagenArticulo
            // 
            this.pbxImagenArticulo.Location = new System.Drawing.Point(26, 281);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(413, 226);
            this.pbxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenArticulo.TabIndex = 14;
            this.pbxImagenArticulo.TabStop = false;
            // 
            // lblImagenArticulo
            // 
            this.lblImagenArticulo.AutoSize = true;
            this.lblImagenArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblImagenArticulo.Location = new System.Drawing.Point(300, 224);
            this.lblImagenArticulo.Name = "lblImagenArticulo";
            this.lblImagenArticulo.Size = new System.Drawing.Size(91, 19);
            this.lblImagenArticulo.TabIndex = 13;
            this.lblImagenArticulo.Text = "URL IMAGEN";
            // 
            // txtImagenArticulo
            // 
            this.txtImagenArticulo.Location = new System.Drawing.Point(306, 246);
            this.txtImagenArticulo.Name = "txtImagenArticulo";
            this.txtImagenArticulo.Size = new System.Drawing.Size(119, 29);
            this.txtImagenArticulo.TabIndex = 6;
            this.txtImagenArticulo.Leave += new System.EventHandler(this.txtImagenArticulo_Leave);
            // 
            // tbPrecioArticulo
            // 
            this.tbPrecioArticulo.Location = new System.Drawing.Point(31, 246);
            this.tbPrecioArticulo.Name = "tbPrecioArticulo";
            this.tbPrecioArticulo.Size = new System.Drawing.Size(119, 29);
            this.tbPrecioArticulo.TabIndex = 5;
            // 
            // btnCancelarArticulo
            // 
            this.btnCancelarArticulo.Location = new System.Drawing.Point(339, 524);
            this.btnCancelarArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelarArticulo.Name = "btnCancelarArticulo";
            this.btnCancelarArticulo.Size = new System.Drawing.Size(100, 30);
            this.btnCancelarArticulo.TabIndex = 8;
            this.btnCancelarArticulo.Text = "Cancelar";
            this.btnCancelarArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarArticulo.Click += new System.EventHandler(this.btnCancelarArticulo_Click);
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrecioArticulo.Location = new System.Drawing.Point(34, 224);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(46, 19);
            this.lblPrecioArticulo.TabIndex = 10;
            this.lblPrecioArticulo.Text = "Precio";
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Location = new System.Drawing.Point(26, 524);
            this.btnGuardarArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarArticulo.TabIndex = 7;
            this.btnGuardarArticulo.Text = "Guardar";
            this.btnGuardarArticulo.UseVisualStyleBackColor = true;
            this.btnGuardarArticulo.Click += new System.EventHandler(this.btnGuardarArticulo_Click);
            // 
            // cmbCategoriaArticulo
            // 
            this.cmbCategoriaArticulo.FormattingEnabled = true;
            this.cmbCategoriaArticulo.Location = new System.Drawing.Point(304, 192);
            this.cmbCategoriaArticulo.Name = "cmbCategoriaArticulo";
            this.cmbCategoriaArticulo.Size = new System.Drawing.Size(121, 29);
            this.cmbCategoriaArticulo.TabIndex = 4;
            // 
            // cmbMarcaArticulo
            // 
            this.cmbMarcaArticulo.FormattingEnabled = true;
            this.cmbMarcaArticulo.Location = new System.Drawing.Point(31, 192);
            this.cmbMarcaArticulo.Name = "cmbMarcaArticulo";
            this.cmbMarcaArticulo.Size = new System.Drawing.Size(121, 29);
            this.cmbMarcaArticulo.TabIndex = 3;
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(300, 170);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(68, 19);
            this.lblCategoriaArticulo.TabIndex = 7;
            this.lblCategoriaArticulo.Text = "Categoria";
            // 
            // lblMarcaArticulo
            // 
            this.lblMarcaArticulo.AutoSize = true;
            this.lblMarcaArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMarcaArticulo.Location = new System.Drawing.Point(33, 170);
            this.lblMarcaArticulo.Name = "lblMarcaArticulo";
            this.lblMarcaArticulo.Size = new System.Drawing.Size(47, 19);
            this.lblMarcaArticulo.TabIndex = 6;
            this.lblMarcaArticulo.Text = "Marca";
            // 
            // tbDescripcionArticulo
            // 
            this.tbDescripcionArticulo.Location = new System.Drawing.Point(31, 111);
            this.tbDescripcionArticulo.Multiline = true;
            this.tbDescripcionArticulo.Name = "tbDescripcionArticulo";
            this.tbDescripcionArticulo.Size = new System.Drawing.Size(408, 56);
            this.tbDescripcionArticulo.TabIndex = 2;
            // 
            // tbNombreArticulo
            // 
            this.tbNombreArticulo.Location = new System.Drawing.Point(304, 57);
            this.tbNombreArticulo.Name = "tbNombreArticulo";
            this.tbNombreArticulo.Size = new System.Drawing.Size(135, 29);
            this.tbNombreArticulo.TabIndex = 1;
            // 
            // tbCodigoArticulo
            // 
            this.tbCodigoArticulo.Location = new System.Drawing.Point(31, 57);
            this.tbCodigoArticulo.Name = "tbCodigoArticulo";
            this.tbCodigoArticulo.Size = new System.Drawing.Size(135, 29);
            this.tbCodigoArticulo.TabIndex = 0;
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(27, 89);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(79, 19);
            this.lblDescripcionArticulo.TabIndex = 2;
            this.lblDescripcionArticulo.Text = "Descripcion";
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombreArticulo.Location = new System.Drawing.Point(300, 35);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(59, 19);
            this.lblNombreArticulo.TabIndex = 1;
            this.lblNombreArticulo.Text = "Nombre";
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCodigoArticulo.Location = new System.Drawing.Point(27, 35);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(53, 19);
            this.lblCodigoArticulo.TabIndex = 0;
            this.lblCodigoArticulo.Text = "Codigo";
            // 
            // lblAgregarArticulos
            // 
            this.lblAgregarArticulos.AutoSize = true;
            this.lblAgregarArticulos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarArticulos.Location = new System.Drawing.Point(142, 24);
            this.lblAgregarArticulos.Name = "lblAgregarArticulos";
            this.lblAgregarArticulos.Size = new System.Drawing.Size(208, 25);
            this.lblAgregarArticulos.TabIndex = 7;
            this.lblAgregarArticulos.Text = "AGREGAR ARTICULOS";
            // 
            // FormArticuloAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 720);
            this.Controls.Add(this.lblAgregarArticulos);
            this.Controls.Add(this.gpArticulos);
            this.Name = "FormArticuloAgregar";
            this.Text = "FormArticuloAgregar";
            this.Load += new System.EventHandler(this.FormArticuloAgregar_Load);
            this.gpArticulos.ResumeLayout(false);
            this.gpArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpArticulos;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.TextBox tbDescripcionArticulo;
        private System.Windows.Forms.TextBox tbNombreArticulo;
        private System.Windows.Forms.TextBox tbCodigoArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.Label lblMarcaArticulo;
        private System.Windows.Forms.TextBox tbPrecioArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.ComboBox cmbCategoriaArticulo;
        private System.Windows.Forms.ComboBox cmbMarcaArticulo;
        private System.Windows.Forms.Button btnGuardarArticulo;
        private System.Windows.Forms.Button btnCancelarArticulo;
        private System.Windows.Forms.Label lblAgregarArticulos;
        private System.Windows.Forms.PictureBox pbxImagenArticulo;
        private System.Windows.Forms.Label lblImagenArticulo;
        private System.Windows.Forms.TextBox txtImagenArticulo;
    }
}