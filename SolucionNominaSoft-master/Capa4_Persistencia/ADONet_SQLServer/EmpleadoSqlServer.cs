using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;

namespace Capa4_Persistencia.ADONet_SQLServer
{
    public class EmpleadoSqlServer
    {
        private readonly GestorSqlServer gestorSQL;

        public EmpleadoSqlServer(GestorSqlServer gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }

        public Empleado BuscarPorDNI(string dni)
        {
            Empleado empleado = new Empleado();
            string consultaSQL = "select empleado_id, nombres, apellidos, telefono, correo, direccion, fechanacimiento from Empleado where dni = '" + dni + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    empleado = ObtenerEmpleado(resultadoSQL);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return empleado;
        }

        private Empleado ObtenerEmpleado(SqlDataReader resultadoSQL)
        {
            Empleado empleado = new Empleado();
            empleado.Empleado_id = resultadoSQL.GetInt32(0);
            empleado.Nombres = resultadoSQL.GetString(1);
            empleado.Apellidos = resultadoSQL.GetString(2);
            empleado.Direccion = resultadoSQL.GetString(3);
            empleado.Correo = resultadoSQL.GetString(4);
            empleado.Telefono = resultadoSQL.GetString(5);
            empleado.Fechanacimiento = resultadoSQL.GetDateTime(6);
            return empleado;
        }
    }
}
