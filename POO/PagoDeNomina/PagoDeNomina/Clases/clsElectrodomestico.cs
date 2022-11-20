using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoDeNomina.ClasesAbstractas
{
    public class clsElectrodomestico
    {
        public String Marca { get; set; }
        public int Unidades { get; set; }
        public String Proveedor { get; set; }
        public float CostoAdquisicion { get; set; }
        public float GtsOperativos { get; set; }
        public float Marketing { get; set; }
        public float IVA { get; set; }
        public float ISR { get; set; }
    }
}
