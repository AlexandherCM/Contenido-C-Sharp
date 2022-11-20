using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPoo.Polimorfismo
{
    public class clsDireccion
    {
        public clsDireccion()
        {
            CP = String.Empty;
            Municipio = String.Empty;   
            Colonia = String.Empty;
            NuemeroExterno = 0;
        }

        public String CP { get; set; }
        public String Municipio { get; set; }
        public String Colonia { get; set; }
        public int NuemeroExterno { get; set; }
    }
}
