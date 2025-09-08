using CatalogoArticulos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CatalogoArticulos.Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> categorias = new List<Categoria>();

            AccesoDatos datos = new AccesoDatos();
            SqlDataReader lector;

            try
            {
                datos.DefinirConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.EjecutarConsulta();
                lector = datos.Lector;

                while (lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)lector["Id"];
                    categoria.Descripcion = (string)lector["Descripcion"];

                    categorias.Add(categoria);
                }

                return categorias;
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


        public void agregar(Categoria nuevaCategoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.DefinirConsulta($"INSERT INTO CATEGORIAS (Descripcion) VALUES('{nuevaCategoria.Descripcion}')");
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


        public void modificar(Categoria categoriaEditar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.DefinirConsulta($"UPDATE CATEGORIAS SET Descripcion = '{categoriaEditar.Descripcion}' WHERE Id = {categoriaEditar.Id}");
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

        public void eliminar(int id)
        {             AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.DefinirConsulta($"DELETE FROM CATEGORIAS WHERE Id = {id}");
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
    }
}
