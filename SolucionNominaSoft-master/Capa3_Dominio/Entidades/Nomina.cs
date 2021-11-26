using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
 public class Nomina
    {
        public int Nomina_id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public bool Cerrada { get; set; }
        public PeriodoDeNomina PeriodoDeNomina { get; set; }
        public List<BoletaDePago> ListaDeContratos { get; set; }

        public Nomina GetNominaModel(SqlDataReader resultSql, int nomina)
        {
            Nomina model = new Nomina();
            if (nomina != 0)
            {
                model.Nomina_id = resultSql.GetInt32(0);
                model.Descripcion = resultSql.GetString(3);
                model.Fecha = resultSql.GetDateTime(2);
                model.Cerrada = resultSql.GetBoolean(4);
                model.PeriodoDeNomina = GetPeriodoNomina(resultSql, true);
            }
            else
            {
                model.Nomina_id = resultSql.GetInt32(0);
                model.Descripcion = resultSql.GetString(3);
                model.Fecha = resultSql.GetDateTime(2);
                model.Cerrada = resultSql.GetBoolean(4);
            }

            return model;
        }
        public  PeriodoDeNomina GetPeriodoNomina(SqlDataReader resultSql, bool isComplement = false)
        {
            PeriodoDeNomina model = new PeriodoDeNomina();
            if (isComplement)
            {
                model.Periodo_id = resultSql.GetInt32(5);
                model.Descripcion = resultSql.GetString(6);
                model.Fechainicio = resultSql.GetDateTime(7);
                model.Fechafin = resultSql.GetDateTime(8);
            }
            else
            {
                model.Periodo_id = resultSql.GetInt32(1);
                model.Descripcion = resultSql.GetString(2);
                model.Fechainicio = resultSql.GetDateTime(3);
                model.Fechafin = resultSql.GetDateTime(4);
            }
            return model;
        }
    }
}
