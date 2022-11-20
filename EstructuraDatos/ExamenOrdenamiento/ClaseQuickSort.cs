using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdenamiento
{
    internal class ClaseQuickSort
    {
        public int[] QuickSort(int[] arreglos)
        {
            llenar Arr = new llenar(arreglos); // --> Paso el parametro del arreglo en cuestión

            return arreglos;
        }
    }
    class llenar
    {
        int h;
        int[] vector;
        public llenar(int[] array)
        {
            h = array.Length - 1;
            vector = new int[h];

            for (int i = 0; i < h; i++)
            {
                vector[i] = array[i];
            }
            quicksort(vector, 0, h - 1);
            mostrar();
        }

        private void quicksort(int[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }

        private void mostrar()
        {
            for (int i = h; i > 0; i--)
            {
                Console.Write("{0} ", vector[i - 1]); //MODIFICADO PARA QUE ORDENE DE MAYOR A MENOR
            }
            //Console.ReadLine();
        }
    }
}


