using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.Servicios;
using Capa4_Persistencia.ADONet_SQLServer;
using Common.Nomina.Query;

namespace Capa2_Aplicacion.Servicios
{
    public class GestionarContratoServicio
    {
        private readonly GestorSqlServer gestorAccesoDatos;
        private readonly EmpleadoSqlServer empleadoDAO;
        private readonly ContratoSqlServer contratoDAO;
        private readonly  AfpSqlServer afpdao;
        public GestionarContratoServicio()
        {
            gestorAccesoDatos = new GestorSqlServer();
            empleadoDAO = new EmpleadoSqlServer(gestorAccesoDatos);
            contratoDAO = new ContratoSqlServer(gestorAccesoDatos);
            afpdao = new AfpSqlServer(gestorAccesoDatos);
        }

        public Empleado BuscarEmpleado(string dni)
        {
            gestorAccesoDatos.AbrirConexion();
            Empleado empleado = empleadoDAO.BuscarPorDNI(dni);
            gestorAccesoDatos.CerrarConexion();
            return empleado;
        }

        public Contrato BuscarContrato(int id)
        {
            gestorAccesoDatos.AbrirConexion();
            Contrato resultContrato = contratoDAO.BuscarPorIDEmpleado(id);
            gestorAccesoDatos.CerrarConexion();
            return resultContrato;

        }
       

        public Afp BuscarAFP(int id)
        {
            gestorAccesoDatos.AbrirConexion();
            Afp afp = afpdao.BuscarPorIDAfp(id);
            gestorAccesoDatos.CerrarConexion();
            return afp;

        }
        public void guardarContrato(Contrato contrato,int bandera,DateTime fechaActual)
        {
            gestorAccesoDatos.AbrirConexion();
            if (bandera == 1 && contrato.crearContrato(contrato,fechaActual))
            {
                contratoDAO.guardarContratocreadoenSQL(contrato);           
            }
            else
            {
               
              if(bandera==0 && contrato.crearContrato(contrato, fechaActual))
                {
                contratoDAO.guardarContratoeditadoenSQL(contrato);
                }
            
            }
            
            gestorAccesoDatos.CerrarConexion();
        }
    }
}
