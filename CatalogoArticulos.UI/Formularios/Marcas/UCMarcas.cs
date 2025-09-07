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
    }
}
