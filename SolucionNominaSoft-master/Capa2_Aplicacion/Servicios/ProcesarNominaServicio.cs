using Capa3_Dominio.Contratos;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.interfaces;
using Capa3_Dominio.ViewModels;
using Capa4_Persistencia.FabricaPersistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa2_Aplicacion.Servicios
{
  public  class ProcesarNominaServicio
    {
        private readonly IGestorAccesoDeDatos gestorAccesoDatos;
        private readonly INominaRepository nominaRepository;
        private readonly IPeriodoNominaRepository periodoNominaRepository;
        public ProcesarNominaServicio()
        {
            gestorAccesoDatos = FabricaAbstractaDePersistencia.CrearInstancia().CrearGestorAccesoDeDatos();
            nominaRepository = FabricaAbstractaDePersistencia.CrearInstancia().CrearNominaRepository(gestorAccesoDatos);
            periodoNominaRepository = FabricaAbstractaDePersistencia.CrearInstancia().IperiodoNomina(gestorAccesoDatos);
        }
       public Nomina GetNominaById(int nominaId)
        {
            gestorAccesoDatos.AbrirConexion();
            Nomina nomina = nominaRepository.GetNominaById(nominaId);
            gestorAccesoDatos.CerrarConexion();
            return nomina;
        }
      public  List<Nomina> GetNominaList(string desc)
        {
            List<Nomina> lista;
            gestorAccesoDatos.AbrirConexion();
            lista = nominaRepository.GetNominaList(desc);
            gestorAccesoDatos.CerrarConexion();
            return lista;
        }
        public List<PeriodoDeNomina> GetPeriodoNominaList()
        {
            List<PeriodoDeNomina> lista;
            gestorAccesoDatos.AbrirConexion();
            lista = periodoNominaRepository.GetPedidoNomina();
            gestorAccesoDatos.CerrarConexion();
            return lista;
        }
        public long Save(Nomina model)
        {
            gestorAccesoDatos.AbrirConexion();
            var id = nominaRepository.Save(model);
            gestorAccesoDatos.CerrarConexion();
            return id;
        }
        public ProcessNominaViewModel GetBoletaList(int nominaId)
        {
            ProcessNominaViewModel model;
            gestorAccesoDatos.AbrirConexion();
            model = nominaRepository.GetBoletaList(nominaId);
            gestorAccesoDatos.CerrarConexion();
            return model;
        }
        public ProcessNominaViewModel GetContratoList(int peridoId)
        {
            ProcessNominaViewModel model;
            gestorAccesoDatos.AbrirConexion();
            model = nominaRepository.GetContratoList(peridoId);
            gestorAccesoDatos.CerrarConexion();
            return model;
        }
        public long CloseNomina(int nominaId)
        {
            gestorAccesoDatos.AbrirConexion();
            var id = nominaRepository.closeNomina(nominaId);
            gestorAccesoDatos.CerrarConexion();
            return id;
        }
        public long DeleteNomina(int nominaId)
        {
            gestorAccesoDatos.AbrirConexion();
            var id = nominaRepository.deleNomina(nominaId);
            gestorAccesoDatos.CerrarConexion();
            return id;
        }
    }
}
