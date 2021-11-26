using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class PeriodoDeNomina
    {
        public int Periodo_id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafin { get; set; }
    }
}
