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
    public partial class FormArticuloAgregar : Form
    {
        public FormArticuloAgregar()
        {
            InitializeComponent();
           
        }
     
        private void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                nuevo.Codigo = tbCodigoArticulo.Text;
                nuevo.Nombre = tbNombreArticulo.Text;
                nuevo.Descripcion = tbDescripcionArticulo.Text;

                // Convierte el precio a decimal
                decimal precio;
                if (decimal.TryParse(tbPrecioArticulo.Text, out precio))
                    nuevo.Precio = precio;
                else
                    nuevo.Precio = 0;

                // Marcas y categorías desde los combos
                nuevo.Marca = (Marca)cmbMarcaArticulo.SelectedItem;
                nuevo.Categoria = (Categoria)cmbCategoriaArticulo.SelectedItem;

                negocio.agregar(nuevo);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Artículo agregado correctamente.");
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
        }
    }
}
