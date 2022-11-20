using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExamenBusqueda
{
    internal class ClaseHash
    {
        Hashtable Tabla; // Declaro como se llama mi tabla hash

        //constructor para utilizar una tabla hash---------------------------
        public ClaseHash()

        {
            Tabla = new Hashtable();
        }
        //-------------------------------------------------------------------

        public void TablaHash()
        {
            // Vinculando los diferentes archivos del programa
            ClaseAlumnos regAlumn;
            regAlumn = new ClaseAlumnos();

            ClaseCalif califics;
            califics = new ClaseCalif();

            ClaseListaAlumnos listAlumn;
            listAlumn = new ClaseListaAlumnos();

            //-------------------------------------------------------------------
            // Este for se encarga de lenar la tabla hash con sus respectiva clave del alumno, la cual es su numero de lista
            for (int clv = 0; clv < 30; clv++)
            {
                string pasword = (clv + 1).ToString();
                Tabla.Add(pasword, "\nNombre: " + regAlumn.Alumnos(clv.ToString()) + "\nCalificación: " + califics.Notas(clv) + "\n" + "Numero de lista: " + (clv + 1));
            }

            string apagar = "Si";
            string clave = string.Empty;

            while(apagar == "Si" || apagar == "si")
            {
                listAlumn.lista();
                Console.WriteLine("\nConsulta las calificaciones de un estudiante ingresando su numero de lista: ");
                clave = Console.ReadLine();
                Console.Clear();

                if(Tabla[clave] == null)
                {
                    Console.WriteLine("\t----- El numero ingresado no corresponde a ningún alumno :( -----\n\n");
                }
                else
                {
                    listAlumn.lista();
                    Console.WriteLine(Tabla[clave]);
                    Console.WriteLine("\n¿Quieres buscar las notas de otro alumno? (Ingresa [si o no] según sea el caso");
                    apagar = Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public void notasAltas()
        {
            ClaseCalif califics;
            califics = new ClaseCalif();

            ClaseAlumnos regAlumn;
            regAlumn = new ClaseAlumnos();

            //-------------------------------------------------------------------
            // Este for se encarga de lenar la tabla hash con sus respectiva clave del alumno, la cual es su numero de lista
            for (int clave = 0; clave < 30; clave++)
            {
                string pasword = (clave + 1).ToString();
                Tabla.Add(pasword, "\nNombre: " + regAlumn.Alumnos(clave.ToString()) + "\nCalificación: " + califics.Notas(clave) + "\n" + "Numero de lista: " + (clave + 1) + "\n");
            }
            //-------------------------------------------------------------------

            string[] total = new string[30];

            for (int i = 0; i < total.Length; i++)
            {
                if (califics.Notas(i) == 10)
                {

                    total[i] = "Bandera";
                }
            }

            //-------------------------------------------------------------------

            for (int i = 0; i < total.Length; i++)
            {
                if(total[i] == "Bandera")
                {
                    string clave = (i + 1).ToString();

                    Console.WriteLine(Tabla[clave]);    
                }
            }
            Console.WriteLine("\t\n----- PRESIONA CUALQUIER TECLA PARA CONTINUAR -----\n");
        }
    }
}
