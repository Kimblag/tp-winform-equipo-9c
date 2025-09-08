namespace CatalogoArticulos.UI.Formularios.Articulos
{
    partial class UCArticulos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpArticulos = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloArticulos = new System.Windows.Forms.Label();
            this.tlpFiltrosArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.lblCampoArticulo = new System.Windows.Forms.Label();
            this.lblCriterioArticulo = new System.Windows.Forms.Label();
            this.lblValorArticulo = new System.Windows.Forms.Label();
            this.cmbCampoArticulo = new System.Windows.Forms.ComboBox();
            this.cmbCriterioArticulo = new System.Windows.Forms.ComboBox();
            this.txtValorArticulo = new System.Windows.Forms.TextBox();
            this.flpBotonesFiltrosArticulo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLimpiarFiltrosArticulo = new System.Windows.Forms.Button();
            this.btnAplicarFiltrosArticulo = new System.Windows.Forms.Button();
            this.tlpListadoArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEncabezadoListadoArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.flpBotonesArticulo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnEditarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.lblListadoArticulos = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.panelDetalleArticulo = new System.Windows.Forms.Panel();
            this.tlpDatosArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblMarcaArticulo = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.tlpImagenArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.pbImagenArticulo = new System.Windows.Forms.PictureBox();
            this.tlpNavegacionImagenArticulo = new System.Windows.Forms.TableLayoutPanel();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.lblIndiceImagen = new System.Windows.Forms.Label();
            this.tlpArticulos.SuspendLayout();
            this.tlpFiltrosArticulo.SuspendLayout();
            this.flpBotonesFiltrosArticulo.SuspendLayout();
            this.tlpListadoArticulo.SuspendLayout();
            this.tlpEncabezadoListadoArticulo.SuspendLayout();
            this.flpBotonesArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.panelDetalleArticulo.SuspendLayout();
            this.tlpDatosArticulo.SuspendLayout();
            this.tlpImagenArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).BeginInit();
            this.tlpNavegacionImagenArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpArticulos
            // 
            this.tlpArticulos.BackColor = System.Drawing.Color.Transparent;
            this.tlpArticulos.ColumnCount = 2;
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpArticulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpArticulos.Controls.Add(this.lblTituloArticulos, 0, 0);
            this.tlpArticulos.Controls.Add(this.tlpFiltrosArticulo, 0, 1);
            this.tlpArticulos.Controls.Add(this.flpBotonesFiltrosArticulo, 1, 1);
            this.tlpArticulos.Controls.Add(this.tlpListadoArticulo, 0, 2);
            this.tlpArticulos.Controls.Add(this.panelDetalleArticulo, 1, 2);
            this.tlpArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArticulos.Location = new System.Drawing.Point(0, 0);
            this.tlpArticulos.Margin = new System.Windows.Forms.Padding(0);
            this.tlpArticulos.Name = "tlpArticulos";
            this.tlpArticulos.Padding = new System.Windows.Forms.Padding(10);
            this.tlpArticulos.RowCount = 3;
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpArticulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpArticulos.Size = new System.Drawing.Size(1031, 891);
            this.tlpArticulos.TabIndex = 0;
            // 
            // lblTituloArticulos
            // 
            this.lblTituloArticulos.AutoSize = true;
            this.tlpArticulos.SetColumnSpan(this.lblTituloArticulos, 2);
            this.lblTituloArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloArticulos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArticulos.Location = new System.Drawing.Point(13, 10);
            this.lblTituloArticulos.Name = "lblTituloArticulos";
            this.lblTituloArticulos.Padding = new System.Windows.Forms.Padding(5);
            this.lblTituloArticulos.Size = new System.Drawing.Size(1005, 40);
            this.lblTituloArticulos.TabIndex = 0;
            this.lblTituloArticulos.Text = "Gestión de artículos";
            // 
            // tlpFiltrosArticulo
            // 
            this.tlpFiltrosArticulo.ColumnCount = 3;
            this.tlpFiltrosArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltrosArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltrosArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltrosArticulo.Controls.Add(this.lblCampoArticulo, 0, 0);
            this.tlpFiltrosArticulo.Controls.Add(this.lblCriterioArticulo, 1, 0);
            this.tlpFiltrosArticulo.Controls.Add(this.lblValorArticulo, 2, 0);
            this.tlpFiltrosArticulo.Controls.Add(this.cmbCampoArticulo, 0, 1);
            this.tlpFiltrosArticulo.Controls.Add(this.cmbCriterioArticulo, 1, 1);
            this.tlpFiltrosArticulo.Controls.Add(this.txtValorArticulo, 2, 1);
            this.tlpFiltrosArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltrosArticulo.Location = new System.Drawing.Point(10, 50);
            this.tlpFiltrosArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFiltrosArticulo.Name = "tlpFiltrosArticulo";
            this.tlpFiltrosArticulo.RowCount = 2;
            this.tlpFiltrosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFiltrosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpFiltrosArticulo.Size = new System.Drawing.Size(707, 100);
            this.tlpFiltrosArticulo.TabIndex = 1;
            // 
            // lblCampoArticulo
            // 
            this.lblCampoArticulo.AutoSize = true;
            this.lblCampoArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCampoArticulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoArticulo.Location = new System.Drawing.Point(5, 0);
            this.lblCampoArticulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCampoArticulo.Name = "lblCampoArticulo";
            this.lblCampoArticulo.Size = new System.Drawing.Size(220, 20);
            this.lblCampoArticulo.TabIndex = 0;
            this.lblCampoArticulo.Text = "Campo";
            this.lblCampoArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCriterioArticulo
            // 
            this.lblCriterioArticulo.AutoSize = true;
            this.lblCriterioArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCriterioArticulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioArticulo.Location = new System.Drawing.Point(235, 0);
            this.lblCriterioArticulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCriterioArticulo.Name = "lblCriterioArticulo";
            this.lblCriterioArticulo.Size = new System.Drawing.Size(220, 20);
            this.lblCriterioArticulo.TabIndex = 1;
            this.lblCriterioArticulo.Text = "Criterio";
            this.lblCriterioArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorArticulo
            // 
            this.lblValorArticulo.AutoSize = true;
            this.lblValorArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorArticulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorArticulo.Location = new System.Drawing.Point(465, 0);
            this.lblValorArticulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValorArticulo.Name = "lblValorArticulo";
            this.lblValorArticulo.Size = new System.Drawing.Size(237, 20);
            this.lblValorArticulo.TabIndex = 2;
            this.lblValorArticulo.Text = "Valor";
            this.lblValorArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCampoArticulo
            // 
            this.cmbCampoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampoArticulo.FormattingEnabled = true;
            this.cmbCampoArticulo.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Descripcion",
            "Precio",
            "Marca",
            "Categoria"});
            this.cmbCampoArticulo.Location = new System.Drawing.Point(5, 25);
            this.cmbCampoArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCampoArticulo.Name = "cmbCampoArticulo";
            this.cmbCampoArticulo.Size = new System.Drawing.Size(220, 25);
            this.cmbCampoArticulo.TabIndex = 3;
            // 
            // cmbCriterioArticulo
            // 
            this.cmbCriterioArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterioArticulo.FormattingEnabled = true;
            this.cmbCriterioArticulo.Items.AddRange(new object[] {
            "Contiene",
            "Comienza con",
            "Termina con",
            "Mayor que",
            "Menor que"});
            this.cmbCriterioArticulo.Location = new System.Drawing.Point(235, 25);
            this.cmbCriterioArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCriterioArticulo.Name = "cmbCriterioArticulo";
            this.cmbCriterioArticulo.Size = new System.Drawing.Size(220, 25);
            this.cmbCriterioArticulo.TabIndex = 4;
            // 
            // txtValorArticulo
            // 
            this.txtValorArticulo.Location = new System.Drawing.Point(465, 25);
            this.txtValorArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorArticulo.MaxLength = 50;
            this.txtValorArticulo.Name = "txtValorArticulo";
            this.txtValorArticulo.Size = new System.Drawing.Size(220, 25);
            this.txtValorArticulo.TabIndex = 5;
            // 
            // flpBotonesFiltrosArticulo
            // 
            this.flpBotonesFiltrosArticulo.AutoSize = true;
            this.flpBotonesFiltrosArticulo.Controls.Add(this.btnLimpiarFiltrosArticulo);
            this.flpBotonesFiltrosArticulo.Controls.Add(this.btnAplicarFiltrosArticulo);
            this.flpBotonesFiltrosArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBotonesFiltrosArticulo.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBotonesFiltrosArticulo.Location = new System.Drawing.Point(717, 50);
            this.flpBotonesFiltrosArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.flpBotonesFiltrosArticulo.Name = "flpBotonesFiltrosArticulo";
            this.flpBotonesFiltrosArticulo.Padding = new System.Windows.Forms.Padding(0, 16, 0, 20);
            this.flpBotonesFiltrosArticulo.Size = new System.Drawing.Size(304, 100);
            this.flpBotonesFiltrosArticulo.TabIndex = 2;
            // 
            // btnLimpiarFiltrosArticulo
            // 
            this.btnLimpiarFiltrosArticulo.BackColor = System.Drawing.Color.White;
            this.btnLimpiarFiltrosArticulo.Location = new System.Drawing.Point(179, 21);
            this.btnLimpiarFiltrosArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiarFiltrosArticulo.Name = "btnLimpiarFiltrosArticulo";
            this.btnLimpiarFiltrosArticulo.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiarFiltrosArticulo.TabIndex = 1;
            this.btnLimpiarFiltrosArticulo.Text = "Limpiar filtros";
            this.btnLimpiarFiltrosArticulo.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltrosArticulo.Click += new System.EventHandler(this.btnLimpiarFiltrosArticulo_Click);
            // 
            // btnAplicarFiltrosArticulo
            // 
            this.btnAplicarFiltrosArticulo.Location = new System.Drawing.Point(49, 21);
            this.btnAplicarFiltrosArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.btnAplicarFiltrosArticulo.Name = "btnAplicarFiltrosArticulo";
            this.btnAplicarFiltrosArticulo.Size = new System.Drawing.Size(120, 30);
            this.btnAplicarFiltrosArticulo.TabIndex = 0;
            this.btnAplicarFiltrosArticulo.Text = "Buscar";
            this.btnAplicarFiltrosArticulo.UseVisualStyleBackColor = true;
            this.btnAplicarFiltrosArticulo.Click += new System.EventHandler(this.btnAplicarFiltrosArticulo_Click);
            // 
            // tlpListadoArticulo
            // 
            this.tlpListadoArticulo.ColumnCount = 1;
            this.tlpListadoArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListadoArticulo.Controls.Add(this.tlpEncabezadoListadoArticulo, 0, 0);
            this.tlpListadoArticulo.Controls.Add(this.dgvArticulos, 0, 1);
            this.tlpListadoArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListadoArticulo.Location = new System.Drawing.Point(13, 153);
            this.tlpListadoArticulo.Name = "tlpListadoArticulo";
            this.tlpListadoArticulo.RowCount = 2;
            this.tlpListadoArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpListadoArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListadoArticulo.Size = new System.Drawing.Size(701, 725);
            this.tlpListadoArticulo.TabIndex = 3;
            // 
            // tlpEncabezadoListadoArticulo
            // 
            this.tlpEncabezadoListadoArticulo.ColumnCount = 2;
            this.tlpEncabezadoListadoArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEncabezadoListadoArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEncabezadoListadoArticulo.Controls.Add(this.flpBotonesArticulo, 1, 0);
            this.tlpEncabezadoListadoArticulo.Controls.Add(this.lblListadoArticulos, 0, 0);
            this.tlpEncabezadoListadoArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncabezadoListadoArticulo.Location = new System.Drawing.Point(0, 0);
            this.tlpEncabezadoListadoArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEncabezadoListadoArticulo.Name = "tlpEncabezadoListadoArticulo";
            this.tlpEncabezadoListadoArticulo.RowCount = 1;
            this.tlpEncabezadoListadoArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEncabezadoListadoArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEncabezadoListadoArticulo.Size = new System.Drawing.Size(701, 40);
            this.tlpEncabezadoListadoArticulo.TabIndex = 0;
            // 
            // flpBotonesArticulo
            // 
            this.flpBotonesArticulo.AutoSize = true;
            this.flpBotonesArticulo.Controls.Add(this.btnEliminarArticulo);
            this.flpBotonesArticulo.Controls.Add(this.btnEditarArticulo);
            this.flpBotonesArticulo.Controls.Add(this.btnAgregarArticulo);
            this.flpBotonesArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBotonesArticulo.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBotonesArticulo.Location = new System.Drawing.Point(350, 0);
            this.flpBotonesArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.flpBotonesArticulo.Name = "flpBotonesArticulo";
            this.flpBotonesArticulo.Size = new System.Drawing.Size(351, 40);
            this.flpBotonesArticulo.TabIndex = 0;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(256, 5);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(90, 30);
            this.btnEliminarArticulo.TabIndex = 0;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            // 
            // btnEditarArticulo
            // 
            this.btnEditarArticulo.Location = new System.Drawing.Point(156, 5);
            this.btnEditarArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditarArticulo.Name = "btnEditarArticulo";
            this.btnEditarArticulo.Size = new System.Drawing.Size(90, 30);
            this.btnEditarArticulo.TabIndex = 1;
            this.btnEditarArticulo.Text = "Editar";
            this.btnEditarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(56, 5);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(90, 30);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            // 
            // lblListadoArticulos
            // 
            this.lblListadoArticulos.AutoSize = true;
            this.lblListadoArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListadoArticulos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListadoArticulos.Location = new System.Drawing.Point(3, 0);
            this.lblListadoArticulos.Name = "lblListadoArticulos";
            this.lblListadoArticulos.Padding = new System.Windows.Forms.Padding(5);
            this.lblListadoArticulos.Size = new System.Drawing.Size(344, 40);
            this.lblListadoArticulos.TabIndex = 1;
            this.lblListadoArticulos.Text = "Listado de artículos";
            this.lblListadoArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 43);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(695, 679);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // panelDetalleArticulo
            // 
            this.panelDetalleArticulo.BackColor = System.Drawing.Color.White;
            this.panelDetalleArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetalleArticulo.Controls.Add(this.tlpDatosArticulo);
            this.panelDetalleArticulo.Controls.Add(this.tlpImagenArticulo);
            this.panelDetalleArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalleArticulo.Location = new System.Drawing.Point(720, 153);
            this.panelDetalleArticulo.Name = "panelDetalleArticulo";
            this.panelDetalleArticulo.Padding = new System.Windows.Forms.Padding(10);
            this.panelDetalleArticulo.Size = new System.Drawing.Size(298, 725);
            this.panelDetalleArticulo.TabIndex = 4;
            // 
            // tlpDatosArticulo
            // 
            this.tlpDatosArticulo.BackColor = System.Drawing.Color.Transparent;
            this.tlpDatosArticulo.ColumnCount = 1;
            this.tlpDatosArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatosArticulo.Controls.Add(this.lblPrecioArticulo, 0, 4);
            this.tlpDatosArticulo.Controls.Add(this.lblCategoriaArticulo, 0, 3);
            this.tlpDatosArticulo.Controls.Add(this.lblMarcaArticulo, 0, 2);
            this.tlpDatosArticulo.Controls.Add(this.lblNombreArticulo, 0, 1);
            this.tlpDatosArticulo.Controls.Add(this.lblCodigoArticulo, 0, 0);
            this.tlpDatosArticulo.Controls.Add(this.lblDescripcionArticulo, 0, 5);
            this.tlpDatosArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDatosArticulo.Location = new System.Drawing.Point(10, 204);
            this.tlpDatosArticulo.Margin = new System.Windows.Forms.Padding(10);
            this.tlpDatosArticulo.Name = "tlpDatosArticulo";
            this.tlpDatosArticulo.RowCount = 6;
            this.tlpDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDatosArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDatosArticulo.Size = new System.Drawing.Size(276, 401);
            this.tlpDatosArticulo.TabIndex = 1;
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrecioArticulo.Location = new System.Drawing.Point(0, 120);
            this.lblPrecioArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Padding = new System.Windows.Forms.Padding(5);
            this.lblPrecioArticulo.Size = new System.Drawing.Size(276, 30);
            this.lblPrecioArticulo.TabIndex = 4;
            this.lblPrecioArticulo.Text = "Precio: $1.200,00";
            this.lblPrecioArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(0, 90);
            this.lblCategoriaArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Padding = new System.Windows.Forms.Padding(5);
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(276, 30);
            this.lblCategoriaArticulo.TabIndex = 3;
            this.lblCategoriaArticulo.Text = "Categoría: Accesorios";
            this.lblCategoriaArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMarcaArticulo
            // 
            this.lblMarcaArticulo.AutoSize = true;
            this.lblMarcaArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcaArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMarcaArticulo.Location = new System.Drawing.Point(0, 60);
            this.lblMarcaArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblMarcaArticulo.Name = "lblMarcaArticulo";
            this.lblMarcaArticulo.Padding = new System.Windows.Forms.Padding(5);
            this.lblMarcaArticulo.Size = new System.Drawing.Size(276, 30);
            this.lblMarcaArticulo.TabIndex = 2;
            this.lblMarcaArticulo.Text = "Marca: Travel";
            this.lblMarcaArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreArticulo.Location = new System.Drawing.Point(0, 30);
            this.lblNombreArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Padding = new System.Windows.Forms.Padding(5);
            this.lblNombreArticulo.Size = new System.Drawing.Size(276, 30);
            this.lblNombreArticulo.TabIndex = 1;
            this.lblNombreArticulo.Text = "Nombre: Mochila Campus";
            this.lblNombreArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoArticulo.Location = new System.Drawing.Point(0, 0);
            this.lblCodigoArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Padding = new System.Windows.Forms.Padding(5);
            this.lblCodigoArticulo.Size = new System.Drawing.Size(276, 30);
            this.lblCodigoArticulo.TabIndex = 0;
            this.lblCodigoArticulo.Text = "Código: ART-001";
            this.lblCodigoArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(0, 155);
            this.lblDescripcionArticulo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Padding = new System.Windows.Forms.Padding(5);
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(276, 61);
            this.lblDescripcionArticulo.TabIndex = 5;
            this.lblDescripcionArticulo.Text = "Descripción: Mochila resistente con compartimentos múltiples, ideal para estudian" +
    "tes";
            // 
            // tlpImagenArticulo
            // 
            this.tlpImagenArticulo.BackColor = System.Drawing.Color.Transparent;
            this.tlpImagenArticulo.ColumnCount = 1;
            this.tlpImagenArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImagenArticulo.Controls.Add(this.pbImagenArticulo, 0, 0);
            this.tlpImagenArticulo.Controls.Add(this.tlpNavegacionImagenArticulo, 0, 1);
            this.tlpImagenArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpImagenArticulo.Location = new System.Drawing.Point(10, 10);
            this.tlpImagenArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpImagenArticulo.Name = "tlpImagenArticulo";
            this.tlpImagenArticulo.RowCount = 2;
            this.tlpImagenArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpImagenArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpImagenArticulo.Size = new System.Drawing.Size(276, 194);
            this.tlpImagenArticulo.TabIndex = 0;
            // 
            // pbImagenArticulo
            // 
            this.pbImagenArticulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbImagenArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagenArticulo.Location = new System.Drawing.Point(0, 0);
            this.pbImagenArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.pbImagenArticulo.Name = "pbImagenArticulo";
            this.pbImagenArticulo.Size = new System.Drawing.Size(276, 150);
            this.pbImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenArticulo.TabIndex = 0;
            this.pbImagenArticulo.TabStop = false;
            // 
            // tlpNavegacionImagenArticulo
            // 
            this.tlpNavegacionImagenArticulo.ColumnCount = 3;
            this.tlpNavegacionImagenArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpNavegacionImagenArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavegacionImagenArticulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpNavegacionImagenArticulo.Controls.Add(this.btnImagenAnterior, 0, 0);
            this.tlpNavegacionImagenArticulo.Controls.Add(this.btnImagenSiguiente, 2, 0);
            this.tlpNavegacionImagenArticulo.Controls.Add(this.lblIndiceImagen, 1, 0);
            this.tlpNavegacionImagenArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavegacionImagenArticulo.Location = new System.Drawing.Point(0, 150);
            this.tlpNavegacionImagenArticulo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNavegacionImagenArticulo.Name = "tlpNavegacionImagenArticulo";
            this.tlpNavegacionImagenArticulo.RowCount = 1;
            this.tlpNavegacionImagenArticulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavegacionImagenArticulo.Size = new System.Drawing.Size(276, 44);
            this.tlpNavegacionImagenArticulo.TabIndex = 1;
            this.tlpNavegacionImagenArticulo.Visible = false;
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
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Location = new System.Drawing.Point(241, 5);
            this.btnImagenSiguiente.Margin = new System.Windows.Forms.Padding(5);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(30, 30);
            this.btnImagenSiguiente.TabIndex = 1;
            this.btnImagenSiguiente.Text = "→";
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // lblIndiceImagen
            // 
            this.lblIndiceImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIndiceImagen.Location = new System.Drawing.Point(45, 5);
            this.lblIndiceImagen.Margin = new System.Windows.Forms.Padding(5);
            this.lblIndiceImagen.Name = "lblIndiceImagen";
            this.lblIndiceImagen.Size = new System.Drawing.Size(186, 34);
            this.lblIndiceImagen.TabIndex = 2;
            this.lblIndiceImagen.Text = "1 / N";
            this.lblIndiceImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tlpArticulos);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCArticulos";
            this.Size = new System.Drawing.Size(1031, 891);
            this.Load += new System.EventHandler(this.UCArticulos_Load);
            this.tlpArticulos.ResumeLayout(false);
            this.tlpArticulos.PerformLayout();
            this.tlpFiltrosArticulo.ResumeLayout(false);
            this.tlpFiltrosArticulo.PerformLayout();
            this.flpBotonesFiltrosArticulo.ResumeLayout(false);
            this.tlpListadoArticulo.ResumeLayout(false);
            this.tlpEncabezadoListadoArticulo.ResumeLayout(false);
            this.tlpEncabezadoListadoArticulo.PerformLayout();
            this.flpBotonesArticulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.panelDetalleArticulo.ResumeLayout(false);
            this.tlpDatosArticulo.ResumeLayout(false);
            this.tlpDatosArticulo.PerformLayout();
            this.tlpImagenArticulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).EndInit();
            this.tlpNavegacionImagenArticulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpArticulos;
        private System.Windows.Forms.Label lblTituloArticulos;
        private System.Windows.Forms.TableLayoutPanel tlpFiltrosArticulo;
        private System.Windows.Forms.Label lblCampoArticulo;
        private System.Windows.Forms.Label lblCriterioArticulo;
        private System.Windows.Forms.Label lblValorArticulo;
        private System.Windows.Forms.ComboBox cmbCampoArticulo;
        private System.Windows.Forms.ComboBox cmbCriterioArticulo;
        private System.Windows.Forms.TextBox txtValorArticulo;
        private System.Windows.Forms.FlowLayoutPanel flpBotonesFiltrosArticulo;
        private System.Windows.Forms.Button btnLimpiarFiltrosArticulo;
        private System.Windows.Forms.Button btnAplicarFiltrosArticulo;
        private System.Windows.Forms.TableLayoutPanel tlpListadoArticulo;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezadoListadoArticulo;
        private System.Windows.Forms.FlowLayoutPanel flpBotonesArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnEditarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Label lblListadoArticulos;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Panel panelDetalleArticulo;
        private System.Windows.Forms.TableLayoutPanel tlpImagenArticulo;
        private System.Windows.Forms.TableLayoutPanel tlpNavegacionImagenArticulo;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.Label lblIndiceImagen;
        private System.Windows.Forms.TableLayoutPanel tlpDatosArticulo;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.Label lblMarcaArticulo;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.PictureBox pbImagenArticulo;
    }
}
