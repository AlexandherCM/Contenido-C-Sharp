using PagoDeNomina.Clases.Cliente;
using PagoDeNomina.Clases.CPU;
using PagoDeNomina.ClasesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoDeNomina
{
    public class program
    {
        public static void Main(String[] agrs)
        {
            Console.Clear();
            clsCliente dato = new clsCliente();

            //dato.setContacto('f',5591889796,"alexandhercordoba378@gmail.com");
            //Console.WriteLine(dato.getNumero());

            Console.WriteLine(dato);

            Console.ReadKey();
        }
    }
}
