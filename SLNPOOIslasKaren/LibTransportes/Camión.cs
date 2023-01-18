using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Camión : Transporte
    {
        public double PesoMaximo { get; set; }
        public Remolque remolque { get; set; }


        public Camión(string marca, string modelo, string patente, double pesoMaximo) : base(marca, modelo, patente)
        {
            PesoMaximo = pesoMaximo;
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
