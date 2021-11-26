using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Common.Nomina.Query;
using Capa3_Dominio.Contratos;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.interfaces;
using Capa3_Dominio.ViewModels;
using Capa3_Dominio.Dto;

namespace Capa4_Persistencia.ADONet_SQLServer
{
    public class NominaSqlServer : INominaRepository
    {
        private readonly GestorSqlServer gestorSQL;
        private readonly NominaExceQuery nominaExceQuery;

        public NominaSqlServer(IGestorAccesoDeDatos gestorSQL)
        {
            this.gestorSQL = (GestorSqlServer)gestorSQL;
            this.nominaExceQuery = new NominaExceQuery();
        }

        public Nomina GetNominaById(int nomina)
        {
            Nomina nominaEntity= new Nomina();
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(nominaExceQuery.ExceQueryNOmina(nomina));
                if (resultadoSQL.Read())
                {
                    nominaEntity = nominaEntity.GetNominaModel(resultadoSQL, nomina);
                }
                return nominaEntity;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }

        }
        public ProcessNominaViewModel GetBoletaList(int id)
        {
            ProcessNominaViewModel viewNomina = new ProcessNominaViewModel(); 
            List<BoletaItemViewModel> listItemBoleta = new List<BoletaItemViewModel>();
            BoletaDePago boletaDePago = new BoletaDePago();
            try
            {
                SqlCommand usp = gestorSQL.ObtenerComandoDeProcedimiento("Usp_Boletas_Contrato");
                usp.Parameters.AddWithValue("@NominaId", id);
                SqlDataReader resultadoSQL = usp.ExecuteReader();
                while (resultadoSQL.Read())
                {
                    boletaDePago = boletaDePago.SetModelSql(resultadoSQL);
                    BoletaItemViewModel viewModel = new BoletaItemViewModel();
                    viewModel.Contrato_id = boletaDePago.Contrato_id;
                    viewModel.Empleado_id = boletaDePago.Contrato.Empleado.Empleado_id;
                    viewModel.Nombres = boletaDePago.Contrato.Empleado.Nombres;
                    viewModel.Puesto = boletaDePago.Contrato.Puesto;
                    viewModel.TotalIngresos = boletaDePago.calulaIngresos(boletaDePago);
                    viewModel.TotalRete = boletaDePago.calulaRetenciones(boletaDePago);
                    viewModel.NetoPago = boletaDePago.CalculaNetoPago(viewModel.TotalIngresos, viewModel.TotalRete);                    
                    listItemBoleta.Add(viewModel);
                }
                gestorSQL.CerrarConexion();
                listItemBoleta.ForEach((i) =>
                {
                    viewNomina.CountEMployes = (viewNomina.CountEMployes) + (this.countEmployes(1, i.Contrato_id));
                    viewNomina.AllPaymentDocument = viewNomina.AllPaymentDocument + i.NetoPago;
                    viewNomina.IngresoNomina = viewNomina.IngresoNomina + i.TotalIngresos;
                    viewNomina.RegienPensionario = viewNomina.RegienPensionario + i.TotalRete;
                });
                viewNomina.pagos = listItemBoleta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return viewNomina;
        }
        public List<Nomina> GetNominaList(string desc)
        {
            List<Nomina> listData = new List<Nomina>();
            Nomina nomina = new Nomina();
            string consultaSql = "select * from Nomina where descripcion like '%" + desc + "%'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSql);
                while (resultadoSQL.Read())
                {
                    nomina = nomina.GetNominaModel(resultadoSQL, 0);
                    listData.Add(nomina);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return listData;
        }
        public int countEmployes(int cancel, int nominaId)
        {
            int count = 0;
            try
            {
                gestorSQL.AbrirConexion();
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(nominaExceQuery.ExceCountQueryPayment(cancel, nominaId));
                if (resultadoSQL.Read())
                {
                    count = resultadoSQL.GetInt32(0);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return count;
        }

        public ProcessNominaViewModel GetContratoList(int id)
        {
            ProcessNominaViewModel viewNomina = new ProcessNominaViewModel();
            List<BoletaItemViewModel> listItemBoleta = new List<BoletaItemViewModel>();
            var listContratos = this.GetContratos(id);
            var boletasTem = this.GetBoletasListTemp(listContratos);
            foreach (var i in boletasTem)
            {
                BoletaItemViewModel viewModel = new BoletaItemViewModel();
                viewModel.Contrato_id = i.Contrato_id;
                viewModel.Empleado_id = i.Contrato.Empleado.Empleado_id;
                viewModel.Nombres = i.Contrato.Empleado.Nombres;
                viewModel.Puesto = i.Contrato.Puesto;
                viewModel.TotalIngresos = i.calulaIngresos(i);
                viewModel.TotalRete = i.calulaRetenciones(i);
                viewModel.NetoPago = i.CalculaNetoPago(viewModel.TotalIngresos, viewModel.TotalRete);
                viewNomina.CountEMployes = (viewNomina.CountEMployes) + (this.countEmployes(1, i.Contrato_id));
                listItemBoleta.Add(viewModel);
            }
            gestorSQL.CerrarConexion();
            listItemBoleta.ForEach((i) =>
            {
                viewNomina.CountEMployes = (viewNomina.CountEMployes) + (this.countEmployes(1, i.Contrato_id));
                viewNomina.AllPaymentDocument = viewNomina.AllPaymentDocument + i.NetoPago;
                viewNomina.IngresoNomina = viewNomina.IngresoNomina + i.TotalIngresos;
                viewNomina.RegienPensionario = viewNomina.RegienPensionario + i.TotalRete;
            });
            viewNomina.pagos = listItemBoleta;
            return viewNomina;
        }
        private List<BoletaDePago> GetBoletasListTemp(List<ContratoDto> list)
        {
            List<BoletaDePago> boletasTemp = new List<BoletaDePago>();
            BoletaDePago boletaDePago = new BoletaDePago();
            foreach (var i in list)
            {
                boletaDePago= boletaDePago.ModelItems(i);
                boletasTemp.Add(boletaDePago);
            }
            return boletasTemp;
        }
        private List<ContratoDto> GetContratos(int id)
        {
            List<ContratoDto> listData = new List<ContratoDto>();
            ContratoDto contratoDto = new ContratoDto();
            try
            {
                SqlCommand usp = gestorSQL.ObtenerComandoDeProcedimiento("listacontrato");
                usp.Parameters.AddWithValue("@PeriodoId", id);
                SqlDataReader resultadoSQL = usp.ExecuteReader();
                while (resultadoSQL.Read())
                {
                    contratoDto = contratoDto.GetContratoDto(resultadoSQL);
                    listData.Add(contratoDto);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return listData;
        }
        public long Save(Nomina model)
        {
            long succes = 0;
            string insertarNomina = "INSERT INTO Nomina" +
                                 "(periodo_id, fecha, descripcion, cerrada)" +
                                 "VALUES(@periodo_id,@fecha,@descripcion,@cerrada);";
            try
            {
                var contratosList = this.GetContratos(model.PeriodoDeNomina.Periodo_id);
                var boletasTem = this.GetBoletasListTemp(contratosList);
                gestorSQL.CerrarConexion();
                gestorSQL.AbrirConexion();
                SqlCommand comando;
                comando = gestorSQL.ObtenerComandoSQL(insertarNomina);
                comando.Parameters.AddWithValue("@periodo_id", model.PeriodoDeNomina.Periodo_id);
                comando.Parameters.AddWithValue("@fecha", model.Fecha);
                comando.Parameters.AddWithValue("@descripcion", model.Descripcion);
                comando.Parameters.AddWithValue("@cerrada", false);
                comando.ExecuteNonQuery();

                string sql = @"SELECT Max(nomina_id)
                    FROM Nomina";
                int MaxId = gestorSQL.GetQueryParamOne(sql);
                foreach (var i in boletasTem)
                {
                    this.SaveBoletaPago(i, MaxId);
                }
                succes = 1;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return succes;
        }
        private void  SaveBoletaPago(BoletaDePago model, int id)
        {
            try
            {
                SqlCommand usp = gestorSQL.ObtenerComandoDeProcedimiento("Usp_saveBoletaPago");
                usp.Parameters.AddWithValue("@contratoId", model.Contrato_id);
                usp.Parameters.AddWithValue("@nominaId", id);
                usp.Parameters.AddWithValue("@sueldoBasico", model.Sueldobasico);
                usp.Parameters.AddWithValue("@asignacionFamiliar", model.Asignacionfamiliar);
                usp.Parameters.AddWithValue("@montoporhorasextras", model.Montoporhorasextras);
                usp.Parameters.AddWithValue("@reintegros", model.Reintegros);
                usp.Parameters.AddWithValue("@movilidad", model.Movilidad);
                usp.Parameters.AddWithValue("@otrosIngresos", model.Otrosingresos);
                usp.Parameters.AddWithValue("@regimenPensionario", model.Regimenpensionario);
                usp.Parameters.AddWithValue("@montosPorHorasDeFalta", model.Montoporhorasdefalta);
                usp.Parameters.AddWithValue("@adelantos", model.Adelantos);
                usp.Parameters.AddWithValue("@otrosDescuentos", model.Otrosdescuentos);
                usp.ExecuteNonQuery();
                usp.Parameters.Clear();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
        }

        public int closeNomina(int id)
        {
            int status = 0;
            try
            {
                SqlCommand usp = gestorSQL.ObtenerComandoDeProcedimiento("Usp_CerrarNomina");
                usp.Parameters.AddWithValue("@NominaId", id);
                usp.ExecuteNonQuery();
                usp.Parameters.Clear();
                status = 1;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return status;
        }

        public int deleNomina(int id)
        {
            int status = 0;
            try
            {
                SqlCommand usp = gestorSQL.ObtenerComandoDeProcedimiento("Usp_DeleNomina");
                usp.Parameters.AddWithValue("@NominaId", id);
                usp.ExecuteNonQuery();
                usp.Parameters.Clear();
                status = 1;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw;
            }
            return status;
        }
        
    }
}
