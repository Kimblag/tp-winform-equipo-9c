using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoArticulos.Dominio.Entidades;

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

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.DefinirConsulta("DELETE FROM IMAGENES WHERE Id = @Id");
                datos.setearParametro("@Id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            } finally
            {
                datos.CerrarConexion();
            }

        }

        public void modificar(int idArticulo, List<Imagen> imagenesEliminadas, List<string> urlsNuevas)
        {
            try
            {
                if (urlsNuevas != null && urlsNuevas.Count > 0)
                {
                    guardar(idArticulo, urlsNuevas);
                }

                if (imagenesEliminadas != null && imagenesEliminadas.Count > 0)
                {
                    foreach (Imagen imagen in imagenesEliminadas)
                    {
                        eliminar(imagen.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
