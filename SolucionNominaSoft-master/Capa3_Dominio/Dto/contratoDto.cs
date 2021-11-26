using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Dto
{
    public class ContratoDto
    {
     public int empleado_id { get; set; }
    public  int contrato_id { get; set; }
    public string Nombres { get; set; }
    public  string  puesto { get; set; }
    public int horasporsemana { get; set; }
    public decimal pagoporhora { get; set; }
    public  int totalhorasextras { get; set; }
    public decimal  porcentajedescuento { get; set; }
    public  int totalhorasdefalta { get; set; }

    public ContratoDto GetContratoDto(SqlDataReader resultSql)
        {
            ContratoDto model = new ContratoDto();
            model.empleado_id = resultSql.GetInt32(0);
            model.contrato_id = resultSql.GetInt32(1);
            model.Nombres = resultSql.GetString(2);
            model.puesto = resultSql.GetString(3);
            model.horasporsemana = resultSql.GetInt32(4);
            model.pagoporhora = resultSql.GetDecimal(5);
            model.totalhorasextras = resultSql.GetInt32(6);
            model.porcentajedescuento = resultSql.GetDecimal(7);
            model.totalhorasdefalta = resultSql.GetInt32(8);
            return model;
      }
    public decimal SueldoBasico(ContratoDto contrato)
      {
            return contrato.horasporsemana * contrato.pagoporhora;
      }
    public decimal MontoXHorasExtras(ContratoDto contrato)
      {
            return contrato.totalhorasextras * contrato.pagoporhora;
       }
    public  decimal MontoXHorasDeFalta(ContratoDto contrato)
       {
            return contrato.totalhorasdefalta * contrato.pagoporhora;
       }
    }
}
