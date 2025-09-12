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

namespace CatalogoArticulos.UI.Formularios.Categorias
{
    public partial class FormCategoriaDetalle : Form
    {
        private Categoria categoriaEditar;

        public FormCategoriaDetalle(Categoria categoria)
        {
            InitializeComponent();
            categoriaEditar = categoria;
        }

        public FormCategoriaDetalle()
        {
            InitializeComponent();
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if (!ValidadorCampos.EsTextoValido(txtDescripcionCategoria.Text, 2, 50))
            {
                MessageBox.Show(
                    "La descripción debe tener entre 2 y 50 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string descripcion = txtDescripcionCategoria.Text.Trim();
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categoriaEditar == null)
                {

                    categoria.Descripcion = descripcion;
                    negocio.agregar(categoria);

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
                    categoriaEditar.Descripcion = descripcion;
                    negocio.modificar(categoriaEditar);

                    MessageBox.Show(
                        "Categoria modificada exitosamente.",
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

        private void FormCategoriaDetalle_Load(object sender, EventArgs e)
        {
            if (categoriaEditar != null)
            {
                txtDescripcionCategoria.Text = categoriaEditar.Descripcion;
                this.Text = "Editar categoria";
            }
            else
            {
                this.Text = "Nueva categoria";
            }
        }
    }
}
