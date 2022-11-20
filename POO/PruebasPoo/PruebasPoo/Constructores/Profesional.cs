using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPoo.Constructores
{
    public class Profesional
    {
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public int Edad { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: " + Nombre + "\n" +
                              "Titulo: " + Titulo + "\n" +
                              "Edad: " + Edad);
        }
    }

    public class Profesor : Profesional
    {
        public string Materia { get; set; }
        public int Aula { get; set; }

        public void ReporteProfe()
        {
            Mostrar();
            Console.WriteLine("Materia: " + Materia + "\n" +
                              "Aula: " + Aula + "\n" + 
                              "Nombre: " + Nombre);
        }

    }
}
