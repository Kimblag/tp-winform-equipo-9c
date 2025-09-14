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
            this.components = new System.ComponentModel.Container();
            this.gpArticulos = new System.Windows.Forms.GroupBox();
            this.tlpCamposArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.tbPrecioArticulo = new System.Windows.Forms.TextBox();
            this.tbCodigoArticulo = new System.Windows.Forms.TextBox();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.cmbCategoriaArticulo = new System.Windows.Forms.ComboBox();
            this.tbNombreArticulo = new System.Windows.Forms.TextBox();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.tbDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.lblMarcaArticulo = new System.Windows.Forms.Label();
            this.cmbMarcaArticulo = new System.Windows.Forms.ComboBox();
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.btnCancelarArticulo = new System.Windows.Forms.Button();
            this.lblAgregarArticulos = new System.Windows.Forms.Label();
            this.tlpFormularioArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlImagenesArticulo = new System.Windows.Forms.Panel();
            this.tlpImagenesArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNavegacionImagen = new System.Windows.Forms.TableLayoutPanel();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.lblIndiceImagen = new System.Windows.Forms.Label();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.flpAgregarImagen = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpCampoAgregarImagen = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarImagenArticulo = new System.Windows.Forms.Button();
            this.tbUrlImagenArticulo = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lstImagenesArticulo = new System.Windows.Forms.ListBox();
            this.pbPreviewImagenArticulo = new System.Windows.Forms.PictureBox();
            this.lblMensajeImagen = new System.Windows.Forms.Label();
            this.flpBotonesArticulo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminarImagenSeleccionada = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpArticulos.SuspendLayout();
            this.tlpCamposArticulo.SuspendLayout();
            this.tlpFormularioArticulo.SuspendLayout();
            this.pnlImagenesArticulo.SuspendLayout();
            this.tlpImagenesArticulo.SuspendLayout();
            this.tlpNavegacionImagen.SuspendLayout();
            this.flpAgregarImagen.SuspendLayout();
            this.tlpCampoAgregarImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewImagenArticulo)).BeginInit();
            this.flpBotonesArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpArticulos
            // 
            this.gpArticulos.Controls.Add(this.tlpCamposArticulo);
            this.gpArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpArticulos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpArticulos.Location = new System.Drawing.Point(20, 20);
            this.gpArticulos.Margin = new System.Windows.Forms.Padding(0);
            this.gpArticulos.Name = "gpArticulos";
            this.gpArticulos.Padding = new System.Windows.Forms.Padding(10);
            this.gpArticulos.Size = new System.Drawing.Size(539, 534);
            this.gpArticulos.TabIndex = 0;
            this.gpArticulos.TabStop = false;
            this.gpArticulos.Text = "Detalles del Artículo";
            // 
            // tlpCamposArticulo
            // 
            this.tlpCamposArticulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCamposArticulo.ColumnCount = 2;
            this.tlpCamposArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCamposArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCamposArticulo.Controls.Add(this.lblCodigoArticulo, 0, 0);
            this.tlpCamposArticulo.Controls.Add(this.tbPrecioArticulo, 1, 5);
            this.tlpCamposArticulo.Controls.Add(this.tbCodigoArticulo, 1, 0);
            this.tlpCamposArticulo.Controls.Add(this.lblPrecioArticulo, 0, 5);
            this.tlpCamposArticulo.Controls.Add(this.lblNombreArticulo, 0, 1);
            this.tlpCamposArticulo.Controls.Add(this.cmbCategoriaArticulo, 1, 4);
            this.tlpCamposArticulo.Controls.Add(this.tbNombreArticulo, 1, 1);
            this.tlpCamposArticulo.Controls.Add(this.lblCategoriaArticulo, 0, 4);
            this.tlpCamposArticulo.Controls.Add(this.lblDescripcionArticulo, 0, 2);
            this.tlpCamposArticulo.Controls.Add(this.tbDescripcionArticulo, 1, 2);
            this.tlpCamposArticulo.Controls.Add(this.lblMarcaArticulo, 0, 3);
            this.tlpCamposArticulo.Controls.Add(this.cmbMarcaArticulo, 1, 3);
            this.tlpCamposArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCamposArticulo.Location = new System.Drawing.Point(10, 32);
            this.tlpCamposArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.tlpCamposArticulo.Name = "tlpCamposArticulo";
            this.tlpCamposArticulo.Padding = new System.Windows.Forms.Padding(10);
            this.tlpCamposArticulo.RowCount = 6;
            this.tlpCamposArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCamposArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCamposArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCamposArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCamposArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCamposArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCamposArticulo.Size = new System.Drawing.Size(519, 492);
            this.tlpCamposArticulo.TabIndex = 0;
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCodigoArticulo.Location = new System.Drawing.Point(10, 15);
            this.lblCodigoArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(92, 29);
            this.lblCodigoArticulo.TabIndex = 0;
            this.lblCodigoArticulo.Text = "Codigo";
            this.lblCodigoArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPrecioArticulo
            // 
            this.tbPrecioArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrecioArticulo.Location = new System.Drawing.Point(112, 253);
            this.tbPrecioArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.tbPrecioArticulo.MaxLength = 15;
            this.tbPrecioArticulo.Name = "tbPrecioArticulo";
            this.tbPrecioArticulo.Size = new System.Drawing.Size(377, 29);
            this.tbPrecioArticulo.TabIndex = 11;
            // 
            // tbCodigoArticulo
            // 
            this.tbCodigoArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCodigoArticulo.Location = new System.Drawing.Point(112, 15);
            this.tbCodigoArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.tbCodigoArticulo.MaxLength = 50;
            this.tbCodigoArticulo.Name = "tbCodigoArticulo";
            this.tbCodigoArticulo.Size = new System.Drawing.Size(377, 29);
            this.tbCodigoArticulo.TabIndex = 0;
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrecioArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrecioArticulo.Location = new System.Drawing.Point(10, 253);
            this.lblPrecioArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(92, 224);
            this.lblPrecioArticulo.TabIndex = 10;
            this.lblPrecioArticulo.Text = "Precio";
            this.lblPrecioArticulo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombreArticulo.Location = new System.Drawing.Point(10, 54);
            this.lblNombreArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(92, 29);
            this.lblNombreArticulo.TabIndex = 1;
            this.lblNombreArticulo.Text = "Nombre";
            this.lblNombreArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategoriaArticulo
            // 
            this.cmbCategoriaArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategoriaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaArticulo.FormattingEnabled = true;
            this.cmbCategoriaArticulo.Location = new System.Drawing.Point(112, 214);
            this.cmbCategoriaArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.cmbCategoriaArticulo.Name = "cmbCategoriaArticulo";
            this.cmbCategoriaArticulo.Size = new System.Drawing.Size(377, 29);
            this.cmbCategoriaArticulo.TabIndex = 4;
            // 
            // tbNombreArticulo
            // 
            this.tbNombreArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNombreArticulo.Location = new System.Drawing.Point(112, 54);
            this.tbNombreArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.tbNombreArticulo.MaxLength = 50;
            this.tbNombreArticulo.Name = "tbNombreArticulo";
            this.tbNombreArticulo.Size = new System.Drawing.Size(377, 29);
            this.tbNombreArticulo.TabIndex = 1;
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoriaArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(10, 214);
            this.lblCategoriaArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(92, 29);
            this.lblCategoriaArticulo.TabIndex = 7;
            this.lblCategoriaArticulo.Text = "Categoria";
            this.lblCategoriaArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcionArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(10, 93);
            this.lblDescripcionArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(92, 72);
            this.lblDescripcionArticulo.TabIndex = 2;
            this.lblDescripcionArticulo.Text = "Descripcion";
            this.lblDescripcionArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDescripcionArticulo
            // 
            this.tbDescripcionArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescripcionArticulo.Location = new System.Drawing.Point(112, 93);
            this.tbDescripcionArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.tbDescripcionArticulo.MaxLength = 150;
            this.tbDescripcionArticulo.Multiline = true;
            this.tbDescripcionArticulo.Name = "tbDescripcionArticulo";
            this.tbDescripcionArticulo.Size = new System.Drawing.Size(377, 72);
            this.tbDescripcionArticulo.TabIndex = 2;
            // 
            // lblMarcaArticulo
            // 
            this.lblMarcaArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMarcaArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMarcaArticulo.Location = new System.Drawing.Point(10, 175);
            this.lblMarcaArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.lblMarcaArticulo.Name = "lblMarcaArticulo";
            this.lblMarcaArticulo.Size = new System.Drawing.Size(92, 29);
            this.lblMarcaArticulo.TabIndex = 6;
            this.lblMarcaArticulo.Text = "Marca";
            this.lblMarcaArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMarcaArticulo
            // 
            this.cmbMarcaArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMarcaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaArticulo.FormattingEnabled = true;
            this.cmbMarcaArticulo.Location = new System.Drawing.Point(112, 175);
            this.cmbMarcaArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.cmbMarcaArticulo.Name = "cmbMarcaArticulo";
            this.cmbMarcaArticulo.Size = new System.Drawing.Size(377, 29);
            this.cmbMarcaArticulo.TabIndex = 3;
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Location = new System.Drawing.Point(32, 17);
            this.btnGuardarArticulo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(120, 30);
            this.btnGuardarArticulo.TabIndex = 0;
            this.btnGuardarArticulo.Text = "Guardar";
            this.btnGuardarArticulo.UseVisualStyleBackColor = true;
            this.btnGuardarArticulo.Click += new System.EventHandler(this.btnGuardarArticulo_Click);
            // 
            // btnCancelarArticulo
            // 
            this.btnCancelarArticulo.Location = new System.Drawing.Point(164, 17);
            this.btnCancelarArticulo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnCancelarArticulo.Name = "btnCancelarArticulo";
            this.btnCancelarArticulo.Size = new System.Drawing.Size(120, 30);
            this.btnCancelarArticulo.TabIndex = 1;
            this.btnCancelarArticulo.Text = "Cancelar";
            this.btnCancelarArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarArticulo.Click += new System.EventHandler(this.btnCancelarArticulo_Click);
            // 
            // lblAgregarArticulos
            // 
            this.lblAgregarArticulos.AutoSize = true;
            this.lblAgregarArticulos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarArticulos.Location = new System.Drawing.Point(26, 30);
            this.lblAgregarArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarArticulos.Name = "lblAgregarArticulos";
            this.lblAgregarArticulos.Size = new System.Drawing.Size(208, 25);
            this.lblAgregarArticulos.TabIndex = 7;
            this.lblAgregarArticulos.Text = "AGREGAR ARTICULOS";
            // 
            // tlpFormularioArticulo
            // 
            this.tlpFormularioArticulo.ColumnCount = 2;
            this.tlpFormularioArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpFormularioArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpFormularioArticulo.Controls.Add(this.gpArticulos, 0, 0);
            this.tlpFormularioArticulo.Controls.Add(this.pnlImagenesArticulo, 1, 0);
            this.tlpFormularioArticulo.Controls.Add(this.flpBotonesArticulo, 1, 1);
            this.tlpFormularioArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFormularioArticulo.Location = new System.Drawing.Point(0, 0);
            this.tlpFormularioArticulo.Name = "tlpFormularioArticulo";
            this.tlpFormularioArticulo.Padding = new System.Windows.Forms.Padding(20);
            this.tlpFormularioArticulo.RowCount = 2;
            this.tlpFormularioArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpFormularioArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpFormularioArticulo.Size = new System.Drawing.Size(1021, 634);
            this.tlpFormularioArticulo.TabIndex = 8;
            // 
            // pnlImagenesArticulo
            // 
            this.pnlImagenesArticulo.Controls.Add(this.tlpImagenesArticulo);
            this.pnlImagenesArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImagenesArticulo.Location = new System.Drawing.Point(559, 20);
            this.pnlImagenesArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlImagenesArticulo.Name = "pnlImagenesArticulo";
            this.pnlImagenesArticulo.Padding = new System.Windows.Forms.Padding(10);
            this.pnlImagenesArticulo.Size = new System.Drawing.Size(442, 534);
            this.pnlImagenesArticulo.TabIndex = 2;
            // 
            // tlpImagenesArticulo
            // 
            this.tlpImagenesArticulo.ColumnCount = 1;
            this.tlpImagenesArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImagenesArticulo.Controls.Add(this.tlpNavegacionImagen, 0, 3);
            this.tlpImagenesArticulo.Controls.Add(this.flpAgregarImagen, 0, 0);
            this.tlpImagenesArticulo.Controls.Add(this.lstImagenesArticulo, 0, 1);
            this.tlpImagenesArticulo.Controls.Add(this.pbPreviewImagenArticulo, 0, 2);
            this.tlpImagenesArticulo.Controls.Add(this.lblMensajeImagen, 0, 4);
            this.tlpImagenesArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpImagenesArticulo.Location = new System.Drawing.Point(10, 10);
            this.tlpImagenesArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpImagenesArticulo.Name = "tlpImagenesArticulo";
            this.tlpImagenesArticulo.RowCount = 5;
            this.tlpImagenesArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImagenesArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpImagenesArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlpImagenesArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImagenesArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpImagenesArticulo.Size = new System.Drawing.Size(422, 514);
            this.tlpImagenesArticulo.TabIndex = 0;
            // 
            // tlpNavegacionImagen
            // 
            this.tlpNavegacionImagen.ColumnCount = 3;
            this.tlpNavegacionImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpNavegacionImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavegacionImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpNavegacionImagen.Controls.Add(this.btnImagenAnterior, 0, 0);
            this.tlpNavegacionImagen.Controls.Add(this.lblIndiceImagen, 1, 0);
            this.tlpNavegacionImagen.Controls.Add(this.btnImagenSiguiente, 2, 0);
            this.tlpNavegacionImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavegacionImagen.Location = new System.Drawing.Point(0, 452);
            this.tlpNavegacionImagen.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNavegacionImagen.Name = "tlpNavegacionImagen";
            this.tlpNavegacionImagen.RowCount = 1;
            this.tlpNavegacionImagen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavegacionImagen.Size = new System.Drawing.Size(422, 44);
            this.tlpNavegacionImagen.TabIndex = 3;
            this.tlpNavegacionImagen.Visible = false;
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.Location = new System.Drawing.Point(5, 5);
            this.btnImagenAnterior.Margin = new System.Windows.Forms.Padding(5);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(30, 30);
            this.btnImagenAnterior.TabIndex = 0;
            this.btnImagenAnterior.Text = "←";
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // lblIndiceImagen
            // 
            this.lblIndiceImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIndiceImagen.Location = new System.Drawing.Point(45, 5);
            this.lblIndiceImagen.Margin = new System.Windows.Forms.Padding(5);
            this.lblIndiceImagen.Name = "lblIndiceImagen";
            this.lblIndiceImagen.Size = new System.Drawing.Size(332, 34);
            this.lblIndiceImagen.TabIndex = 2;
            this.lblIndiceImagen.Text = "1 / N";
            this.lblIndiceImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Location = new System.Drawing.Point(387, 5);
            this.btnImagenSiguiente.Margin = new System.Windows.Forms.Padding(5);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(30, 30);
            this.btnImagenSiguiente.TabIndex = 1;
            this.btnImagenSiguiente.Text = "→";
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // flpAgregarImagen
            // 
            this.flpAgregarImagen.Controls.Add(this.tlpCampoAgregarImagen);
            this.flpAgregarImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAgregarImagen.Location = new System.Drawing.Point(0, 0);
            this.flpAgregarImagen.Margin = new System.Windows.Forms.Padding(0);
            this.flpAgregarImagen.Name = "flpAgregarImagen";
            this.flpAgregarImagen.Size = new System.Drawing.Size(422, 100);
            this.flpAgregarImagen.TabIndex = 0;
            // 
            // tlpCampoAgregarImagen
            // 
            this.tlpCampoAgregarImagen.AutoSize = true;
            this.tlpCampoAgregarImagen.ColumnCount = 2;
            this.tlpCampoAgregarImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCampoAgregarImagen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCampoAgregarImagen.Controls.Add(this.btnAgregarImagenArticulo, 1, 1);
            this.tlpCampoAgregarImagen.Controls.Add(this.tbUrlImagenArticulo, 0, 1);
            this.tlpCampoAgregarImagen.Controls.Add(this.lblUrlImagen, 0, 0);
            this.tlpCampoAgregarImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCampoAgregarImagen.Location = new System.Drawing.Point(0, 0);
            this.tlpCampoAgregarImagen.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCampoAgregarImagen.Name = "tlpCampoAgregarImagen";
            this.tlpCampoAgregarImagen.RowCount = 2;
            this.tlpCampoAgregarImagen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampoAgregarImagen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampoAgregarImagen.Size = new System.Drawing.Size(410, 76);
            this.tlpCampoAgregarImagen.TabIndex = 2;
            // 
            // btnAgregarImagenArticulo
            // 
            this.btnAgregarImagenArticulo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregarImagenArticulo.Location = new System.Drawing.Point(320, 41);
            this.btnAgregarImagenArticulo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 5);
            this.btnAgregarImagenArticulo.Name = "btnAgregarImagenArticulo";
            this.btnAgregarImagenArticulo.Size = new System.Drawing.Size(90, 30);
            this.btnAgregarImagenArticulo.TabIndex = 1;
            this.btnAgregarImagenArticulo.Text = "Agregar";
            this.btnAgregarImagenArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarImagenArticulo.Click += new System.EventHandler(this.btnAgregarImagenArticulo_Click);
            // 
            // tbUrlImagenArticulo
            // 
            this.tbUrlImagenArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUrlImagenArticulo.Location = new System.Drawing.Point(0, 43);
            this.tbUrlImagenArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.tbUrlImagenArticulo.MaxLength = 300;
            this.tbUrlImagenArticulo.Name = "tbUrlImagenArticulo";
            this.tbUrlImagenArticulo.Size = new System.Drawing.Size(300, 25);
            this.tbUrlImagenArticulo.TabIndex = 0;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUrlImagen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.Location = new System.Drawing.Point(0, 5);
            this.lblUrlImagen.Margin = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(310, 33);
            this.lblUrlImagen.TabIndex = 2;
            this.lblUrlImagen.Text = "URL de imagen";
            this.lblUrlImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstImagenesArticulo
            // 
            this.lstImagenesArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstImagenesArticulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstImagenesArticulo.FormattingEnabled = true;
            this.lstImagenesArticulo.ItemHeight = 15;
            this.lstImagenesArticulo.Location = new System.Drawing.Point(0, 105);
            this.lstImagenesArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lstImagenesArticulo.Name = "lstImagenesArticulo";
            this.lstImagenesArticulo.Size = new System.Drawing.Size(422, 107);
            this.lstImagenesArticulo.TabIndex = 1;
            this.lstImagenesArticulo.SelectedIndexChanged += new System.EventHandler(this.lstImagenesArticulo_SelectedIndexChanged);
            // 
            // pbPreviewImagenArticulo
            // 
            this.pbPreviewImagenArticulo.BackColor = System.Drawing.Color.LightGray;
            this.pbPreviewImagenArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreviewImagenArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPreviewImagenArticulo.Location = new System.Drawing.Point(3, 220);
            this.pbPreviewImagenArticulo.Name = "pbPreviewImagenArticulo";
            this.pbPreviewImagenArticulo.Size = new System.Drawing.Size(416, 229);
            this.pbPreviewImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreviewImagenArticulo.TabIndex = 2;
            this.pbPreviewImagenArticulo.TabStop = false;
            // 
            // lblMensajeImagen
            // 
            this.lblMensajeImagen.AutoSize = true;
            this.lblMensajeImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMensajeImagen.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMensajeImagen.Location = new System.Drawing.Point(3, 496);
            this.lblMensajeImagen.Name = "lblMensajeImagen";
            this.lblMensajeImagen.Size = new System.Drawing.Size(416, 17);
            this.lblMensajeImagen.TabIndex = 4;
            this.lblMensajeImagen.Visible = false;
            // 
            // flpBotonesArticulo
            // 
            this.flpBotonesArticulo.Controls.Add(this.btnEliminarImagenSeleccionada);
            this.flpBotonesArticulo.Controls.Add(this.btnCancelarArticulo);
            this.flpBotonesArticulo.Controls.Add(this.btnGuardarArticulo);
            this.flpBotonesArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBotonesArticulo.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBotonesArticulo.Location = new System.Drawing.Point(559, 554);
            this.flpBotonesArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.flpBotonesArticulo.Name = "flpBotonesArticulo";
            this.flpBotonesArticulo.Padding = new System.Windows.Forms.Padding(10);
            this.flpBotonesArticulo.Size = new System.Drawing.Size(442, 60);
            this.flpBotonesArticulo.TabIndex = 3;
            // 
            // btnEliminarImagenSeleccionada
            // 
            this.btnEliminarImagenSeleccionada.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarImagenSeleccionada.Location = new System.Drawing.Point(296, 17);
            this.btnEliminarImagenSeleccionada.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnEliminarImagenSeleccionada.Name = "btnEliminarImagenSeleccionada";
            this.btnEliminarImagenSeleccionada.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarImagenSeleccionada.TabIndex = 3;
            this.btnEliminarImagenSeleccionada.Text = "Eliminar imagen";
            this.btnEliminarImagenSeleccionada.UseVisualStyleBackColor = false;
            this.btnEliminarImagenSeleccionada.Visible = false;
            this.btnEliminarImagenSeleccionada.Click += new System.EventHandler(this.btnEliminarImagenSeleccionada_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FormArticuloAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 634);
            this.Controls.Add(this.tlpFormularioArticulo);
            this.Controls.Add(this.lblAgregarArticulos);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1037, 673);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1037, 673);
            this.Name = "FormArticuloAgregar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle Articulo";
            this.Load += new System.EventHandler(this.FormArticuloAgregar_Load);
            this.gpArticulos.ResumeLayout(false);
            this.tlpCamposArticulo.ResumeLayout(false);
            this.tlpCamposArticulo.PerformLayout();
            this.tlpFormularioArticulo.ResumeLayout(false);
            this.pnlImagenesArticulo.ResumeLayout(false);
            this.tlpImagenesArticulo.ResumeLayout(false);
            this.tlpImagenesArticulo.PerformLayout();
            this.tlpNavegacionImagen.ResumeLayout(false);
            this.flpAgregarImagen.ResumeLayout(false);
            this.flpAgregarImagen.PerformLayout();
            this.tlpCampoAgregarImagen.ResumeLayout(false);
            this.tlpCampoAgregarImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewImagenArticulo)).EndInit();
            this.flpBotonesArticulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tlpCamposArticulo;
        private System.Windows.Forms.TableLayoutPanel tlpFormularioArticulo;
        private System.Windows.Forms.Panel pnlImagenesArticulo;
        private System.Windows.Forms.TableLayoutPanel tlpImagenesArticulo;
        private System.Windows.Forms.FlowLayoutPanel flpAgregarImagen;
        private System.Windows.Forms.TextBox tbUrlImagenArticulo;
        private System.Windows.Forms.Button btnAgregarImagenArticulo;
        private System.Windows.Forms.ListBox lstImagenesArticulo;
        private System.Windows.Forms.PictureBox pbPreviewImagenArticulo;
        private System.Windows.Forms.TableLayoutPanel tlpNavegacionImagen;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.Label lblIndiceImagen;
        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.FlowLayoutPanel flpBotonesArticulo;
        private System.Windows.Forms.Label lblMensajeImagen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnEliminarImagenSeleccionada;
        private System.Windows.Forms.TableLayoutPanel tlpCampoAgregarImagen;
        private System.Windows.Forms.Label lblUrlImagen;
    }
}