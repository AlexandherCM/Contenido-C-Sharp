using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class clsBuilder
    {
        private string saludo = "Hola mi nombre es ";
        private string nombre;

        public void concatMemoria()
        {
            StringBuilder concat = new StringBuilder(saludo);

            Console.WriteLine("Ingresa tu nombre:");
            nombre = Console.ReadLine();
            //Agrega el string a la cadena utilizando el mismo espacio en memoria
            concat.Append(nombre);
            
            Console.Clear();    
            Console.WriteLine(concat);
        }
    }
}
