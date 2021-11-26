using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.ViewModels
{
    public class ProcessNominaViewModel 
    {
        public List<BoletaItemViewModel> pagos { get; set;}
        public decimal IngresoNomina { get; set; }
        public decimal RegienPensionario { get; set; }
        public decimal AllPaymentDocument { get; set; }
        public decimal CountEMployes { get; set; }
    }
    public class BoletaItemViewModel
    {
        public int Empleado_id { get; set; }
        public int Contrato_id { get; set; }
        public string Nombres { get; set; }
        public string Puesto { get; set; }
        public decimal TotalIngresos { get; set; }
        public decimal TotalRete { get; set; }
        public decimal NetoPago { get; set; }

        public BoletaItemViewModel GetBoletaModel(SqlDataReader resultSql)
        {
            BoletaItemViewModel model = new BoletaItemViewModel();
            model.Empleado_id = resultSql.GetInt32(0);
            model.Contrato_id = resultSql.GetInt32(1);
            model.Nombres = resultSql.GetString(2);
            model.Puesto = resultSql.GetString(3);
            model.TotalIngresos = resultSql.GetDecimal(4);
            model.TotalRete = resultSql.GetDecimal(5);
            model.NetoPago = resultSql.GetDecimal(6);
            return model;
        }
    }
}
