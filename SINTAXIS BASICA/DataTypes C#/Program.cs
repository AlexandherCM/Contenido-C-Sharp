using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCsharp{
    class Program{
        static void Main(string[] args){

            //--> Puede variar

            // Console.WriteLine("TEXTO"); --> Para imprimir
            Console.WriteLine("Hola mundo");
            //Console.ReadKey(); // --> FINALIZA AL PRESIONAR

            int i = 5;
            decimal x = 3.10m; // -->pocos digitos despues del .
            float f = 5.548f; // -->Mayor presición
            double d = 5.5644d; // -->Muchos digitos despues del .

            string cadena = "Hola";
            bool estado = false;
            
            DateTime fecha = DateTime.MinValue; //--> Fecha y hora

            Console.WriteLine("Valores: {0}, {1}, {2}, {3}, {4}, {5}", i, x, f, d, cadena, estado);
            Console.WriteLine("Cadena: " + cadena + ", " + estado.ToString());
            // .ToString() --> Este metodo convierte el dato y le adapta a cadena

            Console.WriteLine("Fecha: " + fecha.ToString());
            Console.WriteLine("Fecha: " + fecha.ToShortDateString());
            Console.WriteLine("Fecha: " + fecha.ToShortTimeString());


            Console.ReadKey();
            //-----------------------------------------------
        }
    }
}