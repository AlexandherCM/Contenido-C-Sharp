using PruebasPoo.Constructores;
using PruebasPoo.Interfaces;
using PruebasPoo.Polimorfismo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPoo.Z_Instancias
{
    public class ObjetosGuardados
    {
        public Object Instancia1()
        {
            /* COMO HACER CONSTRUCTORES - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
            /* E INSTANCIAR OBJETOS - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
            /* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */

            Persona persona = new Persona("Alexandher", 19);
            Trabajador persona2 = new Trabajador("Alexandher Cordoba Molina", 20, "COMA030329548", 124);

            //persona.Datos();
            //persona2.CalculoSueldoMes(30);

            //Profe.Mostrar();
            //Profe.ReporteProfe();

            return persona2;
        }

        public Object Instancia2()
        {
            /* CLASE ABSTRACTA Y SU IMPLEMENTACIÓN - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
            /* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */

            clsClienteBase cliente = new clsClienteBase(2154, "Alexandher", true);
            clsClienteBase cliente2 = new clsClienteBase();

            //Console.WriteLine(cliente2.ID + "\n" + cliente2.Nombre + "\n" + cliente2.TipoPersona);
            //Console.WriteLine(cliente.ID + "\n" + cliente.Nombre + "\n" + cliente2.TipoPersona);

            clsClienteConContacto personal = new clsClienteConContacto(5478, "Alejandro Guzman", false, "5597889796",
                                                                       "5511548967", "alexandhercordoba379@gmail.com",
                                                                       "55635", "Zumpango", "Los sauces II", 212);

            clsImprimir ImprimirDatos = new clsImprimir();

            //ImprimirDatos.absImprimirCliente(personal);

            //ImprimirDatos.clsImprimirCliente(personal);

            return personal;
        }

        public Object Instancia3(clsClienteConContacto personal)
        {
            /*Polimorfismo con interfaces - - - - - - - - - - - - - - - - - - - - - - - - - - - -*/
            /* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
            IntSalidas Impresion;

            String Pregunta = String.Empty;

            Console.WriteLine("¿Quieres guardar una copia de la impresión en un bloc de notas?");
            Pregunta = Console.ReadLine();

            if (Pregunta == "Si" || Pregunta == "si")
            {
                Impresion = new clsArchivos();
                Console.WriteLine("Datos subidos en archivo ;)");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\tImpresión por consola\n");
                Impresion = new clsImprimir();
            }

            Impresion.clsImprimirCliente(personal);

            return Impresion;
        }

        public void Datos()
        {
             int contador = 0;
            bool bandera = true;

            while (bandera)
            {
                try
                {
                    String dato1 = "a";
                    int dato2 = 1;

                    //Console.WriteLine("Dato 1 -->");
                    //dato1 = int.Parse(Console.ReadLine());
                    //Console.Clear();

                    //Console.WriteLine("Dato 2 -->");
                    //dato2 = int.Parse(Console.ReadLine());
                    //Console.Clear();

                    Console.WriteLine("Resultado: {0}", (dato1 + dato2));
                    bandera = false;
                }
                catch (Exception ex)
                {
                    contador++;

                    if(contador >= 3)
                        throw ex;
                    //Console.WriteLine("EROR: " + ex.Message);
                }
            }

        }



    }
}
