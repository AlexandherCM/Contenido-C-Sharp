using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram.DatosAlmacenados
{
    public class clsListas
    {
        private string Producto;
        private string busqueda;
        private List<string> ListaProductos = new List<string>();
        private List<string> ListaProductos2 = new List<string>();

        public void AddList()
        {
            bool Estado = false;
            string pregunta = string.Empty;

            while (!Estado)
            {
                Console.WriteLine("Ingresa un producto: ");
                Producto = Console.ReadLine();
                Console.Clear();

                ListaProductos.Add(Producto);

                Console.WriteLine("Quieres saber acerca de los productos");
                pregunta = Console.ReadLine();
                Console.Clear();

                if (pregunta.Equals("si"))
                {
                    convertirMiLista();
                }

                Console.WriteLine("Quiere ingresar otro producto");
                pregunta = Console.ReadLine();
                Console.Clear();

                if (pregunta.Equals("no"))
                {
                    Estado = true;
                    Console.WriteLine("SALIENDO...");
                }
            }

            do
            {
                Estado = false;

                Console.WriteLine("¿Quiere realizar una busqueda?");
                pregunta = Console.ReadLine();
                Console.Clear();

                if (pregunta.Equals("si"))
                {
                    Console.WriteLine("Ingresa tu busqueda: ");
                    busqueda = Console.ReadLine();
                    Console.Clear();

                    //X es la asignación que recive cada dato en la lista
                    IEnumerable<string> productosEncontrados = ListaProductos.Where(x => x.ToLower().Contains(busqueda));

                    Console.WriteLine("\nCOINSIDENCIAS: ");
                    foreach (var producto in productosEncontrados)
                    {
                        Console.WriteLine(producto);
                    }
                }
                else
                {
                    Estado = true;
                }

            } while (!Estado);
        }
        public void convertirMiLista()
        {
            string pregunta = string.Empty;

            String[] ListaArray = ListaProductos.ToArray();
            Console.WriteLine("Ultimo producto en array: {0}",ListaArray[(ListaProductos.Count() - 1)]);

            Console.WriteLine("\nNumero de productos: {0}", ListaProductos.Count());
            Console.WriteLine("Primer producto: {0}",ListaProductos.First());
            Console.WriteLine("Ultimo producto: {0}",ListaProductos.Last());

            //Puedo agregar una lista dentro de otra lista, en si puedo agregar varios elementos, combinando el numero de datos
            ListaProductos2.Add("Mesa Pro");
            ListaProductos2.Add("Mesa Pro2");

            ListaProductos.AddRange(ListaProductos2);
            Console.WriteLine("\nLISTA EN LISTA AGREGADA: {0}", ListaProductos.Count());

            Console.WriteLine("\nQuieres borrar la lista");
            pregunta = Console.ReadLine();
            Console.Clear();

            if (pregunta.Equals("si"))
            {
                ListaProductos.Clear();
                Console.WriteLine("Lista borrada...");
                Console.WriteLine("Numero de productos: {0}", ListaProductos.Count());
                Console.ReadKey();
            }
        }


    }
}
