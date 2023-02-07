using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class clsMetodosString
    {
        private string palabra;
        private string buscarLetra = "a";
        private string buscarPalabra = "Alex";

        public void program()
        {
            Console.WriteLine("Ingresa una palabra: ");
            palabra = Console.ReadLine();

            Console.Clear();
            AplicarMetodos();
        }

        public void AplicarMetodos()
        {
            //Mayuscula
            Console.WriteLine("En mayusculas: " + palabra.ToUpper());

            //Minuscula
            Console.WriteLine("En minusculas: {0}", palabra.ToLower());
            
            //Concatenar
            Console.WriteLine($"Palabra: " + palabra);

            //Comparación -> Arroja un true o false
            Console.WriteLine("La palabra es igual a '{0}': {1} ", buscarPalabra, palabra.Equals(buscarPalabra));

            //Te dice la posición en la que se encuentra, si hay mas de una,
            //solo te muestra el número de posición de la última letra encontrada
            //Si no hay ninguna letra se mostrara -1
            Console.WriteLine($"La letra '{buscarLetra}' esta en la posición: { palabra.LastIndexOf(buscarLetra)}");

            //Te confirma si existe en la cadena (true o false)
            Console.WriteLine("La palabra '"+ buscarPalabra + "' es igual ha "+ palabra + ": " + palabra.Contains("Alex"));
        }
    }
}
