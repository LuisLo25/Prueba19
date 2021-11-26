using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    class IncidenciaLaboral
    {
        public int Incidencia_id { get; set; }
        public int Totalhorasdefalta { get; set; }
        public int Totalhorasextras { get; set; }
        internal PeriodoDeNomina PeriodoDeNomina { get; set; }
        internal Contrato Contrato { get; set; }
    }
}
