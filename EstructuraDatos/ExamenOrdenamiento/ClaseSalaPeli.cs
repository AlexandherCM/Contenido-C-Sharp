using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdenamiento
{
    internal class ClaseSalaPeli
    {
        public int[] mejorSalaP(int[] combinacion)
        {
            ClaseQuickSort ordenar = new ClaseQuickSort();
            NamesPeliculas Pelinames = new NamesPeliculas();

            int masVista = 0; // --> Entradas totales de la pelicula mas vista

            int[] indice = new int[1];
            indice[0] = 0;   // --> Numero de posición de la entrada y el nombre de la pelicula // VALOR IMPORTANTE A RETORNAR

            string[] nombre = new string[combinacion.Length - 1]; 
            nombre = Pelinames.nombres(); //VINCULO DE LA CLASE QUE TIENE LOS NOMBRES EN EL ARREGLO

            for (int i = 0; i < combinacion.Length - 1; i++) // Comparativa de la entrada mas vendida
            {
                if (combinacion[i] > masVista)
                {
                    masVista = combinacion[i]; // --> Numero de entradas mayores
                    indice[0] = i;
                }
            }

            Console.WriteLine("La pelicula mas vista de la sala es: [" + nombre[indice[0]] + "] con " + combinacion[indice[0]] + " entradas");

            return indice;
        }
    }
}
