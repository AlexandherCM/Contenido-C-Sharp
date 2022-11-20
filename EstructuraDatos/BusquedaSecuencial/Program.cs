using System;

namespace BusquedaSecuencial{
    internal class Program{
        static void Main(string[] args){
            int numero, i = 0, pos = 0;
            int[] vec = { 3, 65, 8, 1, 2, 88, 9, 0, 6, 2 };
            bool encontro = false;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            while (!(encontro) && i < 10)
            {
                if (numero == vec[i])
                {
                    encontro = true;
                    pos = i;
                }
                i = i + 1;
            }

            if (encontro == true)
            {
                Console.Write("El numero " + numero + " se econtro en la posicion: " + (pos + 1));
            }
            else
            {
                Console.WriteLine("Numero no encontrado");
            }

            Console.ReadKey();

        }
    }
}
