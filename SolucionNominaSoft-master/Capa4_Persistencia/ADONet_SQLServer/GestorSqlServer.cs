using Capa3_Dominio.Contratos;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa4_Persistencia.ADONet_SQLServer
{
    public class GestorSqlServer : IGestorAccesoDeDatos
    {
        private SqlConnection conexion;
        private SqlTransaction transaccion;

        public void AbrirConexion()
        {
            try
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source=LUIS\\SQLEXPRESS;Initial Catalog=NOMINASOFT;Integrated Security=True";
                conexion.Open();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
        }

        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }

        }
        public void IniciarTransaccion()
        {
            try
            {
                AbrirConexion();
                transaccion = conexion.BeginTransaction();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
        }

        public void TerminarTransaccion()
        {
            try
            {
                transaccion.Commit();
                conexion.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
        }

        public void CancelarTransaccion()
        {
            try
            {
                transaccion.Rollback();
                conexion.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
        }

        public SqlDataReader EjecutarConsulta(string sentenciaSQL)
        {
            try
            {
                SqlCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = sentenciaSQL;
                comandoSQL.CommandType = CommandType.Text;
                return comandoSQL.ExecuteReader();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
        }

        public SqlCommand ObtenerComandoSQL(string sentenciaSQL)
        {
            try
            {
                SqlCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = sentenciaSQL;
                comandoSQL.CommandType = CommandType.Text;
                return comandoSQL;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
        }

        public SqlCommand ObtenerComandoDeProcedimiento(string procedimientoAlmacenado)
        {
            try
            {
                SqlCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = procedimientoAlmacenado;
                comandoSQL.CommandType = CommandType.StoredProcedure;
                return comandoSQL;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
        }
        public int GetMaxId(string query)
        {
            int MaxId = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion); 
                 MaxId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return MaxId;
        }
        public byte GetQueryParamOne(string query)
        {
            byte status = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                status = Convert.ToByte( cmd.ExecuteScalar());
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return status;
        }

    }
}
