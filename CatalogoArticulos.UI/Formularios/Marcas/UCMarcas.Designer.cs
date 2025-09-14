namespace CatalogoArticulos.UI.Formularios.Marcas
{
    partial class UCMarcas
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
            this.tlpContenedorMarcas = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloMarcas = new System.Windows.Forms.Label();
            this.tlpListadoMarcas = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEncabezadoListado = new System.Windows.Forms.TableLayoutPanel();
            this.lblListadoMarcas = new System.Windows.Forms.Label();
            this.flpBotonesAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.tlpFiltrosMarca = new System.Windows.Forms.TableLayoutPanel();
            this.panelBotonesFiltros = new System.Windows.Forms.Panel();
            this.tlpBotonesFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.btnLimpiarFiltrosMarca = new System.Windows.Forms.Button();
            this.btnAplicarFiltrosMarca = new System.Windows.Forms.Button();
            this.tlpOrdenarMarca = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrdenarMarca = new System.Windows.Forms.Label();
            this.cmbOrdenarMarca = new System.Windows.Forms.ComboBox();
            this.tlpBuscarMarca = new System.Windows.Forms.TableLayoutPanel();
            this.lblBuscarMarca = new System.Windows.Forms.Label();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.tlpContenedorMarcas.SuspendLayout();
            this.tlpListadoMarcas.SuspendLayout();
            this.tlpEncabezadoListado.SuspendLayout();
            this.flpBotonesAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.tlpFiltrosMarca.SuspendLayout();
            this.panelBotonesFiltros.SuspendLayout();
            this.tlpBotonesFiltros.SuspendLayout();
            this.tlpOrdenarMarca.SuspendLayout();
            this.tlpBuscarMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContenedorMarcas
            // 
            this.tlpContenedorMarcas.ColumnCount = 1;
            this.tlpContenedorMarcas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenedorMarcas.Controls.Add(this.lblTituloMarcas, 0, 0);
            this.tlpContenedorMarcas.Controls.Add(this.tlpListadoMarcas, 0, 2);
            this.tlpContenedorMarcas.Controls.Add(this.tlpFiltrosMarca, 0, 1);
            this.tlpContenedorMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedorMarcas.Location = new System.Drawing.Point(0, 0);
            this.tlpContenedorMarcas.Name = "tlpContenedorMarcas";
            this.tlpContenedorMarcas.Padding = new System.Windows.Forms.Padding(10);
            this.tlpContenedorMarcas.RowCount = 3;
            this.tlpContenedorMarcas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedorMarcas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpContenedorMarcas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContenedorMarcas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedorMarcas.Size = new System.Drawing.Size(1031, 891);
            this.tlpContenedorMarcas.TabIndex = 0;
            // 
            // lblTituloMarcas
            // 
            this.lblTituloMarcas.AutoSize = true;
            this.lblTituloMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloMarcas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMarcas.ForeColor = System.Drawing.Color.Black;
            this.lblTituloMarcas.Location = new System.Drawing.Point(10, 10);
            this.lblTituloMarcas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblTituloMarcas.Name = "lblTituloMarcas";
            this.lblTituloMarcas.Size = new System.Drawing.Size(1011, 21);
            this.lblTituloMarcas.TabIndex = 0;
            this.lblTituloMarcas.Text = "Gestión de marcas";
            this.lblTituloMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpListadoMarcas
            // 
            this.tlpListadoMarcas.ColumnCount = 1;
            this.tlpListadoMarcas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListadoMarcas.Controls.Add(this.tlpEncabezadoListado, 0, 0);
            this.tlpListadoMarcas.Controls.Add(this.dgvMarcas, 0, 1);
            this.tlpListadoMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListadoMarcas.Location = new System.Drawing.Point(13, 144);
            this.tlpListadoMarcas.Name = "tlpListadoMarcas";
            this.tlpListadoMarcas.Padding = new System.Windows.Forms.Padding(10);
            this.tlpListadoMarcas.RowCount = 2;
            this.tlpListadoMarcas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpListadoMarcas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListadoMarcas.Size = new System.Drawing.Size(1005, 734);
            this.tlpListadoMarcas.TabIndex = 2;
            // 
            // tlpEncabezadoListado
            // 
            this.tlpEncabezadoListado.AutoSize = true;
            this.tlpEncabezadoListado.ColumnCount = 2;
            this.tlpEncabezadoListado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezadoListado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEncabezadoListado.Controls.Add(this.lblListadoMarcas, 0, 0);
            this.tlpEncabezadoListado.Controls.Add(this.flpBotonesAcciones, 1, 0);
            this.tlpEncabezadoListado.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEncabezadoListado.Location = new System.Drawing.Point(10, 10);
            this.tlpEncabezadoListado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tlpEncabezadoListado.Name = "tlpEncabezadoListado";
            this.tlpEncabezadoListado.RowCount = 1;
            this.tlpEncabezadoListado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncabezadoListado.Size = new System.Drawing.Size(985, 40);
            this.tlpEncabezadoListado.TabIndex = 0;
            // 
            // lblListadoMarcas
            // 
            this.lblListadoMarcas.AutoSize = true;
            this.lblListadoMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListadoMarcas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoMarcas.ForeColor = System.Drawing.Color.Black;
            this.lblListadoMarcas.Location = new System.Drawing.Point(3, 0);
            this.lblListadoMarcas.Name = "lblListadoMarcas";
            this.lblListadoMarcas.Size = new System.Drawing.Size(679, 40);
            this.lblListadoMarcas.TabIndex = 0;
            this.lblListadoMarcas.Text = "Listado de marcas";
            this.lblListadoMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpBotonesAcciones
            // 
            this.flpBotonesAcciones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flpBotonesAcciones.AutoSize = true;
            this.flpBotonesAcciones.BackColor = System.Drawing.Color.Transparent;
            this.flpBotonesAcciones.Controls.Add(this.btnAgregarMarca);
            this.flpBotonesAcciones.Controls.Add(this.btnEditarMarca);
            this.flpBotonesAcciones.Controls.Add(this.btnEliminarMarca);
            this.flpBotonesAcciones.Location = new System.Drawing.Point(685, 0);
            this.flpBotonesAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.flpBotonesAcciones.Name = "flpBotonesAcciones";
            this.flpBotonesAcciones.Size = new System.Drawing.Size(300, 40);
            this.flpBotonesAcciones.TabIndex = 1;
            this.flpBotonesAcciones.WrapContents = false;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.SystemColors.Window;
            this.btnAgregarMarca.Location = new System.Drawing.Point(5, 5);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(90, 30);
            this.btnAgregarMarca.TabIndex = 0;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditarMarca.Location = new System.Drawing.Point(105, 5);
            this.btnEditarMarca.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(90, 30);
            this.btnEditarMarca.TabIndex = 1;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.UseVisualStyleBackColor = false;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarMarca.Location = new System.Drawing.Point(205, 5);
            this.btnEliminarMarca.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(90, 30);
            this.btnEliminarMarca.TabIndex = 2;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = false;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.AllowUserToResizeColumns = false;
            this.dgvMarcas.AllowUserToResizeRows = false;
            this.dgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.GridColor = System.Drawing.Color.LightGray;
            this.dgvMarcas.Location = new System.Drawing.Point(13, 63);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.RowTemplate.Height = 28;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(979, 658);
            this.dgvMarcas.TabIndex = 1;
            // 
            // tlpFiltrosMarca
            // 
            this.tlpFiltrosMarca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlpFiltrosMarca.ColumnCount = 3;
            this.tlpFiltrosMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltrosMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltrosMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltrosMarca.Controls.Add(this.panelBotonesFiltros, 2, 0);
            this.tlpFiltrosMarca.Controls.Add(this.tlpOrdenarMarca, 1, 0);
            this.tlpFiltrosMarca.Controls.Add(this.tlpBuscarMarca, 0, 0);
            this.tlpFiltrosMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpFiltrosMarca.Location = new System.Drawing.Point(10, 41);
            this.tlpFiltrosMarca.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tlpFiltrosMarca.Name = "tlpFiltrosMarca";
            this.tlpFiltrosMarca.Padding = new System.Windows.Forms.Padding(10);
            this.tlpFiltrosMarca.RowCount = 1;
            this.tlpFiltrosMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltrosMarca.Size = new System.Drawing.Size(1011, 90);
            this.tlpFiltrosMarca.TabIndex = 3;
            // 
            // panelBotonesFiltros
            // 
            this.panelBotonesFiltros.BackColor = System.Drawing.Color.Transparent;
            this.panelBotonesFiltros.Controls.Add(this.tlpBotonesFiltros);
            this.panelBotonesFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotonesFiltros.Location = new System.Drawing.Point(550, 10);
            this.panelBotonesFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.panelBotonesFiltros.Name = "panelBotonesFiltros";
            this.panelBotonesFiltros.Size = new System.Drawing.Size(451, 70);
            this.panelBotonesFiltros.TabIndex = 8;
            // 
            // tlpBotonesFiltros
            // 
            this.tlpBotonesFiltros.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tlpBotonesFiltros.AutoSize = true;
            this.tlpBotonesFiltros.ColumnCount = 2;
            this.tlpBotonesFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesFiltros.Controls.Add(this.btnLimpiarFiltrosMarca, 1, 0);
            this.tlpBotonesFiltros.Controls.Add(this.btnAplicarFiltrosMarca, 0, 0);
            this.tlpBotonesFiltros.Location = new System.Drawing.Point(186, 18);
            this.tlpBotonesFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBotonesFiltros.Name = "tlpBotonesFiltros";
            this.tlpBotonesFiltros.RowCount = 1;
            this.tlpBotonesFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotonesFiltros.Size = new System.Drawing.Size(252, 36);
            this.tlpBotonesFiltros.TabIndex = 0;
            // 
            // btnLimpiarFiltrosMarca
            // 
            this.btnLimpiarFiltrosMarca.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarFiltrosMarca.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarFiltrosMarca.Location = new System.Drawing.Point(129, 3);
            this.btnLimpiarFiltrosMarca.Name = "btnLimpiarFiltrosMarca";
            this.btnLimpiarFiltrosMarca.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiarFiltrosMarca.TabIndex = 1;
            this.btnLimpiarFiltrosMarca.Text = "Limpiar filtros";
            this.btnLimpiarFiltrosMarca.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltrosMarca.Click += new System.EventHandler(this.btnLimpiarFiltrosMarca_Click);
            // 
            // btnAplicarFiltrosMarca
            // 
            this.btnAplicarFiltrosMarca.BackColor = System.Drawing.SystemColors.Window;
            this.btnAplicarFiltrosMarca.ForeColor = System.Drawing.Color.Black;
            this.btnAplicarFiltrosMarca.Location = new System.Drawing.Point(3, 3);
            this.btnAplicarFiltrosMarca.Name = "btnAplicarFiltrosMarca";
            this.btnAplicarFiltrosMarca.Size = new System.Drawing.Size(120, 30);
            this.btnAplicarFiltrosMarca.TabIndex = 0;
            this.btnAplicarFiltrosMarca.Text = "Aplicar filtros";
            this.btnAplicarFiltrosMarca.UseVisualStyleBackColor = false;
            this.btnAplicarFiltrosMarca.Click += new System.EventHandler(this.btnAplicarFiltrosMarca_Click);
            // 
            // tlpOrdenarMarca
            // 
            this.tlpOrdenarMarca.AutoSize = true;
            this.tlpOrdenarMarca.BackColor = System.Drawing.Color.Transparent;
            this.tlpOrdenarMarca.ColumnCount = 1;
            this.tlpOrdenarMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrdenarMarca.Controls.Add(this.lblOrdenarMarca, 0, 0);
            this.tlpOrdenarMarca.Controls.Add(this.cmbOrdenarMarca, 0, 1);
            this.tlpOrdenarMarca.Location = new System.Drawing.Point(290, 10);
            this.tlpOrdenarMarca.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tlpOrdenarMarca.Name = "tlpOrdenarMarca";
            this.tlpOrdenarMarca.RowCount = 2;
            this.tlpOrdenarMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOrdenarMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOrdenarMarca.Size = new System.Drawing.Size(250, 55);
            this.tlpOrdenarMarca.TabIndex = 7;
            // 
            // lblOrdenarMarca
            // 
            this.lblOrdenarMarca.AutoSize = true;
            this.lblOrdenarMarca.ForeColor = System.Drawing.Color.Black;
            this.lblOrdenarMarca.Location = new System.Drawing.Point(0, 0);
            this.lblOrdenarMarca.Margin = new System.Windows.Forms.Padding(0);
            this.lblOrdenarMarca.Name = "lblOrdenarMarca";
            this.lblOrdenarMarca.Size = new System.Drawing.Size(82, 17);
            this.lblOrdenarMarca.TabIndex = 2;
            this.lblOrdenarMarca.Text = "Ordenar por";
            this.lblOrdenarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOrdenarMarca
            // 
            this.cmbOrdenarMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenarMarca.FormattingEnabled = true;
            this.cmbOrdenarMarca.Items.AddRange(new object[] {
            "Sin ordenar",
            "Descripción (A-Z)",
            "Descripción (Z-A)"});
            this.cmbOrdenarMarca.Location = new System.Drawing.Point(0, 25);
            this.cmbOrdenarMarca.Margin = new System.Windows.Forms.Padding(0);
            this.cmbOrdenarMarca.Name = "cmbOrdenarMarca";
            this.cmbOrdenarMarca.Size = new System.Drawing.Size(250, 25);
            this.cmbOrdenarMarca.TabIndex = 0;
            // 
            // tlpBuscarMarca
            // 
            this.tlpBuscarMarca.AutoSize = true;
            this.tlpBuscarMarca.BackColor = System.Drawing.Color.Transparent;
            this.tlpBuscarMarca.ColumnCount = 1;
            this.tlpBuscarMarca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBuscarMarca.Controls.Add(this.lblBuscarMarca, 0, 0);
            this.tlpBuscarMarca.Controls.Add(this.txtBuscarMarca, 0, 1);
            this.tlpBuscarMarca.Location = new System.Drawing.Point(20, 10);
            this.tlpBuscarMarca.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tlpBuscarMarca.Name = "tlpBuscarMarca";
            this.tlpBuscarMarca.RowCount = 2;
            this.tlpBuscarMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBuscarMarca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBuscarMarca.Size = new System.Drawing.Size(250, 55);
            this.tlpBuscarMarca.TabIndex = 6;
            // 
            // lblBuscarMarca
            // 
            this.lblBuscarMarca.AutoSize = true;
            this.lblBuscarMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBuscarMarca.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarMarca.Location = new System.Drawing.Point(0, 0);
            this.lblBuscarMarca.Margin = new System.Windows.Forms.Padding(0);
            this.lblBuscarMarca.Name = "lblBuscarMarca";
            this.lblBuscarMarca.Size = new System.Drawing.Size(250, 17);
            this.lblBuscarMarca.TabIndex = 0;
            this.lblBuscarMarca.Text = "Buscar por nombre";
            this.lblBuscarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.BackColor = System.Drawing.Color.White;
            this.txtBuscarMarca.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarMarca.Location = new System.Drawing.Point(0, 25);
            this.txtBuscarMarca.Margin = new System.Windows.Forms.Padding(0);
            this.txtBuscarMarca.MaxLength = 50;
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(250, 25);
            this.txtBuscarMarca.TabIndex = 0;
            this.txtBuscarMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMarca_KeyDown);
            // 
            // UCMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tlpContenedorMarcas);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCMarcas";
            this.Size = new System.Drawing.Size(1031, 891);
            this.Load += new System.EventHandler(this.UCMarcas_Load);
            this.tlpContenedorMarcas.ResumeLayout(false);
            this.tlpContenedorMarcas.PerformLayout();
            this.tlpListadoMarcas.ResumeLayout(false);
            this.tlpListadoMarcas.PerformLayout();
            this.tlpEncabezadoListado.ResumeLayout(false);
            this.tlpEncabezadoListado.PerformLayout();
            this.flpBotonesAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.tlpFiltrosMarca.ResumeLayout(false);
            this.tlpFiltrosMarca.PerformLayout();
            this.panelBotonesFiltros.ResumeLayout(false);
            this.panelBotonesFiltros.PerformLayout();
            this.tlpBotonesFiltros.ResumeLayout(false);
            this.tlpOrdenarMarca.ResumeLayout(false);
            this.tlpOrdenarMarca.PerformLayout();
            this.tlpBuscarMarca.ResumeLayout(false);
            this.tlpBuscarMarca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContenedorMarcas;
        private System.Windows.Forms.Label lblTituloMarcas;
        private System.Windows.Forms.Label lblBuscarMarca;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.Label lblOrdenarMarca;
        private System.Windows.Forms.ComboBox cmbOrdenarMarca;
        private System.Windows.Forms.Button btnAplicarFiltrosMarca;
        private System.Windows.Forms.TableLayoutPanel tlpBuscarMarca;
        private System.Windows.Forms.Button btnLimpiarFiltrosMarca;
        private System.Windows.Forms.TableLayoutPanel tlpOrdenarMarca;
        private System.Windows.Forms.Panel panelBotonesFiltros;
        private System.Windows.Forms.TableLayoutPanel tlpBotonesFiltros;
        private System.Windows.Forms.TableLayoutPanel tlpListadoMarcas;
        private System.Windows.Forms.TableLayoutPanel tlpEncabezadoListado;
        private System.Windows.Forms.Label lblListadoMarcas;
        private System.Windows.Forms.FlowLayoutPanel flpBotonesAcciones;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.TableLayoutPanel tlpFiltrosMarca;
    }
}
