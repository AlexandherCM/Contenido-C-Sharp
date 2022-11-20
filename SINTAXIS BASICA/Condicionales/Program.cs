using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;
            string cadena;


            string apagador = "Si";

            while (apagador == "Si" || apagador == "si")
            {

                Console.WriteLine("Ingresa el primer valor: ");//-->Pidiendo valor
                cadena = Console.ReadLine();     //Guardando el valor
                valor1 = Convert.ToInt32(cadena);//Convirtiendo el valor en entero

                Console.WriteLine("Ingresa el segundo valor: ");//-->Pidiendo valor
                cadena = Console.ReadLine();     //Guardando el valor
                valor2 = Convert.ToInt32(cadena);//Convirtiendo el valor en entero

                if (valor1 == valor2)
                {
                    Console.WriteLine("\nAmbos numeros son iguales y su suma es: {0}", valor1 + valor2);
                }
                else
                {
                    Console.WriteLine("\nAmbos numeros son diferentes y su resta es: {0}", valor1 - valor2);
                }

                Console.WriteLine("\nQuieres repetir la operación: ");
                apagador = Console.ReadLine();


                if (apagador == "No" || apagador == "no")
                {
                    Console.WriteLine("\nPROGRAMA FINALIZADO");
                    Console.ReadKey();
                }
            }
        }
    }
}
