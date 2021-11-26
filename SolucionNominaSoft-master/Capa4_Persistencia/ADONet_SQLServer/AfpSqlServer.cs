using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;
namespace Capa4_Persistencia.ADONet_SQLServer
{
    public class AfpSqlServer
    {
        private readonly GestorSqlServer gestorSQL;

        public AfpSqlServer(GestorSqlServer gestorSQL)
        {
            this.gestorSQL = gestorSQL;
        }
        public Afp BuscarPorIDAfp(int Id)
        {
            Afp afp = new  Afp();
            string consultaSQL = "select nombre from Afp where afp_id = '" + Id + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {

                    afp = ObtenerAfp(resultadoSQL);

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return afp;
        }
        private Afp ObtenerAfp(SqlDataReader resultadoSQL)
        {
        
            Afp afp = new Afp();
            afp.Nombre= resultadoSQL.GetString(0);
            
            return afp;
        }

    }



}

