namespace CatalogoArticulos.UI.Formularios.Categorias
{
    partial class FormCategoriaDetalle
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
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.tlpCategoriaDetalle = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.flpBotonesCategoria = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.tlpCategoriaDetalle.SuspendLayout();
            this.flpBotonesCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcionCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDescripcionCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(20, 20);
            this.lblDescripcionCategoria.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(408, 25);
            this.lblDescripcionCategoria.TabIndex = 0;
            this.lblDescripcionCategoria.Text = "Descripción de la categoría";
            this.lblDescripcionCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpCategoriaDetalle
            // 
            this.tlpCategoriaDetalle.BackColor = System.Drawing.Color.Transparent;
            this.tlpCategoriaDetalle.ColumnCount = 1;
            this.tlpCategoriaDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCategoriaDetalle.Controls.Add(this.lblDescripcionCategoria, 0, 0);
            this.tlpCategoriaDetalle.Controls.Add(this.txtDescripcionCategoria, 0, 1);
            this.tlpCategoriaDetalle.Controls.Add(this.flpBotonesCategoria, 0, 2);
            this.tlpCategoriaDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCategoriaDetalle.Location = new System.Drawing.Point(0, 0);
            this.tlpCategoriaDetalle.Name = "tlpCategoriaDetalle";
            this.tlpCategoriaDetalle.Padding = new System.Windows.Forms.Padding(20);
            this.tlpCategoriaDetalle.RowCount = 3;
            this.tlpCategoriaDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCategoriaDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpCategoriaDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCategoriaDetalle.Size = new System.Drawing.Size(448, 159);
            this.tlpCategoriaDetalle.TabIndex = 1;
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.BackColor = System.Drawing.Color.White;
            this.txtDescripcionCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescripcionCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDescripcionCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(20, 50);
            this.txtDescripcionCategoria.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtDescripcionCategoria.MaxLength = 50;
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(408, 25);
            this.txtDescripcionCategoria.TabIndex = 1;
            // 
            // flpBotonesCategoria
            // 
            this.flpBotonesCategoria.AutoSize = true;
            this.flpBotonesCategoria.Controls.Add(this.btnCancelarCategoria);
            this.flpBotonesCategoria.Controls.Add(this.btnGuardarCategoria);
            this.flpBotonesCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBotonesCategoria.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBotonesCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.flpBotonesCategoria.Location = new System.Drawing.Point(20, 90);
            this.flpBotonesCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.flpBotonesCategoria.Name = "flpBotonesCategoria";
            this.flpBotonesCategoria.Size = new System.Drawing.Size(408, 50);
            this.flpBotonesCategoria.TabIndex = 2;
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.Location = new System.Drawing.Point(303, 5);
            this.btnCancelarCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(100, 30);
            this.btnCancelarCategoria.TabIndex = 1;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Location = new System.Drawing.Point(193, 5);
            this.btnGuardarCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarCategoria.TabIndex = 0;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // FormCategoriaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 159);
            this.Controls.Add(this.tlpCategoriaDetalle);
            this.Name = "FormCategoriaDetalle";
            this.Text = "FormCategoriaDetalle";
            this.Load += new System.EventHandler(this.FormCategoriaDetalle_Load);
            this.tlpCategoriaDetalle.ResumeLayout(false);
            this.tlpCategoriaDetalle.PerformLayout();
            this.flpBotonesCategoria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.TableLayoutPanel tlpCategoriaDetalle;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.FlowLayoutPanel flpBotonesCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
    }
}