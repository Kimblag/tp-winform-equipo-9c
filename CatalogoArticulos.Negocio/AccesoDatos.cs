using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CatalogoArticulos.Negocio
{
    internal class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }


        public void DefinirConsulta(string consultaSql)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consultaSql;
        }


        public void EjecutarConsulta()
        {
            try
            {
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                if (conexion.State != ConnectionState.Open) 
                { 
                    // valido primero si ya está abierta para que no la vuelva a abrir
                    comando.Connection.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int EjecutarAccionEscalar()
        {
            comando.Connection = conexion;
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    // valido primero si ya está abierta para que no la vuelva a abrir
                    comando.Connection.Open();
                }
                object id = comando.ExecuteScalar();
                return (int)id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void LimpiarParametros()
        {
            comando.Parameters.Clear();
        }

    }
}
