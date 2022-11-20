using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoDeNomina.Clases.Cliente
{
    public class clsDireccion
    {
        private int CP;
        private String Municipio;
        private String Colonia;
        private int Manzana;
        private int Lote;
        private int NumeroExterno;

        public clsDireccion()
        {
            this.CP = 0;
            this.Municipio = "";
            this.Colonia = "";
            this.Manzana = 0;
            this.Lote = 0;
            this.NumeroExterno = 0;
        }

        public clsDireccion(int CP, string Municipio, string Colonia, int Manzana, int Lote, int NumeroExterno)
        {
            this.CP = CP;
            this.Municipio = Municipio;
            this.Colonia = Colonia;
            this.Manzana = Manzana;
            this.Lote = Lote;
            this.NumeroExterno = NumeroExterno;
        }

    }
}
