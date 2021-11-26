namespace Capa3_Dominio.Contratos
{
    public interface IGestorAccesoDeDatos
    {
        void AbrirConexion();

        void CerrarConexion();

        void IniciarTransaccion();

        void TerminarTransaccion();

        void CancelarTransaccion();
    }
}
