using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class clsPiramideArray
    {
        private int basePiramide;
        private StringBuilder piramide = new StringBuilder();
        public void armarPiramideConArray()
        {
            Console.WriteLine("Ingresa el numero de base: ");
            basePiramide = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int[] array = new int[basePiramide];

            for (int i = 0; i < array.Length; i++)
            {
                for (int x = 0; x < i + 1; x++)
                {
                    array[i] = i + 1;
                }
                piramide.Append(array[i]);
                Console.WriteLine(piramide);
            }

        }
        public void armarPiramideSinArray()
        {
            Console.WriteLine("Ingresa el numero de base: ");
            basePiramide = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for(int i = 0; i < basePiramide; i++)
            {
                piramide.Append(i + 1);
                Console.WriteLine(piramide);
            }
        }

    }
}
