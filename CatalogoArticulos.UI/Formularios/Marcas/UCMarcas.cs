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
    public partial class UCMarcas : UserControl
    {
        public UCMarcas()
        {
            InitializeComponent();
        }

        private void UCMarcas_Load(object sender, EventArgs e)
        {
            cmbOrdenarMarca.SelectedIndex = 0;
            CargarListadoMarcas();
        }

        private void CargarListadoMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = negocio.listar();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            FormMarcaDetalle altaMarca = new FormMarcaDetalle();
            DialogResult resultado = altaMarca.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CargarListadoMarcas();
            }
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una marca para editar.", 
                    "Aviso", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            Marca marcaSeleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            FormMarcaDetalle frmMarca = new FormMarcaDetalle(marcaSeleccionada);

            if (frmMarca.ShowDialog() == DialogResult.OK)
            {
                CargarListadoMarcas();
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una marca para eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            Marca marcaSeleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show(
                "¡Atención! Se eliminará la marca seleccionada. ¿Desea continuar?", 
                "Eliminar marca", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);


            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    MarcaNegocio negocio = new MarcaNegocio();
                    negocio.eliminar(marcaSeleccionada.Id);
                    MessageBox.Show("Marca eliminada correctamente.", 
                        "Eliminación", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    CargarListadoMarcas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar:\n" + ex.Message, 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }
        
    }
}
