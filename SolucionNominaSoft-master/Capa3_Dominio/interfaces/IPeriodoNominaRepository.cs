﻿using Capa3_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.interfaces
{
   public interface IPeriodoNominaRepository
    {
        List<PeriodoDeNomina> GetPedidoNomina();
    }
}
