using Capa3_Dominio.Contratos;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa4_Persistencia.ADONet_SQLServer
{
    class PeriodoDeNominaSqlServer : IPeriodoNominaRepository
    {
        private readonly GestorSqlServer gestorSQL;

        public PeriodoDeNominaSqlServer(IGestorAccesoDeDatos gestorSQL)
        {
            this.gestorSQL = (GestorSqlServer)gestorSQL;
        }


        public List<PeriodoDeNomina> GetPedidoNomina()
        {
            List<PeriodoDeNomina> listData = new List<PeriodoDeNomina>();
            PeriodoDeNomina periodo;
            string consultaSql = "select  * from PeriodoDeNomina ";

            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSql);
                while (resultadoSQL.Read())
                {
                    periodo =  responseModel(resultadoSQL);
                    listData.Add(periodo);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return listData;
        
            throw new NotImplementedException();
        }

        private PeriodoDeNomina responseModel(SqlDataReader resultSql)
        {
            PeriodoDeNomina model = new PeriodoDeNomina();
            model.Periodo_id = resultSql.GetInt32(0);
            model.Descripcion = resultSql.GetString(1);
            model.Fechainicio = resultSql.GetDateTime(2);
            model.Fechafin = resultSql.GetDateTime(3);
            return model;
        }
    }
}
