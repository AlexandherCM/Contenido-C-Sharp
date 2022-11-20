using PruebasPoo.Constructores;
using PruebasPoo.Interfaces;
using PruebasPoo.Polimorfismo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPoo
{   
    public class program
    {
        static void Main(String[] args)
        {
            Console.Clear();

            //DateTime fecha = new DateTime(2003, 3, 29, 10, 10, 50);
            //DateTime fecha2 = fecha.AddMinutes(20);

            //Console.WriteLine(fecha2);

            Epoch epoch = new Epoch();

            //Dictionary<String, int> Edad = new Dictionary<String, int>()
            //{
            //    {"Alex" ,19 },
            //    {"Alex2",15 },
            //    {"Alex3",48 },
            //    {"Alex4",34 },
            //};

            //foreach (KeyValuePair<String,int>Busqueda in Edad)
            //{
            //    Console.WriteLine(Busqueda.Key + ": " + Busqueda.Value);
            //}

            //int[] datos = new int[5];

            //for (int i = 0; i < datos.Length; i++)
            //{
            //    datos[i] = (i + 1);
            //}

            //Console.WriteLine("\n");

            //foreach (int busqueda in datos)
            //{
            //    Console.WriteLine(busqueda);
            //}


            Console.WriteLine("\nCreación: " + epoch.convertirFecha(1667808081));

            Console.WriteLine("\nExpira: " + epoch.convertirFecha(1667808201));
            

            Console.ReadKey(); 
        }

        
    }
    public class Epoch
    {
        //Obtengo los segundos totales
        public double convertirEpoch(DateTime fecha)
        {
            DateTime fechaInicial = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            double epoch = Math.Round((fecha.ToUniversalTime() - fechaInicial).TotalSeconds, 0);

            return epoch;
        }

        //Obtengo la fecha concreta a la que hace referencia el epoch
        public DateTime convertirFecha(double epoch)
        {
            DateTime fechaInicial = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            fechaInicial = fechaInicial.AddSeconds(epoch).ToLocalTime();

            return fechaInicial;
        }
    }
}
