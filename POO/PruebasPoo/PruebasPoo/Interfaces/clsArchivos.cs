using PruebasPoo.Polimorfismo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PruebasPoo.Interfaces
{
    public class clsArchivos : IntSalidas
    {
        public void absImprimirCliente(clsCliente cliente)
        {
            
            
        }

        public void clsImprimirCliente(clsClienteConContacto cliente)
        {
            StreamWriter documento = new StreamWriter(@"D:\Documentos AlexUpt\Documents\Codigos y lenguajes\C#\Carpeta2\POO\PruebasPoo\Documento\Registros.log", true);
            documento.WriteLine("ID: " + cliente.ID + "\n" +
                              "Nombre: " + cliente.Nombre);
            if (cliente.TipoPersona == true)
                documento.WriteLine("Tipo de regimen: Persona fisica");
            else
                documento.WriteLine("Tipo de regimen: Persona moral");

            documento.WriteLine("Primer contacto: " + cliente.Telefono1 + "\n" +
                              "Segundo contacto: " + cliente.Telefono2 + "\n" +
                              "Correo electrónico: " + cliente.Email + "\n" +
                              "CP: " + cliente.Direccion.CP + "\n" +
                              "Municipio: " + cliente.Direccion.Municipio + "\n" +
                              "Colonia: " + cliente.Direccion.Colonia + "\n" +
                              "Numero externo  : " + cliente.Direccion.NuemeroExterno);
            documento.Close();
        }
    }
}
