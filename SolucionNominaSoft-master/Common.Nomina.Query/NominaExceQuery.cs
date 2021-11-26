using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Nomina.Query
{
   public  class NominaExceQuery
    {
       public NominaExceQuery()
        {

        }
        public string ExceQueryNOmina(int nominaId)
        {
            return "select * from Nomina n LEFT  JOIN PeriodoDeNomina p  ON  p.periodo_id=n.periodo_id where n.nomina_id ='" + nominaId + "'";
        }
        public  string ExceQueryPayment(int nominaId)
        {
            return "select p.*, n.descripcion, c.*  from BoletaDePago p left join Nomina n on p.nomina_id= n.nomina_id left join Contrato c on p.nomina_id=c.contrato_id where  p.nomina_id= '" + nominaId + "'";

        }
        public string ExceCountQueryPayment(int cancel , int nomina_id)
        {
            return  "select COUNT(*) as quantity from BoletaDePago p left join Nomina n on p.nomina_id = n.nomina_id left join Contrato c on p.nomina_id = c.contrato_id  where c.cancelado = '" + cancel + "' and p.contrato_id = '" + nomina_id + "' ";
        }
    }
}
