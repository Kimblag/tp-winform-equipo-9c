using CatalogoArticulos.Comun;
using CatalogoArticulos.Dominio.Entidades;
using CatalogoArticulos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoArticulos.UI.Formularios.Articulos
{
    public partial class FormArticuloAgregar : Form
    {
        private int indiceImagenActual = 0;
        private Articulo articuloEditar; 
        private List<Imagen> imagenesOriginales; // esto es una copia de las imágenes de un artículo a editar

        public FormArticuloAgregar()
        {
            InitializeComponent();
        }
        public FormArticuloAgregar(Articulo articulo)
        {
            InitializeComponent();
            articuloEditar = articulo;
            // este atributo servirá para comparar cuando editen lss imágenes
            imagenesOriginales = new List<Imagen>(articulo.Imagenes);
        }
     
        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            if (!validarCamposArtículo()) return;
            try
            {
                if (articuloEditar == null)
                    guardarNuevoArticulo();
                else
                    modificarArticuloExistente();

                MessageBox.Show(articuloEditar == null ? "Artículo guardado correctamente." : "Artículo modificado correctamente.",
                    articuloEditar == null ? "Alta" : "Edición",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                Close(); // Cierra el form después de agregar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormArticuloAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cmbMarcaArticulo.DataSource = marcaNegocio.listar();
                cmbMarcaArticulo.DisplayMember = "Descripcion";
                cmbMarcaArticulo.ValueMember = "Id";

                cmbCategoriaArticulo.DataSource = categoriaNegocio.listar();
                cmbCategoriaArticulo.DisplayMember = "Descripcion";
                cmbCategoriaArticulo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // si no hay una marca para editar
            if (articuloEditar == null)
            {
                CargaImagenDefaultInicial();
            } else
            {
                tbCodigoArticulo.Text = articuloEditar.Codigo;
                tbNombreArticulo.Text = articuloEditar.Nombre;
                if (!string.IsNullOrEmpty(articuloEditar.Descripcion))
                {
                    tbDescripcionArticulo.Text = articuloEditar.Descripcion;
                }
                tbPrecioArticulo.Text = articuloEditar.Precio.ToString();
                cmbMarcaArticulo.SelectedValue = articuloEditar.Marca.Id;
                cmbCategoriaArticulo.SelectedValue = articuloEditar.Categoria.Id;
                
                // validar si el artículo tiene imágenes
                if (articuloEditar.Imagenes.Count > 0)
                {
                    foreach (Imagen imagen in articuloEditar.Imagenes)
                    {
                        lstImagenesArticulo.Items.Add(imagen.Url);
                    }
                    MostrarImagenActual();
                }
            }
        }


        private void CargaImagenDefaultInicial()
        {
            // cargar imagen default
            pbPreviewImagenArticulo.Image = Properties.Resources.imagenDefault;
            lblIndiceImagen.Text = "0 / 0";
            btnImagenAnterior.Enabled = false;
            btnImagenSiguiente.Enabled = false;
            tlpNavegacionImagen.Visible = false;
        }

        private bool validarCamposArtículo()
        {
            bool esValido = true;
            errorProvider1.Clear();

            if (!ValidadorCampos.EsTextoValido(tbCodigoArticulo.Text, 1, 50))
            {
                errorProvider1.SetError(tbCodigoArticulo, "El código es obligatorio (mínimo 1 caracter, máximo 50).");
                esValido = false;
            }

            if (!ValidadorCampos.EsTextoValido(tbNombreArticulo.Text, 1, 50))
            {
                errorProvider1.SetError(tbNombreArticulo, "El nombre es obligatorio (mínimo 2 caracteres, máximo 50).");
                esValido = false;
            }

            if (!decimal.TryParse(tbPrecioArticulo.Text, out decimal precio) || precio < 0)
            {
                errorProvider1.SetError(tbPrecioArticulo, "Ingresá un precio válido.");
                esValido = false;
            }

            if (cmbMarcaArticulo.SelectedItem == null)
            {
                errorProvider1.SetError(cmbMarcaArticulo, "Seleccioná una marca.");
                esValido = false;
            }
            
            if (cmbCategoriaArticulo.SelectedItem == null)
            {
                errorProvider1.SetError(cmbCategoriaArticulo, "Seleccioná una categoría.");
                esValido = false;
            }

            // la descripción es opcional, pero igual validamos que tenga la longitud adecuada (igual están limitados los caracteres en el textbox)
            if (!string.IsNullOrWhiteSpace(tbDescripcionArticulo.Text) &&
            !ValidadorCampos.TieneLongitudMaxima(tbDescripcionArticulo.Text, 150))
                {
                    errorProvider1.SetError(tbDescripcionArticulo, "La descripción no debe superar los 150 caracteres.");
                    esValido = false;
                }

            return esValido;

        }

        private void btnAgregarImagenArticulo_Click(object sender, EventArgs e)
        {
            string url = tbUrlImagenArticulo.Text?.Trim();

            if (!ValidadorCampos.EsTextoObligatorio(url))
            {
                errorProvider1.SetError(tbUrlImagenArticulo, "La URL no puede estar vacía.");
                return;
            }

            // validar el formato de la url
            if (!ValidadorCampos.EsUrlDeImagen(url))
            {
                errorProvider1.SetError(tbUrlImagenArticulo, "La URL ingresada no tiene un formato válido. ");
                return;
            }

            // no permitir agregar urls duplicadas
            if (lstImagenesArticulo.Items.Contains(url))
            {
                errorProvider1.SetError(tbUrlImagenArticulo, "Esta imagen ya fue agregada al listado.");
                return;
            }

            lstImagenesArticulo.Items.Add(url);
            tbUrlImagenArticulo.Clear();
            errorProvider1.SetError(tbUrlImagenArticulo, "");

            indiceImagenActual = lstImagenesArticulo.Items.Count - 1;
            MostrarImagenActual();
        }


        private void MostrarImagenActual()
        {

            int total = lstImagenesArticulo.Items.Count;


            if (total == 0)
            {
                pbPreviewImagenArticulo.Image = Properties.Resources.imagenDefault;
                lblIndiceImagen.Text = "0 / 0";
                tlpNavegacionImagen.Visible = false;
                btnImagenAnterior.Enabled = false;
                btnImagenSiguiente.Enabled = false;
                return;
            }

            // esto es para asegurar que el índice este dentro del rango correcto. El índice comienza en 0, la cuenta en 1!!
            if (indiceImagenActual >= total)
            {
                indiceImagenActual = total - 1;
            }

            string url = lstImagenesArticulo.Items[indiceImagenActual].ToString();

            try
            {
                pbPreviewImagenArticulo.Load(url);
            }
            catch (Exception ex)
            {
                pbPreviewImagenArticulo.Image = Properties.Resources.imagenDefault;
            }

            lblIndiceImagen.Text = $"{indiceImagenActual + 1} / {total}";
            btnImagenAnterior.Enabled = indiceImagenActual > 0;
            btnImagenSiguiente.Enabled = indiceImagenActual < total - 1;
            tlpNavegacionImagen.Visible = total > 1;
            // esto es para que se seleccione la url a medida que se pasa con lso botones entre imágenes
            lstImagenesArticulo.SelectedIndex = indiceImagenActual; 

        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            if (indiceImagenActual > 0)
            {
                indiceImagenActual--;
                MostrarImagenActual();
            }
        }

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceImagenActual < lstImagenesArticulo.Items.Count - 1)
            {
                indiceImagenActual++;
                MostrarImagenActual();
            }
        }

        private void lstImagenesArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstImagenesArticulo.SelectedIndex >= 0)
            {
                indiceImagenActual = lstImagenesArticulo.SelectedIndex;
                MostrarImagenActual();
                btnEliminarImagenSeleccionada.Visible = true;
            }
        }

        private void btnEliminarImagenSeleccionada_Click(object sender, EventArgs e)
        {
            if (lstImagenesArticulo.SelectedIndex >= 0)
            {
                int indexAEliminar = lstImagenesArticulo.SelectedIndex;
                lstImagenesArticulo.Items.RemoveAt(indexAEliminar);

                // ahora hay que ajustar el indice de la imagen actual
                if (lstImagenesArticulo.Items.Count == 0)
                {
                    indiceImagenActual = 0;
                    btnEliminarImagenSeleccionada.Visible = false;
                }
                else if (indexAEliminar >= lstImagenesArticulo.Items.Count)
                {
                    indiceImagenActual = lstImagenesArticulo.Items.Count - 1;
                }
                else
                {
                    indiceImagenActual = indexAEliminar;
                }

                MostrarImagenActual();
            }
            else
            {
                MessageBox.Show(
                    "Seleccioná una imagen para eliminar.",
                    "Eliminar imagen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void guardarNuevoArticulo()
        {
            Articulo nuevo = construirArticuloDesdeFormulario();

            ArticuloNegocio negocio = new ArticuloNegocio();
            int idArticulo = negocio.agregar(nuevo);
            // agregar imagenes si existen
            List<string> urls = obtenerUrlsDesdeListBox();
            if (urls.Count > 0)
            {
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                imagenNegocio.guardar(idArticulo, urls);
            }
        }

        private void modificarArticuloExistente()
        {
            actualizarArticuloDesdeFormulario(articuloEditar);

            ArticuloNegocio negocio = new ArticuloNegocio();
            negocio.modificar(articuloEditar);

            List<string> urlsActuales = obtenerUrlsDesdeListBox();
            List<Imagen> imagenesEliminadas = obtenerImagenesEliminadas(urlsActuales);
            List<string> urlsNuevas = obtenerUrlsNuevas(urlsActuales);

            ImagenNegocio imagenNegocio = new ImagenNegocio();
            imagenNegocio.modificar(articuloEditar.Id, imagenesEliminadas, urlsNuevas);
        }


        private Articulo construirArticuloDesdeFormulario()
        {
            Articulo nuevo = new Articulo
            {
                Codigo = tbCodigoArticulo.Text.Trim(),
                Nombre = tbNombreArticulo.Text.Trim(),
                Descripcion = tbDescripcionArticulo.Text.Trim(),
                Marca = (Marca)cmbMarcaArticulo.SelectedItem,
                Categoria = (Categoria)cmbCategoriaArticulo.SelectedItem
            };

            decimal precio;
            if (decimal.TryParse(tbPrecioArticulo.Text.Trim(), out precio))
                nuevo.Precio = precio;
            else
                nuevo.Precio = 0;

            return nuevo;
        }


        private void actualizarArticuloDesdeFormulario(Articulo articuloEditar)
        {
            articuloEditar.Codigo = tbCodigoArticulo.Text;
            articuloEditar.Nombre = tbNombreArticulo.Text;
            articuloEditar.Descripcion = tbDescripcionArticulo.Text;
            articuloEditar.Marca = (Marca)cmbMarcaArticulo.SelectedItem;
            articuloEditar.Categoria = (Categoria)cmbCategoriaArticulo.SelectedItem;

            decimal precio;
            if (decimal.TryParse(tbPrecioArticulo.Text, out precio))
                articuloEditar.Precio = precio;
            else
                articuloEditar.Precio = 0;
        }


        private List<string> obtenerUrlsDesdeListBox()
        {
            List<string> urls = new List<string>();
            foreach (var item in lstImagenesArticulo.Items)
            {
                urls.Add((string)item);
            }
            return urls;
        }


        private List<Imagen> obtenerImagenesEliminadas(List<string> urlsActuales)
        {
            List<Imagen> eliminadas = new List<Imagen>();
            foreach (Imagen img in imagenesOriginales)
            {
                bool encontrada = false;
                foreach (string url in urlsActuales)
                {
                    if (img.Url == url)
                    {
                        encontrada = true;
                        break;
                    }
                }
                if (!encontrada)
                    eliminadas.Add(img);
            }
            return eliminadas;
        }

        private List<string> obtenerUrlsNuevas(List<string> urlsActuales)
        {
            List<string> urlsOriginales = new List<string>();
            foreach (Imagen img in imagenesOriginales)
            {
                urlsOriginales.Add(img.Url);
            }

            List<string> nuevas = new List<string>();
            foreach (string url in urlsActuales)
            {
                bool yaExiste = false;
                foreach (string original in urlsOriginales)
                {
                    if (url == original)
                    {
                        yaExiste = true;
                        break;
                    }
                }

                if (!yaExiste)
                    nuevas.Add(url);
            }

            return nuevas;
        }

    }
}
