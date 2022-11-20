using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TablaHash
{
    public class ProgramClash
    {
        Hashtable Tabla; // Declaro como se llama mi tabla hash

        //constructor para utilizar una tabla hash---------------------------
        public ProgramClash()
        {
            Tabla = new Hashtable();
        }
        //-------------------------------------------------------------------
        public void AgregarDatos()
        {
            string elemento = string.Empty;
            string clave = string.Empty;
            string apagador = "Si";
            string preApagador = string.Empty;

            while (apagador == "Si" || apagador == "si")
            {
                Console.WriteLine("\nIngresa el articulo de la compra online: \n");
                elemento = Console.ReadLine();
                Console.WriteLine("\nIngresa la clave de tu artículo online: \n");
                clave = Console.ReadLine();

                Tabla.Add(clave, elemento);

                //---------------------------------------

                Console.WriteLine("\n¿Quieres ingresar otro artículo?\n");
                preApagador = Console.ReadLine();

                if(preApagador == "No" || preApagador == "no")
                {
                    Console.WriteLine("\n\tIngreso de datos finalizado...\n");
                    Console.ReadKey();
                    apagador = preApagador;
                }

                if (preApagador == "Si" || preApagador == "si")
                {
                    Console.WriteLine("\n\tReiniciando....\n");
                    Console.ReadKey();
                    apagador = preApagador;
                }
                Console.Clear();
            }
        }

        //---------------------------------------

        public void ImprimirDatos()
        {
            string apagador = "Si";
            string preApagador = string.Empty;

            while (apagador == "Si" || apagador == "si")
            {
                Console.WriteLine("\nExisten {0} elementos, Ingresa la clave \n", Tabla.Count);
                string cadena = Console.ReadLine();

                if (Tabla[cadena] == null)
                {
                    Console.WriteLine("\nLa clave no se encuentra vinculada a ningún elemento :(");
                }
                else
                {
                    Console.WriteLine("\nELEMENTO ENCONTRADO.....");
                    Console.WriteLine("\n[{0}]", Tabla[cadena]);
                }
                

                Console.WriteLine("\n¿Quieres buscar otro articulo?\n");
                preApagador = Console.ReadLine();

                if (preApagador == "No" || preApagador == "no")
                {
                    Console.WriteLine("\n\tIngreso de claves finalizado....\n");
                    Console.ReadKey();
                    apagador = preApagador;
                }

                if (preApagador == "Si" || preApagador == "si")
                {
                    Console.WriteLine("\n\tReiniciando....\n");
                    Console.ReadKey();
                    apagador = preApagador;
                }

                Console.Clear();
            }
        }

        //---------------------------------------

        //En el parametro coloco el dato o clave que vincula a el elemento y así eliminarle de la tabla
        public void EliminarElemento(string key)
        {
            if (Tabla[key] == null)
            {
                Console.WriteLine("\nLa clave no se encuentra vinculada a ningún artículo!!! >:(");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("\n\tElemento eliminado...");
                Console.WriteLine("\n[{0}]", Tabla[key]);
                Tabla.Remove(key);
                Console.WriteLine("\n\tEliminación de datos finalizado...\n");
                Console.ReadKey();
            }     
        }
    }
}
