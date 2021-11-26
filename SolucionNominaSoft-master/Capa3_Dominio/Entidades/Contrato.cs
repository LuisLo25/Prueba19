using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
   public class Contrato
    {
       
        public int Contrato_id { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafin { get; set; }
        public Boolean Tieneasignacionfamiliar { get; set; }
        public int Horasporsemana { get; set; }
        public Decimal Pagoporhora { get; set; }
        public string Puesto { get; set; }
        public Empleado Empleado { get; set; }
        public int AFP1 { get; set; }
        public bool Cancelado { get; set; }

        

        public bool crearContrato(Contrato contrato, DateTime fechaActual)
        {
            if (contrato.validarFechainicio(contrato, fechaActual) && contrato.validarFechaInicioFin(contrato) && validarHorasContrato(contrato) && validarPagoXHorasContrato(contrato))

            {

                return true;
            }
            else
            {
                return false;
            }
        }
        //REGLAS DEL NEGOCIO
        public bool validarFechainicio(Contrato contrato, DateTime fechaActual)
        {
            if (contrato.Fechainicio.Date >= fechaActual.Date)
            {
                return true;
            }

            else
                return false;
        }

        public int convertirMeses(Contrato contrato)
        {
            int valor;

            valor = contrato.Fechafin.Month - Fechainicio.Month;
            if (valor < 0)
            {
                valor = valor * -1;
            }


            return valor;
        }

        public bool validarFechaInicioFin(Contrato contrato)
        {
            if (convertirMeses(contrato) >= 3 && convertirMeses(contrato) <= 12 && contrato.Fechafin.Year - contrato.Fechainicio.Year <= 1 && contrato.Fechafin.Year - contrato.Fechainicio.Year > 0)
            {
                return true;

            }
            else
                return false;
        }
        public bool validarPagoXHorasContrato(Contrato contrato)
        {
            string cadena = contrato.Pagoporhora.ToString();
            int numero;
            bool esEntero = Int32.TryParse(cadena, out numero);

            if (contrato.Pagoporhora >= 10 && contrato.Pagoporhora <= 60 && esEntero)
            {
                return true;
            }
            else
                return false;

        }
        public bool validarHorasContrato(Contrato contrato)
        {
            if (contrato.Horasporsemana % 4 == 0 && contrato.Horasporsemana >= 8 && contrato.Horasporsemana <= 40)
            {
                return true;
            }
            else
                return false;
        }

        

    }
}
