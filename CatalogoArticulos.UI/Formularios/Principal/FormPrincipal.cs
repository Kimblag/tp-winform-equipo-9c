using CatalogoArticulos.UI.Formularios.Marca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoArticulos.UI.Formularios.Principal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private UCMarcas vistaMarcas;

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            if (vistaMarcas == null)
                vistaMarcas = new UCMarcas();

            MostrarVista(vistaMarcas);
            MarcarBotonActivo(btnMarcas);
        }


        private void MostrarVista(UserControl vista)
        {
            // limpio la lista de controles que haya dentro del panel contenedor 
            panelContenido.Controls.Clear();
            vista.Dock = DockStyle.Fill; // le decimos que la vista se amoldará al control principal
            panelContenido.Controls.Add(vista); // aquí agrego la vista a la lista de controles del panel de contenido
        }

        private void MarcarBotonActivo(Button botonActivo)
        {
            // reseteamos primero los estilos de todos los botones
            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.LightGray;
                }
            }

            // marcamos el botón actual 
            botonActivo.BackColor = Color.WhiteSmoke;
        }
    }
}
