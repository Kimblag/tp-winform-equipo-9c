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
            altaMarca.ShowDialog();
        }
    }
}
