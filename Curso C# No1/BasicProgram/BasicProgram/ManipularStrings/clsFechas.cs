using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class clsFechas
    {
        private DateTime Hoy = DateTime.Now;

        public void imprimirFecha()
        {
            Console.WriteLine($"La fecha de hoy es: {Hoy}");
            Console.WriteLine($"La fecha completa de hoy es: {Hoy.ToString("yyyy-MM-dd-hh:mm:ss.ms")}");

            Console.WriteLine($"\nAño: {Hoy.ToString("yyyy")}");
            Console.WriteLine($"Año con year: {Hoy.Year}");
            Console.WriteLine($"\nMes: {Hoy.ToString("MMMM")}");
            Console.WriteLine($"Dia: {Hoy.ToString("dddd")}");

            Console.WriteLine($"\nHora: {Hoy.ToString("mm:ss.ms")}");
            Console.WriteLine($"Hora: {Hoy.ToString("mm:ss")}");
            Console.WriteLine($"Minuto: {Hoy.ToString("mm")}");

            Console.WriteLine($"\nFormatos de fecha");
            Console.WriteLine($"Corta: {Hoy.ToShortDateString()}");
            Console.WriteLine($"Larga: {Hoy.ToLongDateString()}");
            Console.WriteLine($"Tiempo corto: {Hoy.ToShortTimeString()}");
        }
    }
}
