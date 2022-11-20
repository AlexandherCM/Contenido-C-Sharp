using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSIONES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversiones 

            string CadenaVacia = string.Empty;

            int i = 10;
            float f = 20.54f;
            bool estado = true;
            string cadena = "1589";

            i = (int)f; // --> Adapta el valor flotante para el entero
                        //f = i;
           

            Console.WriteLine(i);

            i = Convert.ToInt32(estado);

            Console.WriteLine(i);

            i = Convert.ToInt32(cadena);

            Console.WriteLine(i);
            Console.WriteLine("Numero: " + 10);

            Console.ReadKey();
        }
    }
}
