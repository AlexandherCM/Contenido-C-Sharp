using PagoDeNomina.Clases.Cliente;
using PagoDeNomina.Clases.CPU;
using PagoDeNomina.ClasesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoDeNomina.Interfaces
{
    public interface IntDocumento
    {
        void GenerarFactura(clsCPU cpu, clsCliente cliente);
        void GenerarNotaCompra(clsCPU cpu);
        String ObtenerImpuesto(clsElectrodomestico impuesto);
    }
}
