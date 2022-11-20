using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdenamiento
{
    internal class ClasePeliculas
    {
        public int[] peliculas()
        {
            bool estado = true;
            string opc;
            //Variables--------------------------------
            string nombreP = string.Empty;
            int contInterno;
            //-----------------------------------------

            
            int[] vistaPelis = new int[9]; // --> Hasta la posición 7 esta el numero total de cada pelicula de la sala
                                           // --> Almaceno las personas totales de la sala en la posición 8
            //-----------------------------------------

            while (estado == true)
            {//INICIO WHILE
                Console.WriteLine("\t- - - - - ..::FUNCIONES DE CINEMAX ;3 ::.. - - - - -\n\n");
                Console.WriteLine("Ingresa el numero de la pelicula en la que deseas llevar a cabo el registro de clientes\n");
                Console.WriteLine("1- Spider Man No way home     \n" +
                                  "2- Sound of Metal             \n" +
                                  "3- Dragon Ball Z              \n" +
                                  "4- God Of War                 \n" +
                                  "5- Votos de amor              \n" +
                                  "6- Casino Royale              \n" +
                                  "7- Kung Fu Panda              \n" +
                                  "8- Hachiko                    \n" +
                                  "\n9- Registro actual            \n" +
                                  "\n0- REGRESAR                 \n" +
                                  "\n<<INGTRESA TU OPCIÓN DEBAJO DEL APARTADO>>");
                opc = Console.ReadLine();
                Console.Clear();

                switch (opc)
                {//INICIO SWITCH
                    case "1" :
                        nombreP = "Spider Man No way home";
                        Console.WriteLine("Igresa el numero de personas que entraron a ver {0}", nombreP);
                        contInterno = int.Parse(Console.ReadLine());

                        vistaPelis[0] += contInterno; //Sumo y reasigno el valor del numero de personas que vieron la función en su respectiva posición del arreglo
                        vistaPelis[8] += contInterno; //Con el numero almacenado en el arreglo, ahora sumo y reasino el dato que me servira para obtener las vistas totales de la sala

                        Console.WriteLine("\n\t- - - - - ..:: [VENTAS REGISTRADAS] PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        /*- - - - - - - - - -*/
                        Console.Clear(); /*- - - - - - - - - -*/
                        break;
                    case "2":
                        nombreP = "Sound of Metal";
                        Console.WriteLine("Igresa el numero de personas que entraron a ver {0}", nombreP);
                        contInterno = int.Parse(Console.ReadLine());

                        vistaPelis[1] += contInterno;
                        vistaPelis[8] += contInterno;

                        Console.WriteLine("\n\t- - - - - ..:: [VENTAS REGISTRADAS] PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        /*- - - - - - - - - -*/
                        Console.Clear(); /*- - - - - - - - - -*/
                        break;
                    case "3":
                        nombreP = "Dragon Ball Z ";
                        Console.WriteLine("Igresa el numero de personas que entraron a ver {0}", nombreP);
                        contInterno = int.Parse(Console.ReadLine());

                        vistaPelis[2] += contInterno;
                        vistaPelis[8] += contInterno;

                        Console.WriteLine("\n\t- - - - - ..:: [VENTAS REGISTRADAS] PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        /*- - - - - - - - - -*/
                        Console.Clear(); /*- - - - - - - - - -*/
                        break;
                    case "4":
                        nombreP = "God Of War";
                        Console.WriteLine("Igresa el numero de personas que entraron a ver {0}", nombreP);
                        contInterno = int.Parse(Console.ReadLine());

                        vistaPelis[3] += contInterno;
                        vistaPelis[8] += contInterno;

                        Console.WriteLine("\n\t- - - - - ..:: [VENTAS REGISTRADAS] PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        /*- - - - - - - - - -*/
                        Console.Clear(); /*- - - - - - - - - -*/
                        break;
                    case "5":
                        nombreP = "Votos de amor";
                        Console.WriteLine("Igresa el numero de personas que entraron a ver {0}", nombreP);
                        contInterno = int.Parse(Console.ReadLine());

                        vistaPelis[4] += contInterno;
                        vistaPelis[8] += contInterno;

                        Console.WriteLine("\n\t- - - - - ..:: [VENTAS REGISTRADAS] PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        /*- - - - - - - - - -*/
                        Console.Clear(); /*- - - - - - - - - -*/
                        break;
                    case "6":
                        nombreP = "Casino Royale";
                        Console.WriteLine("Igresa el numero de personas que entraron a ver {0}", nombreP);
                        contInterno = int.Parse(Console.ReadLine());

                        vistaPelis[5] += contInterno;
                        vistaPelis[8] += contInterno;

                        Console.WriteLine("\n\t- - - - - ..:: [VENTAS REGISTRADAS] PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        /*- - - - - - - - - -*/
                        Console.Clear(); /*- - - - - - - - - -*/
                        break;
                    case "7":
                        nombreP = "Kung Fu Panda";
                        Console.WriteLine("Igresa el numero de personas que entraron a ver {0}", nombreP);
                        contInterno = int.Parse(Console.ReadLine());

                        vistaPelis[6] += contInterno;
                        vistaPelis[8] += contInterno;

                        Console.WriteLine("\n\t- - - - - ..:: [VENTAS REGISTRADAS] PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        /*- - - - - - - - - -*/
                        Console.Clear(); /*- - - - - - - - - -*/
                        break;
                    case "8":
                        nombreP = "Hachiko";
                        Console.WriteLine("Igresa el numero de personas que entraron a ver {0}", nombreP);
                        contInterno = int.Parse(Console.ReadLine());

                        vistaPelis[7] += contInterno;
                        vistaPelis[8] += contInterno;

                        Console.WriteLine("\n\t- - - - - ..:: [VENTAS REGISTRADAS] PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        /*- - - - - - - - - -*/Console.Clear(); /*- - - - - - - - - -*/
                        break;
                    case "0":
                        Console.WriteLine("\n\t- - - - - ..::PRESIONE CUALQUIER TECLA PARA REGRESAR ::.. - - - - -\n");
                        Console.ReadKey();
                        Console.Clear();
                        estado = false;
                        break;
                    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
                    case "9": //Case de testeo
                        Console.WriteLine("\tCLIENTES REGISTRADOS EN ESTA UNICA OCACIÓN\n\n");
                        for (int i = 0; i < vistaPelis.Length - 1; i++)
                        {
                            Console.WriteLine("Pelicula: "+ (i + 1) + " - " +  vistaPelis[i]);
                        }
                        Console.WriteLine("\nClientes totales: " + vistaPelis[8]);

                        Console.WriteLine("\n\t- - - - - ..:: PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
                    default:
                        Console.Clear();
                        Console.WriteLine("\t\n- - - - - ¡¡¡DATO INVALIDO!!! - - - - -\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }//FIN SWITCH
            }//FIN WHILE

            return vistaPelis;
        }
    }
}
