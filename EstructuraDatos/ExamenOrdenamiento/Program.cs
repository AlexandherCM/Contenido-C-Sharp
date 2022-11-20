using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdenamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {//ESPACIO INICIAL DE CODIFICACIÓN DEL METODO PRINCIPAL MAIN --------------------------------------------------------------

            ClasePeliculas peliculas = new ClasePeliculas();
            ClaseQuickSort Ordenar = new ClaseQuickSort();
            NamesPeliculas Pelinames = new NamesPeliculas();
            ClaseSalaPeli MejorCombinacion = new ClaseSalaPeli();    
            //Peliculas retornadas en el contenedor momentáneo---------------------
            int[] ClientSala = new int[9];
            //Contenedor fijo de peliculas actualizables por sala -----------------
            int[] actualizaClientes1 = new int[9];
            int[] actualizaClientes2 = new int[9];
            int[] actualizaClientes3 = new int[9];
            int[] actualizaClientes4 = new int[9];
            // Nombre de las peliculas retornadas de la clase NamesPeliculas------------- 
            string[] NombrePeli = new string[8];
            NombrePeli = Pelinames.nombres();

            // Numero total de clientes en la sala --------------------------------------
            int[] totalSala = new int[5]; //--> CASE 5 numero extra para ajustar QuickSort
            //---------------------------------------------------------------------------
            // suma total de las peliculas en todas las salas----------------------------
            int[] totalesPeli = new int[9];     // --> Aqui almacenos las ventas totales de las peliculas de todas las salas 

            // CONTENEDORES DE POSICIONES - ENTRADAS-----------------------------------------------------------------------------------------------
            int[] VentaMayorPS1 = new int[1];     // --> Aqui almaceno la posición del numero de entradas de la pelicula mas vista de cada sala
            int[] VentaMayorPS2 = new int[1];
            int[] VentaMayorPS3 = new int[1];
            int[] VentaMayorPS4 = new int[1];
            // -----------------------------------------------------------------------------------------------------------------------------------

            bool estado = true;
            string opc;

            while (estado == true)
            {//INICIO WHILE
                Console.WriteLine("\t- - - - - ..::BASE DE DATOS DE CINEMAX ;3 ::.. - - - - -\n\n");
                Console.WriteLine("Ingresa el numero de la sala en la que deseas llevar a cabo el registro de clientes\n");
                Console.WriteLine("1- Sala uno                                                    \n" +
                                  "2- Sala dos                                                    \n" +
                                  "3- Sala tres                                                   \n" +
                                  "4- Sala cuatro                                                 \n\n" +
                                  "\t- - - - - ..:: OPCIONES DE RECOPILACIÓN DE DATOS ::.. - - - - -\n\n" +
                                  "5- Clientes totales por sala                                   \n" +
                                  "6- Clientes ordenados por sala y peliculas                     \n" +
                                  "7- Resultados obtenidos                                        \n" +
                                  "8- REINICIAR REGISTROS                                         \n" +
                                  "\n0- SALIR                                                     \n" +
                                  "\n<<INGTRESA TU OPCIÓN DEBAJO DEL APARTADO>>");
                opc = Console.ReadLine();
                Console.Clear();

                switch (opc)
                {//INICIO SWITCH
                    case "1":
                        Console.WriteLine("\n\t      - - - -  ..:: SALA 1 ::.. - - - -           \n\n");
                        ClientSala = peliculas.peliculas(); //Asigno los valores a el arreglo de la función principal para transportarlos a la misma hora que le mando a llamar

                        for (int i = 0; i < ClientSala.Length; i++)
                        {
                            actualizaClientes1[i] += ClientSala[i]; // Sumo y reasigno valores con el for en el arreglo para generar un conteo actualizable
                        } // --> Repito lo anterior en los demás cases

                        break;
                    case "2":
                        Console.WriteLine("\n\t      - - - -  ..:: SALA 2 ::.. - - - -           \n\n");
                 
                        ClientSala = peliculas.peliculas();

                        for (int i = 0; i < ClientSala.Length; i++)
                        {
                            actualizaClientes2[i] += ClientSala[i];
                        }

                        break;
                    case "3":
                        Console.WriteLine("\n\t      - - - -  ..:: SALA 3 ::.. - - - -           \n\n");
                        ClientSala = peliculas.peliculas();

                        for (int i = 0; i < ClientSala.Length; i++)
                        {
                            actualizaClientes3[i] += ClientSala[i];
                        }

                        break;
                    case "4":
                        Console.WriteLine("\n\t      - - - -  ..:: SALA 4 ::.. - - - -           \n\n");
                        ClientSala = peliculas.peliculas();

                        for (int i = 0; i < ClientSala.Length; i++)
                        {
                            actualizaClientes4[i] += ClientSala[i];
                        }

                        break;
                    case "5": //CLIENTES TOTALES POR SALA - - - - - - - - - - - - - - - - - - - - - - 
                        Console.Clear(); // La ultima posición reprecenta la suma total de entradas en la sala en cuestión
                        totalSala[0] = actualizaClientes1[8];
                        totalSala[1] = actualizaClientes2[8];
                        totalSala[2] = actualizaClientes3[8];
                        totalSala[3] = actualizaClientes4[8];

                        Console.WriteLine("\n\t- - - - - ..:: NUMERO DE CLIENTES TOTALES REGISTRADOS EN LAS SALAS ::.. - - - - -\n");

                        for (int i = 0; i < totalSala.Length - 1; i++) // ajusto el menos uno para solo imprimir hasta la posición 3
                        {
                            Console.WriteLine("Numero de clientes TOTALES que ingresaron en la sala " + (i + 1) + "\n" + totalSala[i] + "\n");
                        }

                        Console.WriteLine("\t.:Numeros ordenados de mayor a menor:.\n");
                        Ordenar.QuickSort(totalSala);

                        Console.WriteLine("\n\t- - - - - ..:: PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        Console.Clear();
                        break; //Case testeo - - - - - - - - - - - - - - - - - - - - - - 

                    case "6": // PELICULAS ORDENADAS DE LA MENOS VISTA A LA MAS VISTA - - - - - - - - - - - - - - - - - - - - - - 
                        Console.Clear();
                        Console.WriteLine("\n\t- - - - - ..:: NUMERO DE CLIENTES REGISTRADOS DE LAS SALAS ORDENADOS DEL MAYOR AL MENOR::.. - - - - -\n");

                        Console.WriteLine("VENTA DE ENTRADAS ORDENADAS DE LA SALA 1");
                        Ordenar.QuickSort(actualizaClientes1);

                        Console.WriteLine("\n");

                        Console.WriteLine("VENTA DE ENTRADAS ORDENADAS DE LA SALA 2");
                        Ordenar.QuickSort(actualizaClientes2);
                        Console.WriteLine("\n");

                        Console.WriteLine("VENTA DE ENTRADAS ORDENADAS DE LA SALA 3");
                        Ordenar.QuickSort(actualizaClientes3);
                        Console.WriteLine("\n");

                        Console.WriteLine("VENTA DE ENTRADAS ORDENADAS DE LA SALA 4");
                        Ordenar.QuickSort(actualizaClientes4);
                        Console.WriteLine("\n");
                        Console.WriteLine("\n\t- - - - - ..::PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        Console.Clear();
                        break; //Case testeo - - - - - - - - - - - - - - - - - - - - - - 
                    case "7":
                        Console.Clear();
                        Console.WriteLine("\n\t- - - - - ..:: RESULTADOS IMPORTANTES ::.. - - - - -\n");
                        int masVista = 0;
                        int indice = 0;

                        for (int i = 0; i < totalesPeli.Length - 1; i++) // --> Suma de todas las peliculas de las salas 
                        {
                            totalesPeli[i] = (actualizaClientes1[i] + actualizaClientes2[i] + actualizaClientes3[i] + actualizaClientes4[i]);
                            Console.WriteLine("Ventas totales de " + NombrePeli[i] + "\n" + totalesPeli[i] + "\n");
                        }

                        for (int i = 0; i < totalesPeli.Length - 1; i++) // Comparativa de la entrada mas vendida
                        {
                            if (totalesPeli[i] > masVista)
                            {
                                masVista = totalesPeli[i]; // --> Numero de entradas mayores
                                indice = i;
                            }
                        }

                        if (masVista == 0)
                        {
                            Console.WriteLine("\n\t- - - - - ..::NO HAY VENTAS REGISTRADAS::.. - - - - -\n");
                        }
                        else
                        {
                            Console.WriteLine("\tLa pelicula mas vista de todo el cine es: " + NombrePeli[indice] + " con " + totalesPeli[indice] + " entradas vendidas.\n");

                            // --------------------------------------------------------------------------------------------------------------------------------------------------
                            Console.WriteLine("\n\t- - - - - ..;; Peliculas mas vistas de cada sala ::.. - - - - -\n");

                           
                            Console.WriteLine("\nPELICULA MAS VISTA DE LA SALA 1");
                            VentaMayorPS1 = MejorCombinacion.mejorSalaP(actualizaClientes1); // --> OBTENGO EL INDICE A MANEJAR

                            if(actualizaClientes1[VentaMayorPS1[0]] == 0){
                                Console.WriteLine("\tNO HAY VENTAS EN ESTA SALA\n");
                            }
                            else
                            {
                                Console.WriteLine("Función numero: [" + (VentaMayorPS1[0] + 1) + "]"); //Mejor Función de la sala 1
                            }
                            

                            // --------------------------------------------------------------------------------------------------------------------------------------------------
                            Console.WriteLine("\nPELICULA MAS VISTA DE LA SALA 2");
                            VentaMayorPS2 = MejorCombinacion.mejorSalaP(actualizaClientes2);

                            if (actualizaClientes2[VentaMayorPS2[0]] == 0)
                            {
                                Console.WriteLine("\tNO HAY VENTAS EN ESTA SALA\n");
                            }
                            else
                            {
                                Console.WriteLine("Función numero: [" + (VentaMayorPS2[0] + 1) + "]"); //Mejor Función de la sala 2
                            }
                            // --------------------------------------------------------------------------------------------------------------------------------------------------
                            Console.WriteLine("\nPELICULA MAS VISTA DE LA SALA 3");
                            VentaMayorPS3 = MejorCombinacion.mejorSalaP(actualizaClientes3);

                            if (actualizaClientes3[VentaMayorPS3[0]] == 0)
                            {
                                Console.WriteLine("\tNO HAY VENTAS EN ESTA SALA\n");
                            }
                            else
                            {
                                Console.WriteLine("Función numero: [" + (VentaMayorPS3[0] + 1) + "]"); //Mejor Función de la sala 3
                            }
                            // --------------------------------------------------------------------------------------------------------------------------------------------------
                            Console.WriteLine("\nPELICULA MAS VISTA DE LA SALA 4");
                            VentaMayorPS4 = MejorCombinacion.mejorSalaP(actualizaClientes4);
                            if (actualizaClientes3[VentaMayorPS3[0]] == 0)
                            {
                                Console.WriteLine("\tNO HAY VENTAS EN ESTA SALA\n");
                            }
                            else
                            {
                                Console.WriteLine("Función numero: [" + (VentaMayorPS4[0] + 1) + "]"); //Mejor Función de la sala 4
                            }
                            // --------------------------------------------------------------------------------------------------------------------------------------------------
                            int[] topFunciones = new int[4]; // --> AQUI ALMACENO LAS FUNCIONES MAS VISTAS DE CADA SALA

                            int masVistaFinal = 0;
                            int indiceFinal = 0;

                            topFunciones[0] = actualizaClientes1[VentaMayorPS1[0]]; // --> SALA 1 / P0 Esta el numero de posición de las entradas y el nombre
                            topFunciones[1] = actualizaClientes2[VentaMayorPS2[0]]; // --> SALA 2 / P2 Esta el numero de posición de las entradas y el nombre
                            topFunciones[2] = actualizaClientes3[VentaMayorPS3[0]]; // --> SALA 3 / P3 Esta el numero de posición de las entradas y el nombre
                            topFunciones[3] = actualizaClientes4[VentaMayorPS4[0]]; // --> SALA 4 / P4 Esta el numero de posición de las entradas y el nombre
                                
                            for (int i = 0; i < topFunciones.Length; i++) // Comparativa de la entrada mas vendida
                            {
                                if (topFunciones[i] > masVistaFinal)
                                {
                                    masVistaFinal = topFunciones[i]; // --> Numero de entradas mayores
                                    indiceFinal = i;
                                }
                            }

                            Console.WriteLine("\n\t- - - - - - - - -..:: MEJOR COMBINACIÓN DE SALA/PELICULA EN CINEMAX ;3 ::.. - - - - - - - - -\n");

                            switch (indiceFinal) //INICIO SWITCH INTERNO
                            {
                                case 0:
                                    //ARRASTRO EL INCICE OBTENIDO PREVIAMENTE POR EL METODO <<MejorCombinacion.mejorSalaP(actualizaClientes"n_ numero");>>
                                    Console.WriteLine("\n<<- - - - - - - - - - ..:: SALA 1 ::.. - - - - - - - - - ->>\n");
                                    Console.WriteLine("¡¡¡PELICULA: " + NombrePeli[VentaMayorPS1[0]] + " con " + actualizaClientes1[VentaMayorPS1[0]] + " entradas vendidas!!!\n");
                                    break;
                                case 1:
                                    Console.WriteLine("\n<<- - - - - - - - - - ..:: SALA 2 ::.. - - - - - - - - - ->>\n");
                                    Console.WriteLine("¡¡¡PELICULA: " + NombrePeli[VentaMayorPS2[0]] + " con " + actualizaClientes2[VentaMayorPS2[0]] + " entradas vendidas!!!\n");
                                    break;
                                case 2:
                                    Console.WriteLine("\n<<- - - - - - - - - - ..:: SALA 3 ::.. - - - - - - - - - ->>\n");
                                    Console.WriteLine("¡¡¡PELICULA: " + NombrePeli[VentaMayorPS3[0]] + " con " + actualizaClientes3[VentaMayorPS3[0]] + " entradas vendidas!!!\n");
                                    break;
                                case 3:
                                    Console.WriteLine("\n<<- - - - - - - - - - ..:: SALA 4 ::.. - - - - - - - - - ->>\n");
                                    Console.WriteLine("¡¡¡PELICULA: " + NombrePeli[VentaMayorPS4[0]] + " con " + actualizaClientes4[VentaMayorPS4[0]] + " entradas vendidas!!!\n");
                                    break;
                                default:
                                    Console.WriteLine("\n\t<<- - - - - - - - - - ..:: ¡¡¡OH NO HA OCURRIDO UN ERROR EN LA ENTRADA DE DATOS!!! ::.. - - - - - - - - - ->>\n");
                                    break;
                            } //FIN SWITCH INTERNO
                        }//FIN ELSE
                        Console.WriteLine("\n\t- - - - - ..::PRESIONE CUALQUIER TECLA PARA CONTINUAR ::.. - - - - -\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "8": // --> VACIADO DE DATOS
                        Console.Clear();
                        for (int i = 0; i < ClientSala.Length; i++)
                        {
                            actualizaClientes1[i] = 0;
                        }

                        for (int i = 0; i < ClientSala.Length; i++)
                        {
                            actualizaClientes2[i] = 0;
                        }

                        for (int i = 0; i < ClientSala.Length; i++)
                        {
                            actualizaClientes3[i] = 0;
                        }

                        for (int i = 0; i < ClientSala.Length; i++)
                        {
                            actualizaClientes4[i] = 0;
                        }

                        Console.WriteLine("\t\n- - - - - ..::REGISTROS VACIADOS EN TODAS LAS SALAS::.. - - - - - \n");


                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "0":
                        Console.Clear();    
                        Console.WriteLine("\n\t- - - - - ..::PROGRAMA FINALIZADO ::.. - - - - -\n");
                        Console.ReadKey();
                        estado = false; 
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\t\n- - - - - ¡¡¡DATO INVALIDO!!! - - - - -\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }//FIN SWITCH
            }//FIN WHILE
        }//ESPACIO FINAL DE CODIFICACIÓN DEL METODO PRINCIPAL MAIN --------------------------------------------------------------
    }
}