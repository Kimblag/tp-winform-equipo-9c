namespace CatalogoArticulos.UI.Formularios.Marcas
{
    partial class FormMarcaDetalle
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
            this.tlpMarcaDetalle = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.flpBotonesMarca = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.tlpMarcaDetalle.SuspendLayout();
            this.flpBotonesMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMarcaDetalle
            // 
            this.tlpMarcaDetalle.BackColor = System.Drawing.Color.Transparent;
            this.tlpMarcaDetalle.ColumnCount = 1;
            this.tlpMarcaDetalle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMarcaDetalle.Controls.Add(this.lblDescripcionMarca, 0, 0);
            this.tlpMarcaDetalle.Controls.Add(this.txtDescripcionMarca, 0, 1);
            this.tlpMarcaDetalle.Controls.Add(this.flpBotonesMarca, 0, 2);
            this.tlpMarcaDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMarcaDetalle.Location = new System.Drawing.Point(0, 0);
            this.tlpMarcaDetalle.Name = "tlpMarcaDetalle";
            this.tlpMarcaDetalle.Padding = new System.Windows.Forms.Padding(20);
            this.tlpMarcaDetalle.RowCount = 3;
            this.tlpMarcaDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMarcaDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMarcaDetalle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMarcaDetalle.Size = new System.Drawing.Size(448, 159);
            this.tlpMarcaDetalle.TabIndex = 0;
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescripcionMarca.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcionMarca.Location = new System.Drawing.Point(20, 20);
            this.lblDescripcionMarca.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(408, 25);
            this.lblDescripcionMarca.TabIndex = 0;
            this.lblDescripcionMarca.Text = "Descripción de la marca";
            this.lblDescripcionMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.BackColor = System.Drawing.Color.White;
            this.txtDescripcionMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescripcionMarca.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcionMarca.Location = new System.Drawing.Point(20, 50);
            this.txtDescripcionMarca.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtDescripcionMarca.MaxLength = 50;
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(408, 25);
            this.txtDescripcionMarca.TabIndex = 1;
            // 
            // flpBotonesMarca
            // 
            this.flpBotonesMarca.AutoSize = true;
            this.flpBotonesMarca.Controls.Add(this.btnCancelarMarca);
            this.flpBotonesMarca.Controls.Add(this.btnGuardarMarca);
            this.flpBotonesMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBotonesMarca.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBotonesMarca.Location = new System.Drawing.Point(20, 90);
            this.flpBotonesMarca.Margin = new System.Windows.Forms.Padding(0);
            this.flpBotonesMarca.Name = "flpBotonesMarca";
            this.flpBotonesMarca.Size = new System.Drawing.Size(408, 50);
            this.flpBotonesMarca.TabIndex = 2;
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(303, 5);
            this.btnCancelarMarca.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(100, 30);
            this.btnCancelarMarca.TabIndex = 1;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Location = new System.Drawing.Point(193, 5);
            this.btnGuardarMarca.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarMarca.TabIndex = 0;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // FormMarcaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(448, 159);
            this.Controls.Add(this.tlpMarcaDetalle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMarcaDetalle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.FormMarcaDetalle_Load);
            this.tlpMarcaDetalle.ResumeLayout(false);
            this.tlpMarcaDetalle.PerformLayout();
            this.flpBotonesMarca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMarcaDetalle;
        private System.Windows.Forms.Label lblDescripcionMarca;
        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.FlowLayoutPanel flpBotonesMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
    }
}