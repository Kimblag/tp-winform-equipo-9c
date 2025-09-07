using CatalogoArticulos.Comun;
using CatalogoArticulos.Dominio.Entidades;
using CatalogoArticulos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoArticulos.UI.Formularios.Marcas
{
    public partial class FormMarcaDetalle : Form
    {
        private Marca marcaEditar;

        public FormMarcaDetalle(Marca marca)
        {
            InitializeComponent();
            marcaEditar = marca;
        }

        public FormMarcaDetalle()
        {
            InitializeComponent();
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            if (!ValidadorCampos.EsTextoValido(txtDescripcionMarca.Text, 2, 50))
            {
                MessageBox.Show(
                    "La descripción debe tener entre 2 y 50 caracteres.", 
                    "Validación", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            string descripcion = txtDescripcionMarca.Text.Trim();
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            
            try
            {
                if (marcaEditar == null)
                {

                marca.Descripcion = descripcion;
                negocio.agregar(marca);

                MessageBox.Show(
                    "Agregado exitosamente",
                    "Alta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                this.DialogResult = DialogResult.OK;
                } else
                {
                    marcaEditar.Descripcion = descripcion;
                    negocio.modificar(marcaEditar);

                    MessageBox.Show(
                        "Marca modificada exitosamente.",
                        "Edición", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormMarcaDetalle_Load(object sender, EventArgs e)
        {
            if (marcaEditar != null)
            {
                txtDescripcionMarca.Text = marcaEditar.Descripcion;
                this.Text = "Editar marca";
            } else
            {
                this.Text = "Nueva marca";
            }
        }
    }
}
