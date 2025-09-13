using CatalogoArticulos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CatalogoArticulos.Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> marcas = new List<Marca>();

            AccesoDatos datos = new AccesoDatos();
            SqlDataReader lector;

            try
            {
                datos.DefinirConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.EjecutarConsulta();
                lector = datos.Lector;

                while (lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)lector["Id"];
                    marca.Descripcion = (string)lector["Descripcion"];

                    marcas.Add(marca);
                }

                return marcas;
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


        public void agregar(Marca nuevaMarca)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.DefinirConsulta($"INSERT INTO MARCAS (Descripcion) VALUES('{nuevaMarca.Descripcion}')");
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


        public void modificar(Marca marcaEditar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.DefinirConsulta($"UPDATE MARCAS SET Descripcion = '{marcaEditar.Descripcion}' WHERE Id = {marcaEditar.Id}");
                datos.EjecutarAccion();
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


        /*  public void eliminar(int idMarca)
          {
              AccesoDatos datos = new AccesoDatos();

              try
              {
                  datos.DefinirConsulta($"DELETE MARCAS WHERE Id = {idMarca}");
                  datos.EjecutarAccion();
              }
              catch (Exception ex)
              {
                  throw ex;
              }
              finally
              {
                  datos.CerrarConexion();
              }
          }*/
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                if (TieneArticulosAsociados(id))
                    throw new InvalidOperationException("No se puede eliminar la marca: tiene artículos asociados.");
                datos.DefinirConsulta($"DELETE FROM MARCAS WHERE Id = {id}");
                datos.EjecutarAccion();
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
        public bool TieneArticulosAsociados(int idMarca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT COUNT(*) AS Cant FROM ARTICULOS WHERE IdMarca = " + idMarca;
                datos.DefinirConsulta(consulta);
                datos.EjecutarConsulta();

                if (datos.Lector.Read())
                {
                    int cant = (int)datos.Lector["Cant"];
                    return cant > 0;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
