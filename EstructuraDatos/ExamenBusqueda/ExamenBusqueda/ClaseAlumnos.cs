using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBusqueda
{
    internal class ClaseAlumnos
    {
        public string Alumnos(string elAlumno)
        {
            int numero = Convert.ToInt32(elAlumno);
            string[] alumno = new string[30]; //El nombre del contenedor de alumnos

            alumno[0] = "Alexandher";
            alumno[1] = "Valeria";
            alumno[2] = "Aaron";
            alumno[3] = "Maximiliano";
            alumno[4] = "David";
            alumno[5] = "Erick";
            alumno[6] = "Estrella";
            alumno[7] = "Angel";
            alumno[8] = "Ernesto";
            alumno[9] = "Daniela";
            alumno[10] = "Evaristo";
            alumno[11] = "Kitzia";
            alumno[12] = "Julieta";
            alumno[13] = "Alejandra";
            alumno[14] = "Cristian";
            alumno[15] = "Carlos";
            alumno[16] = "Emanuel";
            alumno[17] = "Gael";
            alumno[18] = "Yael";
            alumno[19] = "Leonardo";
            alumno[20] = "Tania";
            alumno[21] = "Avril";
            alumno[22] = "Ariana";
            alumno[23] = "Fatima";
            alumno[24] = "Luis Miguel";
            alumno[25] = "Brayan";
            alumno[26] = "Nadia";
            alumno[27] = "Ericka";
            alumno[28] = "Aidet";
            alumno[29] = "Eduardo";

            return alumno[numero];
        }
    }
}
