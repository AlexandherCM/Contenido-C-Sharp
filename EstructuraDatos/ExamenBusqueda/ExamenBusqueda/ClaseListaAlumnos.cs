using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBusqueda
{
    internal class ClaseListaAlumnos
    {
        public void lista()
        {
            // Vinculando los diferentes archivos del programa
            ClaseAlumnos regAlumn;
            regAlumn = new ClaseAlumnos();
            //--------------------------------------------------
           
            Console.WriteLine("\t.:----- LISTA DE ALUMNOS -----:.\n");

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine((i + 1) + "- " + regAlumn.Alumnos(i.ToString()));
            }
        }
    }
}
