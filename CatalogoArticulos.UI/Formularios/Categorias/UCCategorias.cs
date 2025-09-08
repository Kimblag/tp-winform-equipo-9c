using CatalogoArticulos.Dominio.Entidades;
using CatalogoArticulos.Negocio;
using CatalogoArticulos.UI.Formularios.Marcas;
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
        private List<Categoria> categorias;
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
            try
            {
                categorias = negocio.listar();
                dgvCategoria.DataSource = categorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   "Ocurrió un error al cargar las categorías. Por favor, intentá nuevamente.",
                   "Error de carga",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
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

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categoriaSeleccionada;
            try
            {
                DialogResult respuesta = MessageBox.Show("¡Atención! Se eliminará la categoría seleccionada. ¿Desea continuar?", "Eliminar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                categoriaSeleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                negocio.eliminar(categoriaSeleccionada.Id);
                CargarListadoCategorias();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       private void btnAplicarFiltrosCategoria_Click(object sender, EventArgs e)
        {
            aplicarFiltrosYOrden();
        }

        private void btnLimpiarFiltrosCategoria_Click(object sender, EventArgs e)
        {
            txtBuscarCategoria.Text = "";
            cmbOrdenarCategoria.SelectedIndex = 0;
            aplicarFiltrosYOrden();
        }

        private void txtBuscarCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                aplicarFiltrosYOrden();
                e.SuppressKeyPress = true;
            }
        }



        private void aplicarFiltrosYOrden()
        {
            string filtro = txtBuscarCategoria.Text?.Trim().ToUpper();
            string orden = cmbOrdenarCategoria.SelectedItem?.ToString();

            List<Categoria> categoriaFiltradas = categorias;

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                categoriaFiltradas = categoriaFiltradas.FindAll(categoria => categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }

            switch (orden)
            {
                case "Descripción (A-Z)":
                    categoriaFiltradas = categoriaFiltradas.OrderBy(categoria => categoria.Descripcion).ToList();
                    break;
                case "Descripción (Z-A)":
                    categoriaFiltradas = categoriaFiltradas.OrderByDescending(categoria => categoria.Descripcion).ToList();
                    break;
                case "Sin ordenar":
                default:
                    break;
            }

            dgvCategoria.DataSource = null;
            dgvCategoria.DataSource = categoriaFiltradas;
        }


    }

}
