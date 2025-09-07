namespace CatalogoArticulos.UI.Formularios.Categorias
{
    partial class UCCategorias
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
            this.txtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.tlpBuscarMarca = new System.Windows.Forms.TableLayoutPanel();
            this.lblBuscarCategoria = new System.Windows.Forms.Label();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.tlpListadoMarcas = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEncabezadoListado = new System.Windows.Forms.TableLayoutPanel();
            this.lblListadoCategoria = new System.Windows.Forms.Label();
            this.flpBotonesAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.lblOrdenarCategoria = new System.Windows.Forms.Label();
            this.cmbOrdenarCategoria = new System.Windows.Forms.ComboBox();
            this.tlpOrdenarCategoria = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpiarFiltrosCategoria = new System.Windows.Forms.Button();
            this.btnAplicarFiltrosCategoria = new System.Windows.Forms.Button();
            this.tlpBotonesFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.panelBotonesFiltros = new System.Windows.Forms.Panel();
            this.tlpFiltrosMarca = new System.Windows.Forms.TableLayoutPanel();
            this.tlpContenedorCategoria = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBuscarMarca.SuspendLayout();
            this.tlpListadoMarcas.SuspendLayout();
            this.tlpEncabezadoListado.SuspendLayout();
            this.flpBotonesAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.tlpOrdenarCategoria.SuspendLayout();
            this.tlpBotonesFiltros.SuspendLayout();
            this.panelBotonesFiltros.SuspendLayout();
            this.tlpFiltrosMarca.SuspendLayout();
            this.tlpContenedorCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.BackColor = System.Drawing.Color.White;
            this.txtBuscarCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBuscarCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarCategoria.Location = new System.Drawing.Point(0, 25);
            this.txtBuscarCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.txtBuscarCategoria.MaxLength = 50;
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(250, 25);
            this.txtBuscarCategoria.TabIndex = 1;
            // 
            // tlpBuscarMarca
            // 
            this.tlpBuscarMarca.AutoSize = true;
            this.tlpBuscarMarca.BackColor = System.Drawing.Color.Transparent;
            this.tlpBuscarMarca.ColumnCount = 1;
            this.tlpBuscarMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBuscarMarca.Controls.Add(this.lblBuscarCategoria, 0, 0);
            this.tlpBuscarMarca.Controls.Add(this.txtBuscarCategoria, 0, 1);
            this.tlpBuscarMarca.Location = new System.Drawing.Point(20, 10);
            this.tlpBuscarMarca.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tlpBuscarMarca.Name = "tlpBuscarMarca";
            this.tlpBuscarMarca.RowCount = 2;
            this.tlpBuscarMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBuscarMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBuscarMarca.Size = new System.Drawing.Size(250, 55);
            this.tlpBuscarMarca.TabIndex = 6;
            // 
            // lblBuscarCategoria
            // 
            this.lblBuscarCategoria.AutoSize = true;
            this.lblBuscarCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBuscarCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBuscarCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarCategoria.Location = new System.Drawing.Point(0, 0);
            this.lblBuscarCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.lblBuscarCategoria.Name = "lblBuscarCategoria";
            this.lblBuscarCategoria.Size = new System.Drawing.Size(250, 17);
            this.lblBuscarCategoria.TabIndex = 0;
            this.lblBuscarCategoria.Text = "Buscar por nombre";
            this.lblBuscarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCategoria.Location = new System.Drawing.Point(10, 10);
            this.lblTituloCategoria.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(1179, 21);
            this.lblTituloCategoria.TabIndex = 0;
            this.lblTituloCategoria.Text = "Gestión de categorías";
            this.lblTituloCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpListadoMarcas
            // 
            this.tlpListadoMarcas.ColumnCount = 1;
            this.tlpListadoMarcas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListadoMarcas.Controls.Add(this.tlpEncabezadoListado, 0, 0);
            this.tlpListadoMarcas.Controls.Add(this.dgvCategoria, 0, 1);
            this.tlpListadoMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListadoMarcas.Location = new System.Drawing.Point(13, 144);
            this.tlpListadoMarcas.Name = "tlpListadoMarcas";
            this.tlpListadoMarcas.Padding = new System.Windows.Forms.Padding(10);
            this.tlpListadoMarcas.RowCount = 2;
            this.tlpListadoMarcas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpListadoMarcas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListadoMarcas.Size = new System.Drawing.Size(1173, 481);
            this.tlpListadoMarcas.TabIndex = 2;
            // 
            // tlpEncabezadoListado
            // 
            this.tlpEncabezadoListado.AutoSize = true;
            this.tlpEncabezadoListado.ColumnCount = 2;
            this.tlpEncabezadoListado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezadoListado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEncabezadoListado.Controls.Add(this.lblListadoCategoria, 0, 0);
            this.tlpEncabezadoListado.Controls.Add(this.flpBotonesAcciones, 1, 0);
            this.tlpEncabezadoListado.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEncabezadoListado.Location = new System.Drawing.Point(10, 10);
            this.tlpEncabezadoListado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tlpEncabezadoListado.Name = "tlpEncabezadoListado";
            this.tlpEncabezadoListado.RowCount = 1;
            this.tlpEncabezadoListado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezadoListado.Size = new System.Drawing.Size(1153, 40);
            this.tlpEncabezadoListado.TabIndex = 0;
            // 
            // lblListadoCategoria
            // 
            this.lblListadoCategoria.AutoSize = true;
            this.lblListadoCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListadoCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblListadoCategoria.Location = new System.Drawing.Point(3, 0);
            this.lblListadoCategoria.Name = "lblListadoCategoria";
            this.lblListadoCategoria.Size = new System.Drawing.Size(847, 40);
            this.lblListadoCategoria.TabIndex = 0;
            this.lblListadoCategoria.Text = "Listado de categorías";
            this.lblListadoCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpBotonesAcciones
            // 
            this.flpBotonesAcciones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flpBotonesAcciones.AutoSize = true;
            this.flpBotonesAcciones.BackColor = System.Drawing.Color.Transparent;
            this.flpBotonesAcciones.Controls.Add(this.btnAgregarCategoria);
            this.flpBotonesAcciones.Controls.Add(this.btnEditarCategoria);
            this.flpBotonesAcciones.Controls.Add(this.btnEliminarCategoria);
            this.flpBotonesAcciones.Location = new System.Drawing.Point(853, 0);
            this.flpBotonesAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpBotonesAcciones.Name = "flpBotonesAcciones";
            this.flpBotonesAcciones.Size = new System.Drawing.Size(300, 40);
            this.flpBotonesAcciones.TabIndex = 1;
            this.flpBotonesAcciones.WrapContents = false;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAgregarCategoria.Location = new System.Drawing.Point(5, 5);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(90, 30);
            this.btnAgregarCategoria.TabIndex = 0;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditarCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEditarCategoria.Location = new System.Drawing.Point(105, 5);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(90, 30);
            this.btnEditarCategoria.TabIndex = 1;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = false;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEliminarCategoria.Location = new System.Drawing.Point(205, 5);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(90, 30);
            this.btnEliminarCategoria.TabIndex = 2;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategoria.GridColor = System.Drawing.Color.LightGray;
            this.dgvCategoria.Location = new System.Drawing.Point(13, 63);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.RowTemplate.Height = 28;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(1147, 405);
            this.dgvCategoria.TabIndex = 1;
            // 
            // lblOrdenarCategoria
            // 
            this.lblOrdenarCategoria.AutoSize = true;
            this.lblOrdenarCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblOrdenarCategoria.Location = new System.Drawing.Point(0, 0);
            this.lblOrdenarCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.lblOrdenarCategoria.Name = "lblOrdenarCategoria";
            this.lblOrdenarCategoria.Size = new System.Drawing.Size(82, 17);
            this.lblOrdenarCategoria.TabIndex = 2;
            this.lblOrdenarCategoria.Text = "Ordenar por";
            this.lblOrdenarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOrdenarCategoria
            // 
            this.cmbOrdenarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenarCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbOrdenarCategoria.FormattingEnabled = true;
            this.cmbOrdenarCategoria.Items.AddRange(new object[] {
            "Sin ordenar",
            "Nombre (A-Z)",
            "Nombre (Z-A)"});
            this.cmbOrdenarCategoria.Location = new System.Drawing.Point(0, 25);
            this.cmbOrdenarCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.cmbOrdenarCategoria.Name = "cmbOrdenarCategoria";
            this.cmbOrdenarCategoria.Size = new System.Drawing.Size(250, 25);
            this.cmbOrdenarCategoria.TabIndex = 3;
            // 
            // tlpOrdenarCategoria
            // 
            this.tlpOrdenarCategoria.AutoSize = true;
            this.tlpOrdenarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.tlpOrdenarCategoria.ColumnCount = 1;
            this.tlpOrdenarCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrdenarCategoria.Controls.Add(this.lblOrdenarCategoria, 0, 0);
            this.tlpOrdenarCategoria.Controls.Add(this.cmbOrdenarCategoria, 0, 1);
            this.tlpOrdenarCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tlpOrdenarCategoria.Location = new System.Drawing.Point(290, 10);
            this.tlpOrdenarCategoria.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tlpOrdenarCategoria.Name = "tlpOrdenarCategoria";
            this.tlpOrdenarCategoria.RowCount = 2;
            this.tlpOrdenarCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOrdenarCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOrdenarCategoria.Size = new System.Drawing.Size(250, 55);
            this.tlpOrdenarCategoria.TabIndex = 7;
            // 
            // btnLimpiarFiltrosCategoria
            // 
            this.btnLimpiarFiltrosCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarFiltrosCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLimpiarFiltrosCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarFiltrosCategoria.Location = new System.Drawing.Point(129, 3);
            this.btnLimpiarFiltrosCategoria.Name = "btnLimpiarFiltrosCategoria";
            this.btnLimpiarFiltrosCategoria.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiarFiltrosCategoria.TabIndex = 5;
            this.btnLimpiarFiltrosCategoria.Text = "Limpiar filtros";
            this.btnLimpiarFiltrosCategoria.UseVisualStyleBackColor = false;
            // 
            // btnAplicarFiltrosCategoria
            // 
            this.btnAplicarFiltrosCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.btnAplicarFiltrosCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAplicarFiltrosCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnAplicarFiltrosCategoria.Location = new System.Drawing.Point(3, 3);
            this.btnAplicarFiltrosCategoria.Name = "btnAplicarFiltrosCategoria";
            this.btnAplicarFiltrosCategoria.Size = new System.Drawing.Size(120, 30);
            this.btnAplicarFiltrosCategoria.TabIndex = 4;
            this.btnAplicarFiltrosCategoria.Text = "Aplicar filtros";
            this.btnAplicarFiltrosCategoria.UseVisualStyleBackColor = false;
            // 
            // tlpBotonesFiltros
            // 
            this.tlpBotonesFiltros.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tlpBotonesFiltros.AutoSize = true;
            this.tlpBotonesFiltros.ColumnCount = 2;
            this.tlpBotonesFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesFiltros.Controls.Add(this.btnLimpiarFiltrosCategoria, 1, 0);
            this.tlpBotonesFiltros.Controls.Add(this.btnAplicarFiltrosCategoria, 0, 0);
            this.tlpBotonesFiltros.Location = new System.Drawing.Point(354, 18);
            this.tlpBotonesFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotonesFiltros.Name = "tlpBotonesFiltros";
            this.tlpBotonesFiltros.RowCount = 1;
            this.tlpBotonesFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesFiltros.Size = new System.Drawing.Size(252, 36);
            this.tlpBotonesFiltros.TabIndex = 0;
            // 
            // panelBotonesFiltros
            // 
            this.panelBotonesFiltros.BackColor = System.Drawing.Color.Transparent;
            this.panelBotonesFiltros.Controls.Add(this.tlpBotonesFiltros);
            this.panelBotonesFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotonesFiltros.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panelBotonesFiltros.Location = new System.Drawing.Point(550, 10);
            this.panelBotonesFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.panelBotonesFiltros.Name = "panelBotonesFiltros";
            this.panelBotonesFiltros.Size = new System.Drawing.Size(619, 70);
            this.panelBotonesFiltros.TabIndex = 8;
            // 
            // tlpFiltrosMarca
            // 
            this.tlpFiltrosMarca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlpFiltrosMarca.ColumnCount = 3;
            this.tlpFiltrosMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltrosMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltrosMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltrosMarca.Controls.Add(this.panelBotonesFiltros, 2, 0);
            this.tlpFiltrosMarca.Controls.Add(this.tlpOrdenarCategoria, 1, 0);
            this.tlpFiltrosMarca.Controls.Add(this.tlpBuscarMarca, 0, 0);
            this.tlpFiltrosMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpFiltrosMarca.Location = new System.Drawing.Point(10, 41);
            this.tlpFiltrosMarca.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tlpFiltrosMarca.Name = "tlpFiltrosMarca";
            this.tlpFiltrosMarca.Padding = new System.Windows.Forms.Padding(10);
            this.tlpFiltrosMarca.RowCount = 1;
            this.tlpFiltrosMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltrosMarca.Size = new System.Drawing.Size(1179, 90);
            this.tlpFiltrosMarca.TabIndex = 3;
            // 
            // tlpContenedorCategoria
            // 
            this.tlpContenedorCategoria.ColumnCount = 1;
            this.tlpContenedorCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenedorCategoria.Controls.Add(this.lblTituloCategoria, 0, 0);
            this.tlpContenedorCategoria.Controls.Add(this.tlpListadoMarcas, 0, 2);
            this.tlpContenedorCategoria.Controls.Add(this.tlpFiltrosMarca, 0, 1);
            this.tlpContenedorCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedorCategoria.Location = new System.Drawing.Point(0, 0);
            this.tlpContenedorCategoria.Name = "tlpContenedorCategoria";
            this.tlpContenedorCategoria.Padding = new System.Windows.Forms.Padding(10);
            this.tlpContenedorCategoria.RowCount = 3;
            this.tlpContenedorCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedorCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpContenedorCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenedorCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedorCategoria.Size = new System.Drawing.Size(1199, 638);
            this.tlpContenedorCategoria.TabIndex = 1;
            // 
            // UCCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpContenedorCategoria);
            this.Name = "UCCategorias";
            this.Size = new System.Drawing.Size(1199, 638);
            this.tlpBuscarMarca.ResumeLayout(false);
            this.tlpBuscarMarca.PerformLayout();
            this.tlpListadoMarcas.ResumeLayout(false);
            this.tlpListadoMarcas.PerformLayout();
            this.tlpEncabezadoListado.ResumeLayout(false);
            this.tlpEncabezadoListado.PerformLayout();
            this.flpBotonesAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.tlpOrdenarCategoria.ResumeLayout(false);
            this.tlpOrdenarCategoria.PerformLayout();
            this.tlpBotonesFiltros.ResumeLayout(false);
            this.panelBotonesFiltros.ResumeLayout(false);
            this.panelBotonesFiltros.PerformLayout();
            this.tlpFiltrosMarca.ResumeLayout(false);
            this.tlpFiltrosMarca.PerformLayout();
            this.tlpContenedorCategoria.ResumeLayout(false);
            this.tlpContenedorCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCategoria;
        private System.Windows.Forms.TableLayoutPanel tlpBuscarMarca;
        private System.Windows.Forms.Label lblBuscarCategoria;
        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.TableLayoutPanel tlpListadoMarcas;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezadoListado;
        private System.Windows.Forms.Label lblListadoCategoria;
        private System.Windows.Forms.FlowLayoutPanel flpBotonesAcciones;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Label lblOrdenarCategoria;
        private System.Windows.Forms.ComboBox cmbOrdenarCategoria;
        private System.Windows.Forms.TableLayoutPanel tlpOrdenarCategoria;
        private System.Windows.Forms.Button btnLimpiarFiltrosCategoria;
        private System.Windows.Forms.Button btnAplicarFiltrosCategoria;
        private System.Windows.Forms.TableLayoutPanel tlpBotonesFiltros;
        private System.Windows.Forms.Panel panelBotonesFiltros;
        private System.Windows.Forms.TableLayoutPanel tlpFiltrosMarca;
        private System.Windows.Forms.TableLayoutPanel tlpContenedorCategoria;
    }
}
