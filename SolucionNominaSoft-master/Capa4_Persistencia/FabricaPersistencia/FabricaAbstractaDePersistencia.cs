using Capa3_Dominio.Contratos;
using Capa3_Dominio.interfaces;
using Capa4_Persistencia.Properties;
using System;

namespace Capa4_Persistencia.FabricaPersistencia
{
    
   public abstract class FabricaAbstractaDePersistencia
    {
        public static FabricaAbstractaDePersistencia CrearInstancia()
        {
            Type tipoClaseFabricaDePersistencia = Type.GetType(Settings.Default.conexion);
            FabricaAbstractaDePersistencia fabricaConcretaDePersistencia = (FabricaAbstractaDePersistencia)Activator.CreateInstance(tipoClaseFabricaDePersistencia);
            return fabricaConcretaDePersistencia;
        }
        public abstract IGestorAccesoDeDatos CrearGestorAccesoDeDatos();
        public abstract INominaRepository CrearNominaRepository(IGestorAccesoDeDatos gestorAccesoDeDatos);
        public abstract IPeriodoNominaRepository IperiodoNomina(IGestorAccesoDeDatos gestorAccesoDeDatos);
    }
}
