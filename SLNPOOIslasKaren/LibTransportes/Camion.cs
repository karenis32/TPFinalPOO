using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Camion : Transporte
    {
        public double PesoMaximo { get; set; }
        public Remolque remolque { get; set; }


        public Camion(string marca, string modelo, string patente, double pesoMaximo) : base(marca, modelo, patente)
        {
            PesoMaximo = pesoMaximo;
        }

        public override string ToString()
        {
            return "Marca: " + Marca + "\nModelo: " + Modelo + "\nPatente: " + Patente + "\nPeso máximo: " + PesoMaximo;
        }

        public override string Acelerar()
        {
            return "Acelerar camión";
        }

        public override string Frenar()
        {
            return "Frenar camión";
        }

        public void QuitarRemolque()
        {
            remolque = null;

        }
    }
}
