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

namespace CatalogoArticulos.UI.Formularios.Articulos
{
    public partial class FormArticuloDetalle : Form
    {
        private Articulo articuloEditar;
        public FormArticuloDetalle(Articulo articulo)
        {
            InitializeComponent();
            articuloEditar = articulo;
        }
        public FormArticuloDetalle()
        {
            InitializeComponent();

        }

        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {

            if (!ValidadorCampos.EsTextoValido(txtCodigoArticulo.Text, 3, 3))
            {
                MessageBox.Show(
                    "El codigo  debe ser de 3 caracteres",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string codigo = txtCodigoArticulo.Text?.Trim();
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articuloEditar == null)
                {

                    articulo.Codigo = codigo;
                    negocio.agregar(articulo);

                    MessageBox.Show(
                        "Agregado exitosamente",
                        "Alta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    articuloEditar.Codigo = codigo;
                    negocio.modificar(articuloEditar);

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

    
    }
}
