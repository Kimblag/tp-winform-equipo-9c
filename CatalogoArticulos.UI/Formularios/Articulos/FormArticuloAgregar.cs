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

        }

        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
