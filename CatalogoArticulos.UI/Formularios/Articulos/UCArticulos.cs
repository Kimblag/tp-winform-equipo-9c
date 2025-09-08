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
    public partial class UCArticulos : UserControl
    {
        private List<Articulo> articulos = new List<Articulo>();
        private List<Imagen> imagenesActuales = new List<Imagen>();
        private int indiceImagenActual;

        public UCArticulos()
        {
            InitializeComponent();
        }

        private void UCArticulos_Load(object sender, EventArgs e)
        {
            CargarListadoArticulos();
        }

        private void CargarListadoArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                articulos = negocio.listar();
                dgvArticulos.DataSource = articulos;
                dgvArticulos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   "Ocurrió un error al cargar los artículos. Por favor, intentá nuevamente.",
                   "Error de carga",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null) return;

            Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            MostrarDetalleArticulo(articuloSeleccionado);
        }

        private void MostrarDetalleArticulo(Articulo articulo)
        {
            MostrarDatosArticulo(articulo);
            CargarImagenPrincipal(articulo);
            ActualizarNavegacionImagen(articulo);
        }

        private void MostrarDatosArticulo(Articulo articulo)
        {
            lblCodigoArticulo.Text = $"Código: {articulo.Codigo}";
            lblNombreArticulo.Text = $"Nombre: {articulo.Nombre}";
            lblMarcaArticulo.Text = $"Marca: {articulo.Marca?.Descripcion}";
            lblCategoriaArticulo.Text = $"Categoría: {articulo.Categoria?.Descripcion}";
            lblPrecioArticulo.Text = $"Precio: {articulo.Precio:N2}";
            lblDescripcionArticulo.Text = $"Descripción:\n{articulo.Descripcion}";
        }

        private void CargarImagenPrincipal(Articulo articulo)
        {
            imagenesActuales = articulo.Imagenes != null ? articulo.Imagenes : new List<Imagen>();
            indiceImagenActual = 0;

            string url = imagenesActuales.Count > 0 ? articulo.Imagenes[0].Url : null;

            try
            {
                if (!string.IsNullOrWhiteSpace(url))
                {
                    pbImagenArticulo.Load(url);
                } else
                {
                    // si no hay una url asignamos la imagen default desde la carpeta de recursos del proyecto
                    pbImagenArticulo.Image = Properties.Resources.imagenDefault;
                }
            }
            catch (Exception )
            {
                // si hay un error cargando la imagen url usamos la default
               pbImagenArticulo.Image = Properties.Resources.imagenDefault;
            }
        }

        private void ActualizarNavegacionImagen(Articulo articulo)
        {

            // si hay más de una imagen se muestra la navegación!
            bool tieneVariasImagenes = articulo.Imagenes != null && articulo.Imagenes.Count > 1;
            tlpNavegacionImagenArticulo.Visible = tieneVariasImagenes;

            // válido si tiene imagenes propias
            bool tieneImagenReal = articulo.Imagenes != null && articulo.Imagenes.Count > 0;
            if (tieneImagenReal)
            {
                lblIndiceImagen.Text = $"{indiceImagenActual + 1} / {articulo.Imagenes.Count}";
            } else
            {
                lblIndiceImagen.Text = "";
            }
        }


        private void MostrarImagenActual()
        {
            // v´álido si no hay imágenes, así asigno la default.
            if (imagenesActuales == null || imagenesActuales.Count == 0)
            {
                pbImagenArticulo.Image = Properties.Resources.imagenDefault;
                lblIndiceImagen.Text = "";
                return;
            }

            string url = imagenesActuales[indiceImagenActual].Url;
            try
            {
                pbImagenArticulo.Load(url);
            }
            catch (Exception)
            {
                pbImagenArticulo.Image = Properties.Resources.imagenDefault;
            }

            lblIndiceImagen.Text = $"{indiceImagenActual + 1} / {imagenesActuales.Count}";
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            if (imagenesActuales == null || imagenesActuales.Count <= 1)
                return;

            if (indiceImagenActual > 0)
            {
                indiceImagenActual--;
                MostrarImagenActual();
            }
        }

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenesActuales == null || imagenesActuales.Count <= 1)
                return;

            if (indiceImagenActual < imagenesActuales.Count - 1)
            {
                indiceImagenActual++;
                MostrarImagenActual();
            }
        }
    }
}
