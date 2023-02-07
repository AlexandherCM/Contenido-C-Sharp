using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram.DatosAlmacenados
{
    public class clsDocs
    {
        private string Texto;
        private string[] Nombres = {"Alex","Valeria","Aaron","Max"};

        public void ImprimirDoc()
        {
            using (StreamReader ruta = new StreamReader(@"D:\Documentos AlexUpt\Documents\Codigos y lenguajes\C#\Carpeta2\Cursos C#\Curso C# No1\BasicProgram\Documentos\texto.txt"))
            {
                while ((Texto = ruta.ReadLine()) != null)
                {
                    Console.WriteLine(Texto);
                }
            }
        }
        
        public void GuardarDoc()
        {
            using (StreamWriter ruta = new StreamWriter(@"D:\Documentos AlexUpt\Documents\Codigos y lenguajes\C#\Carpeta2\Cursos C#\Curso C# No1\BasicProgram\Documentos\texto.txt"))
            {
                foreach (string escribir in Nombres)
                {
                    ruta.WriteLine($"Su nombre es: {escribir}");
                }
                Console.WriteLine("Nombres escritos en el documento ;3");
            }
        }
        
        public void GuardarMasDocs()
        {
            string rutaDoc = File.ReadAllText(@"D:\Documentos AlexUpt\Documents\Codigos y lenguajes\C#\Carpeta2\Cursos C#\Curso C# No1\BasicProgram\Documentos\Texto2.txt");


        }


    }
}
