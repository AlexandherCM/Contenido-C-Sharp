using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TablaHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------
            ProgramClash Procesar;
            Procesar = new ProgramClash();
            //-----------------------------------------

            string apagador = "Si";
            string borrar = string.Empty;
            int opc;
            string cadena = string.Empty;

            while (apagador == "Si" || apagador == "si"){
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("|\t .:REGISTRO DE COMPRAS ONLINE:.       |\n|                                             |");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("|1- Registro de artículos                     |\n" +
                                  "|2- Busqueda de articulos                     |\n" +
                                  "|3- Eliminar articulo                         |\n|                                             |\n" +
                                  "|0- Salir...                                  |"); 
                Console.WriteLine("-----------------------------------------------");
                cadena = Console.ReadLine();
                opc = Convert.ToInt32(cadena);

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Procesar.AgregarDatos();
                    break;

                    case 2:
                        Console.Clear();
                        Procesar.ImprimirDatos();
                    break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\nIngresa la clave del artículo que quieres borrar.\n");
                        borrar = Console.ReadLine();
                        Procesar.EliminarElemento(borrar);
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("\n\tFINALIZANDO CODIGO...\n");
                        Console.ReadKey();
                        apagador = "No";
                    break;
                }
                Console.Clear();
            }
        }
    }
}
