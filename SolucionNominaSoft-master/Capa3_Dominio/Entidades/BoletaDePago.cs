using Capa3_Dominio.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
 public   class BoletaDePago
    {
        public int Boleta_id { get; set; }
        public int Contrato_id { get; set; }
        public int Nomina_id { get; set; }
        public decimal Sueldobasico { get; set; }
        public decimal Asignacionfamiliar { get; set; }
        public decimal Montoporhorasextras { get; set; }
        public decimal Reintegros { get; set; }
        public decimal Movilidad { get; set; }
        public decimal Otrosingresos { get; set; }
        public decimal Regimenpensionario { get; set; }
        public decimal Montoporhorasdefalta { get; set; }
        public decimal Adelantos { get; set; }
        public decimal Otrosdescuentos { get; set; }
        public Contrato Contrato { get; set; }
        public Nomina Nomina { get; set; }

        //REGLAS DEL NEGOCIO
        public decimal calulaIngresos(BoletaDePago b)
        {
            return  (b.Sueldobasico) + (b.Asignacionfamiliar) + (b.Montoporhorasextras) + (b.Reintegros) + (b.Movilidad) + (b.Otrosingresos);
        }
        public decimal calulaRetenciones(BoletaDePago b)
        {
            return (b.Regimenpensionario) + (b.Montoporhorasdefalta) + (b.Adelantos) + (b.Otrosdescuentos);
        }
        public  decimal CalculaNetoPago(decimal totalIngersos, decimal totalRetenciones)
        {
            return (totalIngersos) - (totalRetenciones);
        }
        public decimal RegimenPensionario(BoletaDePago model,decimal porcentajedescuento)
        {
            return model.Sueldobasico * porcentajedescuento;
        }

        public BoletaDePago SetModelSql(SqlDataReader sqlDataReader)
        {
            BoletaDePago boletaDePago = new BoletaDePago();
            boletaDePago.Contrato = new Contrato { Contrato_id = sqlDataReader.GetInt32(1), Empleado = new Empleado { Empleado_id = sqlDataReader.GetInt32(0), Nombres = sqlDataReader.GetString(2) }, Puesto = sqlDataReader.GetString(3) };
            boletaDePago.Contrato_id = sqlDataReader.GetInt32(1);
            boletaDePago.Sueldobasico = sqlDataReader.GetDecimal(4);
            boletaDePago.Asignacionfamiliar = sqlDataReader.GetDecimal(5);
            boletaDePago.Montoporhorasextras = sqlDataReader.GetDecimal(6);
            boletaDePago.Reintegros = sqlDataReader.GetDecimal(7);
            boletaDePago.Movilidad = sqlDataReader.GetDecimal(8);
            boletaDePago.Otrosingresos = sqlDataReader.GetDecimal(9);
            boletaDePago.Regimenpensionario = sqlDataReader.GetDecimal(10);
            boletaDePago.Montoporhorasdefalta = sqlDataReader.GetDecimal(11);
            boletaDePago.Adelantos = sqlDataReader.GetDecimal(12);
            boletaDePago.Otrosdescuentos = sqlDataReader.GetDecimal(13);
            return boletaDePago;
        }
        public BoletaDePago ModelItems (ContratoDto contrato)
        {
            BoletaDePago model = new BoletaDePago();
            model.Contrato = new Contrato { Contrato_id = contrato.contrato_id, Empleado = new Empleado { Empleado_id = contrato.empleado_id, Nombres = contrato.Nombres }, Puesto = contrato.puesto };
            model.Contrato_id = contrato.contrato_id;
            model.Sueldobasico = contrato.SueldoBasico(contrato);
            model.Asignacionfamiliar = (decimal)(930.0 * 0.1);
            model.Montoporhorasextras = contrato.MontoXHorasExtras(contrato);
            model.Reintegros = 10;
            model.Movilidad = (decimal)10.0;
            model.Otrosingresos = (decimal)20.2;
            model.Regimenpensionario = model.RegimenPensionario(model, contrato.porcentajedescuento);
            model.Montoporhorasdefalta = contrato.MontoXHorasDeFalta(contrato);
            model.Adelantos = (decimal)00.0;
            model.Otrosdescuentos = contrato.porcentajedescuento;
            return model;
        }
    }
}
