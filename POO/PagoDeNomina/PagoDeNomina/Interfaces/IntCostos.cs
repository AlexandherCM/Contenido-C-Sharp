using PagoDeNomina.ClasesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoDeNomina.Interfaces
{
    public interface IntCostos
    {
        float GenerarCostoVenta(clsElectrodomestico CostVenta);
        float GenerarCostoAdquicision(clsElectrodomestico CostAdquicision);
    }   
}
