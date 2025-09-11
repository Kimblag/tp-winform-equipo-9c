using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoArticulos.Negocio
{
    public class ImagenNegocio
    {
        public void guardar(int idArticulo, List<string> urls)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                foreach (string url in urls)
                {

                    datos.DefinirConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");

                    datos.setearParametro("@IdArticulo", idArticulo);
                    datos.setearParametro("@ImagenUrl", url);
                    datos.EjecutarAccion();

                    // limpia los parametros, porque en cada vuelta se estaban acumulando y daba error porque ya existia un parametro con el mismo nombre
                    datos.LimpiarParametros();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
