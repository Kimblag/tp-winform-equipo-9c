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
        private List<string> camposTexto = new List<string> { "Codigo", "Nombre", "Descripcion" };
        private List<string> camposNumericos = new List<string> { "Precio" };
        private List<string> camposListados = new List<string> { "Marca", "Categoria" };


        public UCArticulos()
        {
            InitializeComponent();
        }

        private void UCArticulos_Load(object sender, EventArgs e)
        {
            CargarListadoArticulos();
            // engancho botones de filtros
            //btnAplicarFiltrosArticulo.Click += btnAplicarFiltrosArticulo_Click;
            //btnLimpiarFiltrosArticulo.Click += btnLimpiarFiltrosArticulo_Click;
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


        private void validarFiltros(string campo, string criterio, string valorTexto)
        {
            // validar si el campo o criterio están vacíos
            if (string.IsNullOrWhiteSpace(campo) || string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Seleccioná Campo y Criterio",
                    "Error al aplicar filtro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
                return;
            }
            // ver si es un campo que admite valores (no es marca o categoria)
            bool esCampoConValor = camposTexto.Contains(campo) || camposNumericos.Contains(campo);
            if (esCampoConValor && string.IsNullOrWhiteSpace(valorTexto))
            {
                MessageBox.Show("Debes ingresar un valor a buscar.",
                    "Error al aplicar filtro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
                return;
            }
        }

        private List<Articulo> FiltrarPorPrecio(string criterio, string valor)
        {
            decimal valorDecimal;
            if (!decimal.TryParse(valor, out valorDecimal))
            {
                MessageBox.Show("Ingresá un número válido para Precio.");
                return articulos;
            }
            switch (criterio)
            {
                case "Mayor que":
                    return articulos.Where(a => a.Precio > valorDecimal).ToList();
                case "Menor que":
                    return articulos.Where(a => a.Precio < valorDecimal).ToList();
                case "Igual que":
                    return articulos.Where(a => a.Precio == valorDecimal).ToList();
                default:
                    MessageBox.Show("Criterio no válido para Precio.");
                    return new List<Articulo>();
            }
        }


        private List<Articulo> FiltrarPorCodigo(string criterio, string valor)
        {
            valor = valor.ToUpper();

            switch (criterio)
            {
                case "Contiene":
                    return articulos.FindAll(a => a.Codigo.ToUpper().Contains(valor));
                case "Comienza con":
                    return articulos.FindAll(a => a.Codigo.ToUpper().StartsWith(valor));
                case "Termina con":
                    return articulos.FindAll(a => a.Codigo.ToUpper().EndsWith(valor));
                default:
                    MessageBox.Show("Criterio no válido.");
                    return new List<Articulo>();
            }
        }

        private List<Articulo> FiltrarPorNombre(string criterio, string valor)
        {
            valor = valor.ToUpper();

            switch (criterio)
            {
                case "Contiene":
                    return articulos.FindAll(a => a.Nombre.ToUpper().Contains(valor));
                case "Comienza con":
                    return articulos.FindAll(a => a.Nombre.ToUpper().StartsWith(valor));
                case "Termina con":
                    return articulos.FindAll(a => a.Nombre.ToUpper().EndsWith(valor));
                default:
                    MessageBox.Show("Criterio no válido.");
                    return new List<Articulo>();
            }
        }

        private void btnAplicarFiltrosArticulo_Click(object sender, EventArgs e)
        {
            string campo = cmbCampoArticulo.SelectedItem?.ToString();
            string criterio = cmbCriterioArticulo.SelectedItem?.ToString();
            string valorTexto = txtValorArticulo.Text.Trim();

            // validar si el campo o criterio están vacíos
            validarFiltros(campo, criterio, valorTexto);

            List<Articulo> resultado = new List<Articulo>();

            switch (campo)
            {
                case "Precio":
                    resultado = FiltrarPorPrecio(criterio, valorTexto);
                    break;
                case "Codigo":
                    resultado = FiltrarPorCodigo(criterio, valorTexto);
                    break;
                case "Nombre":
                    resultado = FiltrarPorNombre(criterio, valorTexto);
                    break;
                case "Marca":
                    resultado = articulos.FindAll(a => a.Marca.Descripcion.ToUpper().Contains(criterio.ToUpper()));
                    break;
                default:
                    MessageBox.Show("Campo no reconocido.");
                    return;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = resultado;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void btnLimpiarFiltrosArticulo_Click(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = articulos;
            dgvArticulos.Columns["Id"].Visible = false;
            cmbCampoArticulo.SelectedIndex = -1;
            cmbCriterioArticulo.SelectedIndex = -1;
            txtValorArticulo.Text = "";
        }

        private void cmbCampoArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cmbCampoArticulo.SelectedItem?.ToString();
            cmbCriterioArticulo.Items.Clear(); // se limpia porque dependiendo del campo el criterio varía
            txtValorArticulo.Visible = true;
            cmbCriterioArticulo.DropDownStyle = ComboBoxStyle.DropDownList;

            if (camposTexto.Contains(campo))
            {
                cmbCriterioArticulo.Items.AddRange(new string[] { "Contiene", "Comienza con", "Termina con" });
                txtValorArticulo.Enabled = true;

            } else if ( camposNumericos.Contains (campo))
            {
                cmbCriterioArticulo.Items.AddRange(new string[] { "Mayor que", "Menor que", "Igual que" });
                txtValorArticulo.Enabled = true;

            } else if (camposListados.Contains(campo))
            {
                txtValorArticulo.Enabled = false; // desactivo el txtbox porque ya damos le listado de marcas / categorías

                // extraemos las marcas o categorias de la bd y seleccionamos solo las descripciones.
                List<string> opciones = campo == "Marca"
                    ? new MarcaNegocio().listar().Select(marca => marca.Descripcion).ToList()
                    : new CategoriaNegocio().listar().Select(categoria => categoria.Descripcion).ToList();

                // cmo tenemos una lista, se debe convertir a una matriz para poder agregarla al rango de items del combobox
                cmbCriterioArticulo.Items.AddRange(opciones.ToArray());
            }

            // se setea al índice 0
            if (cmbCriterioArticulo.Items.Count > 0)
            {
                cmbCriterioArticulo.SelectedIndex = 0;
            }

        }
    }
}
