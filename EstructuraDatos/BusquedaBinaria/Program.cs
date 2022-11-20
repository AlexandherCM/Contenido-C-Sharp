using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero, puntero = 0, final = 9, mitad = -999;
            int[] vector = { 3, 8, 11, 22, 38, 49, 50, 56, 62, 70 };
            bool encontro = false;

                Console.WriteLine("Ingrese el numero a buscar: ");
                numero = int.Parse(Console.ReadLine());

                while (!encontro && puntero <= final)
                {
                    mitad = (int)((puntero + final) / 2);

                    if (numero == vector[mitad])
                    {
                        encontro = true;
                    }

                    else if (numero < vector[mitad])
                    {
                        final = mitad - 1;
                    }
                    else
                    {
                        puntero = mitad + 1;
                    }

                }

                if (encontro)
                {
                    Console.WriteLine("El dato se encuentra y esta en la posición " + (mitad + 1));
                }
                else
                {
                    Console.WriteLine("El dato no se encuentra");
                }
//----------------------------------------------------------------------------------------------------
                Console.ReadKey();
//----------------------------------------------------------------------------------------------------
            }
        }
    }

