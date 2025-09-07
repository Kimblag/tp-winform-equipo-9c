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
    public partial class UCCategorias : UserControl
    {
        public UCCategorias()
        {
            InitializeComponent();
            this.Load += UCCategorias_Load;
        }

        private void UCCategorias_Load(object sender, EventArgs e)
        {
            cmbOrdenarCategoria.SelectedIndex = 0;
            CargarListadoCategorias();
        }

        private void CargarListadoCategorias()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvCategoria.DataSource = negocio.listar();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FormCategoriaDetalle altaCategoria = new FormCategoriaDetalle();
            DialogResult resultado = altaCategoria.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CargarListadoCategorias();
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una categoria para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Categoria categoriaSeleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
            FormCategoriaDetalle frmCategoria = new FormCategoriaDetalle(categoriaSeleccionada);

            if (frmCategoria.ShowDialog() == DialogResult.OK)
            {
                CargarListadoCategorias();
            }
        }





    }

}
