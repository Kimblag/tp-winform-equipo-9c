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

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Descripcion FROM MARCAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

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
                conexion.Close();
            }
        }


         

    }
}
