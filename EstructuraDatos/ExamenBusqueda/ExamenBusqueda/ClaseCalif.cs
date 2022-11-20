using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBusqueda
{
    internal class ClaseCalif
    {
        public int Notas(int num)
        {
            int numero = Convert.ToInt32(num);
            int[] calificaciones = new int[30]; //El nombre del contenedor de alumnos

            calificaciones[0] = 10;
            calificaciones[1] = 9;
            calificaciones[2] = 9;
            calificaciones[3] = 8;
            calificaciones[4] = 6;
            calificaciones[5] = 7;
            calificaciones[6] = 10;
            calificaciones[7] = 7;
            calificaciones[8] = 9;
            calificaciones[9] = 8;
            calificaciones[10] = 9;
            calificaciones[11] = 8;
            calificaciones[12] = 9;
            calificaciones[13] = 9;
            calificaciones[14] = 9;
            calificaciones[15] = 8;
            calificaciones[16] = 9;
            calificaciones[17] = 6;
            calificaciones[18] = 7;
            calificaciones[19] = 10;
            calificaciones[20] = 7;
            calificaciones[21] = 10;
            calificaciones[22] = 10;
            calificaciones[23] = 9;
            calificaciones[24] = 10;
            calificaciones[25] = 10;
            calificaciones[26] = 8;
            calificaciones[27] = 8;
            calificaciones[28] = 9;
            calificaciones[29] = 9;

            return calificaciones[num];
        }
    }
}
