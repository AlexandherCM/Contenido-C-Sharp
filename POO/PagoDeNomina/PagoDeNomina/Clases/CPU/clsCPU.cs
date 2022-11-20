using PagoDeNomina.ClasesAbstractas;
using PagoDeNomina.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoDeNomina.Clases.CPU
{
    public class clsCPU : clsElectrodomestico
    {
        //Atributos
        public string Procesador { get; set; }
        public int Ram { get; set; }
        public int DiscoDuro { get; set; }
        public int SSD { get; set; }
        public string FuentePoder { get; set; }
        public int Wats { get; set; }
        public string TarjetaMadre { get; set; }
        public clsElectrodomestico DatosGrales { get => _DatosGrales; set => _DatosGrales = value; }

        private clsElectrodomestico _DatosGrales;

        //Metodos y Constructores

        public clsCPU()
        {

        }

        public clsCPU(string Marca, int Unidades, string Proveedor, float CostoAdquisicion, float GtsOperativos, float Marketing, 
                      string Procesador, int Ram, int DiscoDuro, int SSD, string FuentePoder, int Wats, string TarjetaMadre)
        {
            _DatosGrales = new clsElectrodomestico(); // OBJETO PRIVADO INSTANCIADO

            DatosGrales.Marca = Marca;
            DatosGrales.Unidades = Unidades;
            DatosGrales.Proveedor = Proveedor;
            DatosGrales.CostoAdquisicion = CostoAdquisicion;
            DatosGrales.GtsOperativos = GtsOperativos;
            DatosGrales.Marketing = Marketing;
            DatosGrales.IVA = 16;
            DatosGrales.ISR = 1.95f;

            this.Procesador = Procesador;
            this.Ram = Ram;
            this.DiscoDuro = DiscoDuro;
            this.SSD = SSD;
            this.FuentePoder = FuentePoder;
            this.Wats = Wats;
            this.TarjetaMadre = TarjetaMadre;
        }

    }
}
