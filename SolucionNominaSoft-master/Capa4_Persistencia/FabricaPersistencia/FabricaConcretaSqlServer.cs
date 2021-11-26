using Capa3_Dominio.Contratos;
using Capa3_Dominio.interfaces;
using Capa4_Persistencia.ADONet_SQLServer;

namespace Capa4_Persistencia.FabricaPersistencia
{
	public class FabricaConcretaSqlSever : FabricaAbstractaDePersistencia
	{
		public override IGestorAccesoDeDatos CrearGestorAccesoDeDatos()
		{
			return new GestorSqlServer();
		}

		public override INominaRepository CrearNominaRepository(IGestorAccesoDeDatos gestorAccesoDeDatos)
		{
			return  new NominaSqlServer(gestorAccesoDeDatos);
		}

		public override IPeriodoNominaRepository IperiodoNomina(IGestorAccesoDeDatos gestorAccesoDeDatos)
		{
			return  new PeriodoDeNominaSqlServer(gestorAccesoDeDatos);
		}
	}
}
