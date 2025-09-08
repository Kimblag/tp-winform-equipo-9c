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
                datos.DefinirConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion Marca, C.Descripcion Categoria, I.ImagenUrl FROM ARTICULOS A JOIN MARCAS M ON A.IdMarca = M.Id JOIN CATEGORIAS C ON A.IdCategoria = C.Id JOIN IMAGENES I ON A.Id = I.IdArticulo");
                datos.EjecutarConsulta();
                lector = datos.Lector;

                while (lector.Read())
                {
                    int id = (int)lector["Id"];
                    string url = (string)lector["ImagenUrl"];

                    // primero busco si ya existe el artículo en el listado
                    Articulo articuloExistente = articulos.Find(a => a.Id == id);

                    // si no existe, creo el objeto y lo agrego a la lista.
                    if (articuloExistente == null)
                    {
                        Articulo articulo = new Articulo();
                        articulo.Id = (int)lector["Id"];
                        articulo.Codigo = (string)lector["Codigo"];
                        articulo.Nombre = (string)lector["Nombre"];
                        articulo.Descripcion = (string)lector["Descripcion"];
                        articulo.Precio = (decimal)lector["Precio"];
                        articulo.Marca = new Marca();
                        articulo.Marca.Descripcion = (string)lector["Marca"];
                        articulo.Categoria = new Categoria();
                        articulo.Categoria.Descripcion = (string)lector["Categoria"];
                        if (!string.IsNullOrWhiteSpace(url))
                            articulo.Imagenes.Add(new Imagen { Url = url });
                        articulos.Add(articulo);
                    } else
                    {
                        // si ya existe, entonces significa que tiene más de una imagen, vamos a agregar la url al listado.
                        if (!string.IsNullOrWhiteSpace(url))
                            articuloExistente.Imagenes.Add(new Imagen { Url = url });
                    }
                }

                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            } finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
