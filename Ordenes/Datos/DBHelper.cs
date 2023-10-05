using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ordenes.Datos
{
    public class DBHelper
    {
        private static DBHelper? instancia = null;

        private SqlConnection conexion;
        private SqlCommand comando;

        public DBHelper()
        {
            conexion = new SqlConnection(Properties.Resources.cnnString);
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public static DBHelper ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new DBHelper();
            return instancia;

        }

        public void AbreConexionConTransaccion()
        {
            try
            {
                conexion.Open();
                comando.Transaction = conexion.BeginTransaction();
            }
            catch
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }


        }

        public void CierraConexionConTransaccion()
        {
            try
            {
                comando.Transaction.Commit();
                conexion.Close();
            }
            catch
            {
                if (comando.Transaction != null)
                    comando.Transaction.Rollback();
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            comando.CommandText = nombreSP;
            comando.CommandType = CommandType.StoredProcedure;
            DataTable Datos = new DataTable();
            Datos.Load(comando.ExecuteReader());
            conexion.Close();
            return Datos;
        }

        public DataTable Consultar(string nombreSP, List<SqlParameter> lista_param)
        {
            conexion.Open();
            comando.CommandText = nombreSP;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            foreach (SqlParameter param in lista_param)
            {
                comando.Parameters.Add(param);
            }
            DataTable Datos = new DataTable();
            Datos.Load(comando.ExecuteReader());
            conexion.Close();
            return Datos;
        }

        public int CargaRegistro(string nombreSP, List<SqlParameter> lista_param, SqlParameter? salida)
        {
            int respuesta = 0;
            comando.CommandText = nombreSP;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            if (salida != null)
                lista_param.Add(salida);
            foreach (SqlParameter param in lista_param)
            {
                comando.Parameters.Add(param);
            }
            comando.ExecuteNonQuery();
            if (salida != null)
                respuesta = (int)salida.Value;
            return respuesta;
        }
    }
}
