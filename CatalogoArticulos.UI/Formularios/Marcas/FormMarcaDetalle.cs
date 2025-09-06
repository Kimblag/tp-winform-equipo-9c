using CatalogoArticulos.Comun;
using CatalogoArticulos.Dominio.Entidades;
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
    public partial class FormMarcaDetalle : Form
    {
        public FormMarcaDetalle()
        {
            InitializeComponent();
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            if (!ValidadorCampos.EsTextoValido(txtDescripcionMarca.Text, 2, 100))
            {
                MessageBox.Show(
                    "La descripción debe tener entre 2 y 50 caracteres.", 
                    "Validación", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            Marca marca = new Marca();

            
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
