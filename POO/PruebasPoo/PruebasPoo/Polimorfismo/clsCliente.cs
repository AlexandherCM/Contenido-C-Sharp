using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPoo.Polimorfismo

{   // Estas clase no se pueden instanciar --> Puede ser una platilla para definir mas clases
    /* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
    public abstract class clsCliente
    {
        public abstract int ID { get; set; }
        public abstract String Nombre { get; set; }
        public abstract bool TipoPersona { get; set; }
    }

    /*  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
    // Utiliza override --> Para generar la herencia de un clase abstracta
    public class clsClienteBase : clsCliente
    {
        public clsClienteBase()
        {
            ID = 0;
            Nombre = String.Empty;
            TipoPersona = false;
        }

        public clsClienteBase(int ID, String Nombre, bool TipoPersona)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.TipoPersona = TipoPersona;
        }
        public override int ID { get; set; }
        public override String Nombre { get; set; }
        public override bool TipoPersona { get; set; }
    }
    /* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
    public class clsClienteConContacto : clsClienteBase
    {
        public clsClienteConContacto()
        {
            _Direccion = new clsDireccion();
        }
        public clsClienteConContacto(int ID, String Nombre, bool TipoPersona, String Telefono1,
                                     String Telefono2, String Email, String CP, String Municipio,
                                     String Colonia, int NumeroExterno)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.TipoPersona = TipoPersona;
            this.Telefono1 = Telefono1;
            this.Telefono2 = Telefono2;
            this.Email = Email;

            //Debo de instanciar el objeto para poder utilizar los parametros otorgados
            _Direccion = new clsDireccion();
            Direccion.CP = CP;
            Direccion.Municipio = Municipio;
            Direccion.Colonia = Colonia;
            Direccion.NuemeroExterno = NumeroExterno;
        }

        public String Telefono1 { get; set; }
        public String Telefono2 { get; set; }
        public String Email { get; set; }
        public clsDireccion Direccion { get => _Direccion; set => _Direccion = value; }


        //Genera los accesores del objeto de la clase clsDirreccion


        //Encapsular con refactorización
        private clsDireccion _Direccion;
    }
}
