using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;

namespace Capa4_Persistencia.ADONet_SQLServer
{
    public class ContratoSqlServer
    {
        private readonly GestorSqlServer gestorSQL;

        public ContratoSqlServer(GestorSqlServer gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }

        public void guardarContratocreadoenSQL(Contrato contrato)
        {
            string insertarcContratoSQL;

            insertarcContratoSQL = " insert into Contrato (empleado_id,afp_id,fechainicio,fechafin,tieneasignacionfamiliar,horasporsemana,pagoporhora,puesto,cancelado) " + "values(@empleado_id,@afp_id,@fechainicio,@fechafin,@tieneasignacionfamiliar,@horasporsemana,@pagoporhora,@puesto,@cancelado)";
            try
            {
                SqlCommand comando;
               if (contrato.Empleado != null)
                {
                  
                        comando = gestorSQL.ObtenerComandoSQL(insertarcContratoSQL);
                        comando.Parameters.AddWithValue("@empleado_id", contrato.Empleado.Empleado_id);
                        comando.Parameters.AddWithValue("@afp_id", contrato.AFP1);
                        comando.Parameters.AddWithValue("@fechainicio", contrato.Fechainicio);
                        comando.Parameters.AddWithValue("@fechafin", contrato.Fechafin);
                        comando.Parameters.AddWithValue("@tieneasignacionfamiliar", contrato.Tieneasignacionfamiliar);
                        comando.Parameters.AddWithValue("@horasporsemana", contrato.Horasporsemana);
                        comando.Parameters.AddWithValue("@pagoporhora", contrato.Pagoporhora);
                        comando.Parameters.AddWithValue("@puesto", contrato.Puesto);
                        comando.Parameters.AddWithValue("@cancelado", contrato.Cancelado);
                        comando.ExecuteNonQuery();
                    
                    
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public void guardarContratoeditadoenSQL(Contrato contrato)
        {
            string editarContratoSQL;
            editarContratoSQL = "update  Contrato set afp_id=@afp_id,fechainicio=@fechainicio,fechafin=@fechafin,tieneasignacionfamiliar=@tieneasignacionfamiliar, horasporsemana=@horasporsemana,pagoporhora=@pagoporhora,puesto=@puesto,cancelado=@cancelado where contrato_id=@contrato_id";
            try
            {
                SqlCommand comando;
                if (contrato.Empleado!=null)
                {    
                    comando = gestorSQL.ObtenerComandoSQL(editarContratoSQL);
                    comando.Parameters.AddWithValue("@contrato_id", contrato.Contrato_id);
                    comando.Parameters.AddWithValue("@afp_id", contrato.AFP1);
                    comando.Parameters.AddWithValue("@fechainicio", contrato.Fechainicio);
                    comando.Parameters.AddWithValue("@fechafin", contrato.Fechafin);
                    comando.Parameters.AddWithValue("@tieneasignacionfamiliar", contrato.Tieneasignacionfamiliar);
                    comando.Parameters.AddWithValue("@horasporsemana", contrato.Horasporsemana);
                    comando.Parameters.AddWithValue("@pagoporhora", contrato.Pagoporhora);
                    comando.Parameters.AddWithValue("@puesto", contrato.Puesto);
                    comando.Parameters.AddWithValue("@cancelado", contrato.Cancelado);
                    comando.ExecuteNonQuery();
                }
            }

            catch (Exception exe)
            {
                Console.WriteLine(exe);
                throw;
            }



        }

        public Contrato BuscarPorIDEmpleado(int Id)
        {
            Contrato contrato= new Contrato();
            string consultaSQL = "select contrato_id,afp_id, fechainicio,fechafin,tieneasignacionfamiliar,horasporsemana,pagoporhora,puesto,cancelado from Contrato where empleado_id = '" + Id + "' order by contrato_id desc";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    
                    contrato = ObtenerContrato(resultadoSQL);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return contrato;
        }
        private Contrato ObtenerContrato(SqlDataReader resultadoSQL)
        {
            Contrato contrato = new Contrato();
            contrato.Contrato_id = resultadoSQL.GetInt32(0);
            contrato.AFP1 = resultadoSQL.GetInt32(1);
            contrato.Fechainicio = resultadoSQL.GetDateTime(2);
            contrato.Fechafin = resultadoSQL.GetDateTime(3);
            contrato.Tieneasignacionfamiliar = resultadoSQL.GetBoolean(4);
            contrato.Horasporsemana = resultadoSQL.GetInt32(5);
            contrato.Pagoporhora = resultadoSQL.GetDecimal(6);
            contrato.Puesto = resultadoSQL.GetString(7);
            contrato.Cancelado = resultadoSQL.GetBoolean(8);
            return contrato;
        }

    }
}
