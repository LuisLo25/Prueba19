using Capa3_Dominio.Entidades;
using Capa3_Dominio.ViewModels;
using System;
using System.Collections.Generic;

namespace Capa3_Dominio.interfaces
{
    public interface INominaRepository
    {
        Nomina GetNominaById(int nomina);
        List<Nomina> GetNominaList(string desc);
        long Save(Nomina model);
        ProcessNominaViewModel GetBoletaList(int id);
        ProcessNominaViewModel GetContratoList(int id);
        int countEmployes(int cancel,int nominaId);
        int closeNomina(int id);
        int deleNomina(int id);
    }
}
