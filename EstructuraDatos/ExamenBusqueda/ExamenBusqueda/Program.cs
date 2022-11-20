using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ExamenBusqueda
{
    public class Program
    {
        Hashtable Tabla; // Declaro como se llama mi tabla hash

        //constructor para utilizar una tabla hash---------------------------
        public Program()

        {
            Tabla = new Hashtable();
        }
        static void Main(string[] args)
        {
            //listAlumn.lista();  --> Método // Desglose de la lista de alumnos
            //Tabla.TablaHash();  --> Método // Creación Y llenado de tabals hash
            //Tabla.notasAltas(); --> Método // Desglose de las notas más altas

            string apagador = "No";
            string opc;
            //string cadena = string.Empty;

            while (apagador == "No" || apagador == "no")
            {
                //Vinculando los diferentes archivos del programa
                ClaseListaAlumnos listAlumn;
                listAlumn = new ClaseListaAlumnos();

                ClaseHash Tabla;
                Tabla = new ClaseHash();
                //--------------------------------------------------

                Console.WriteLine("\t-----.:GESTIÒN ESTUDIANTIL:.-----\n\n");
                Console.WriteLine("1- Vizualizar la lista de estudiantes\n" +
                                  "2- Consultar las calificaciones de un alumno\n" +
                                  "3- Consultar las notas mas altas\n\n" +
                                  "0- Salir\n\n" + 
                                  "<<INGRESA EL NUMERO DE LA OPCIÓN QUE REQUIERAS>> ");
                opc = Console.ReadLine();
                //opc = int.Parse(Console.ReadLine()); // --> Opción uno para convertir un string a un entero

                /*cadena = Console.ReadLine();       // --> Opción dos para convertir un string a un entero
                opc = Convert.ToInt32(cadena);*/

                Console.Clear();

                switch (opc)
                {
                    case "1":
                        listAlumn.lista();
                        Console.WriteLine("\t\n----- PRESIONA CUALQUIER TECLA PARA CONTINUAR -----\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Tabla.TablaHash();
                        break;
                    case "3":
                        Console.WriteLine("\t----- .:ALUMNOS CON MAYOR CALIFICACIÒN:.-----\n\n");
                        Tabla.notasAltas();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("\t----- .:CODIGO FINALIZADO:.-----\n");
                        Console.ReadKey();
                        apagador = "SI";
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\t----- ¡¡DATO INVALIDO!! -----\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
