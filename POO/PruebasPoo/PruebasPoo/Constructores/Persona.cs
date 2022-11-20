using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPoo.Constructores
{
    public class Persona
    {
        private string Nombre { get; set; }
        private int Edad { get; set; }

        public Persona(string Nombre, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }

        public void Datos()
        {
            Console.WriteLine("Nombre: " + Nombre + "\n" + "Edad: " + Edad);
        }
    }

    public class Trabajador : Persona
    {
        private string RFC { get; set; }
        private decimal SueldoDiario { get; set; }

        // La herencia se crea en el constructor, este recolecta el espacio de los datos y se vinculan con la palabra clave (base)
        public Trabajador(string Nombre, int Edad, string RFC, decimal SueldoDiario) : base(Nombre, Edad)
        {
            this.RFC = RFC;
            this.SueldoDiario = SueldoDiario;
        }

        public void CalculoSueldoMes(int dias)
        {
            Datos(); // Clase padre
            Console.WriteLine(
                "RFC: " + RFC + "\n" +
                "Sueldo diario del trabajador: " + SueldoDiario + "\n" +
                "Dias de cotización: " + dias + "\n" +
                "Suelo cotizado: " + SueldoDiario * dias);
        }


    }
}
