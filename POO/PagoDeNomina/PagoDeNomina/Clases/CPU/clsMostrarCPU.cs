using PagoDeNomina.Clases.Cliente;
using PagoDeNomina.ClasesAbstractas;
using PagoDeNomina.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoDeNomina.Clases.CPU
{
    public class clsMostrarCPU : IntDocumento, IntCostos
    {
        /* IntDocumento - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
        public void GenerarFactura(clsCPU cpu, clsCliente cliente)
        {
            Console.WriteLine("Componentes: \n" + 
                              "Marca: " + cpu.DatosGrales.Marca + "\n" + 
                              "Unidades compradas" + cpu.DatosGrales.Unidades + "\n" +
                              "Subtotal: " + cpu.DatosGrales.CostoAdquisicion + "\n" + 
                              "Total: " + cpu.DatosGrales
                              );
        }

        public void GenerarNotaCompra(clsCPU cpu)
        {
            throw new NotImplementedException();
        }

        public string ObtenerImpuesto(clsElectrodomestico impuesto)
        {
            throw new NotImplementedException();
        }

        /* IntCostos - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
        public float GenerarCostoAdquicision(clsElectrodomestico CostAdquicision)
        {
            throw new NotImplementedException();
        }

        public float GenerarCostoVenta(clsElectrodomestico CostVenta)
        {
            throw new NotImplementedException();
        }
    }
}
