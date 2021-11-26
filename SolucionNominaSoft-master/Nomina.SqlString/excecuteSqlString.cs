namespace Nomina.SqlString
{
    public class excecuteSqlString
    {
        public string ExceQueryNOmina(string nominaId)
        {
            return "select * from Nomina n LEFT  JOIN PeriodoDeNomina p  ON  p.periodo_id=n.periodo_id where n.nomina_id ='" + nominaId + "'";
        }
    }
}
