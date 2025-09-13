using CatalogoArticulos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoArticulos.Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();

            AccesoDatos datos = new AccesoDatos();
            SqlDataReader lector;

            try
            {
        
            datos.DefinirConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Id IdMarca, M.Descripcion Marca, C.Id IdCategoria, C.Descripcion Categoria, I.Id ImagenId, I.ImagenUrl FROM ARTICULOS A JOIN MARCAS M ON A.IdMarca = M.Id JOIN CATEGORIAS C ON A.IdCategoria = C.Id LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo");
            datos.EjecutarConsulta();
            lector = datos.Lector;

            while (lector.Read())
            {
                int id = (int)lector["Id"];
                string url = lector["ImagenUrl"] != DBNull.Value ? (string)lector["ImagenUrl"] : null;


                // primero busco si ya existe el artículo en el listado
                Articulo articuloExistente = articulos.Find(a => a.Id == id);

                // si no existe, creo el objeto y lo agrego a la lista.
                if (articuloExistente == null)
                {
                    Articulo nuevoArticulo = new Articulo
                    {
                        Id = id,
                        Codigo = (string)lector["Codigo"],
                        Nombre = (string)lector["Nombre"],
                        Descripcion = (string)lector["Descripcion"],
                        Precio = (decimal)lector["Precio"],
                        Marca = new Marca { Id = (int)lector["IdMarca"], Descripcion = (string)lector["Marca"] },
                        Categoria = new Categoria { Id = (int)lector["IdCategoria"], Descripcion = (string)lector["Categoria"] }
                    };

                    if (!string.IsNullOrWhiteSpace(url))
                        {
                            int idUrl = (int)lector["ImagenId"];
                            nuevoArticulo.Imagenes.Add(new Imagen { Id = idUrl, Url = url });
                        }

                    articulos.Add(nuevoArticulo);
                }
                else
                {
                    // si ya existe, solo agrego la imagen al listado.
                    if (!string.IsNullOrWhiteSpace(url))
                    {
                        int idUrl = (int)lector["ImagenId"];
                        articuloExistente.Imagenes.Add(new Imagen { Id = idUrl, Url = url });
                    }
                }
            }

                return articulos;
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


        public int agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.DefinirConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                     "VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");

                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);

                datos.EjecutarAccion();
                datos.LimpiarParametros();
                int idArticulo = ObtenerIdArticulo(nuevo);
                return idArticulo;
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


        public int ObtenerIdArticulo(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //Buscar el Id por todos los campos
                datos.DefinirConsulta("SELECT Id FROM ARTICULOS WHERE Codigo = @Codigo AND Nombre = @Nombre AND Descripcion = @Descripcion AND IdMarca = @IdMarca AND IdCategoria = @IdCategoria AND Precio = @Precio");

                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);

                datos.EjecutarConsulta();

                int idArticulo = 0;
                if (datos.Lector.Read())
                {
                    idArticulo = (int)datos.Lector["Id"];
                }

                return idArticulo;
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


        public void modificar(Articulo articuloEditar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.DefinirConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio WHERE Id = @Id");

                datos.setearParametro("@Id", articuloEditar.Id);
                datos.setearParametro("@Codigo", articuloEditar.Codigo);
                datos.setearParametro("@Nombre", articuloEditar.Nombre);
                datos.setearParametro("@Descripcion", articuloEditar.Descripcion);
                datos.setearParametro("@IdMarca", articuloEditar.Marca.Id);
                datos.setearParametro("@IdCategoria", articuloEditar.Categoria.Id);
                datos.setearParametro("@Precio", articuloEditar.Precio);

                datos.EjecutarAccion();
            }
            catch (Exception)
            {
                throw;
            } finally
            {
                datos.CerrarConexion();
            }
        }
        public void eliminar(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.DefinirConsulta("DELETE IMAGENES WHERE IdArticulo = " + idArticulo);
                datos.EjecutarAccion();

                datos.DefinirConsulta("DELETE ARTICULOS WHERE Id = " + idArticulo);
                datos.EjecutarAccion();
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
