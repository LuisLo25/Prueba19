using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.ExceSql
{
   public class ExcecuteQueryNomina
    {
       
            public string ExceQueryNOmina(string nominaId)
            {
                return "select * from Nomina n LEFT  JOIN PeriodoDeNomina p  ON  p.periodo_id=n.periodo_id where n.nomina_id ='" + nominaId + "'";
            }
        
    }
}
