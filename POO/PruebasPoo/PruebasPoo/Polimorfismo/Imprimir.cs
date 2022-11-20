using PruebasPoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPoo.Polimorfismo
{
    public class clsImprimir : IntSalidas
    {
        public void absImprimirCliente(clsCliente cliente)
        {
            Console.WriteLine("ID: " + cliente.ID + "\n" + 
                              "Nombre: " + cliente.Nombre);
            if (cliente.TipoPersona == true)
                Console.WriteLine("Tipo de regimen: Persona fisica");
            else
                Console.WriteLine("Tipo de regimen: Persona moral");
        }

        public void clsImprimirCliente(clsClienteConContacto cliente)
        {
            Console.WriteLine("ID: " + cliente.ID + "\n" +
                              "Nombre: " + cliente.Nombre);
            if (cliente.TipoPersona == true)
                Console.WriteLine("Tipo de regimen: Persona fisica");
            else
                Console.WriteLine("Tipo de regimen: Persona moral");

            Console.WriteLine("Primer contacto: " + cliente.Telefono1 + "\n" +
                              "Segundo contacto: " + cliente.Telefono2 + "\n" +
                              "Correo electrónico: " + cliente.Email + "\n" +
                              "CP: " + cliente.Direccion.CP + "\n" +
                              "Municipio: " + cliente.Direccion.Municipio + "\n" +
                              "Colonia: " + cliente.Direccion.Colonia + "\n" +
                              "Numero externo: " + cliente.Direccion.NuemeroExterno);
        }

    }
}
