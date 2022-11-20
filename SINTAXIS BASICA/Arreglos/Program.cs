using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            int[] arreglo = new int [4];

            for(i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = (i + 1);
            }

            for(i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Numeros: {0}", arreglo[i]);
            }

            Console.ReadKey();
        }
    }
}
