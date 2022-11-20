using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PagoDeNomina.Clases.Cliente
{
    public class clsCliente : clsDireccion
    {
        public int ID { get; set; }
        public string Cliente { get; set; }

        private long Numero;
        private String Correo;
        

        public clsCliente(int ID, String Cliente, long Numero, String Correo, int CP, string Municipio, string Colonia, int Manzana, int Lote, int NumeroExterno) 
                         :base(CP, Municipio, Colonia, Manzana, Lote, NumeroExterno)
        {
            this.ID = ID;
            this.Cliente = Cliente;
            setContacto('N', Numero, Correo);
            this.Numero = getNumero();
            setContacto('C', Numero, Correo);
            this.Correo = getCorreo();
        }

        public clsCliente() : base()
        {
            ID = 0;
            Cliente = String.Empty;
            Numero = 0;
            Correo = String.Empty;
        }

        public void setContacto(char contacto, long Numero ,String Correo) //Ingresa el contacto --> Numero o Correo
        {
            if(contacto == 'N')
            {
                this.Numero = Numero;
            }
            else if(contacto == 'C')
            {
                this.Correo = Correo;
            }
            else
            {
                this.Numero = 0;
                this.Correo = "";
            }
        }

        public String getCorreo()
        {
            if (this.Correo == "" && this.Numero == 0)
            {
                return "¡PETICIÓN DENEGADA!";
            }
            else
            {
                return this.Correo;
            }
        }

        public long getNumero()
        {
            if (this.Correo == "" && this.Numero == 0)
            {
                return 0;
            }
            else
            {
                return this.Numero;
            }
        }

    }
}
