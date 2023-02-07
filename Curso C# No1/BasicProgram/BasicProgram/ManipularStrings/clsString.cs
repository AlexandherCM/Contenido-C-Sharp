using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class clsString
    {
        //Formas de concatenar un String
        private string Nombre = "Alexandher";
        private string PrimerAp = "Cordoba";
        private string SegundoAp = "Molina";

        private char[] saludoSeparado = {'H','o','l','a'};

        public string ConcatUno()
        {
            string saludoJunto = new string(saludoSeparado);
            return saludoJunto;
        }
        public string ConcatDos()
        {
            string NombreCompleto = Nombre + " " + PrimerAp + " " + SegundoAp;
            return NombreCompleto;
        }
        public string ConcatTres()
        {
            string NombreCompleto = $"{Nombre} {PrimerAp} {SegundoAp}";
            return NombreCompleto;
        }

        public string ConcatCuatro()
        {
            string NombreCompleto = string.Format("{0} {1} {2}", Nombre, PrimerAp, SegundoAp);
            return NombreCompleto;
        }
    }
}
