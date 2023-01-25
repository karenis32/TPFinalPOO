using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class AutoElectrico : Transporte
    {
        public bool BateriaCargada { get; set; }

        public AutoElectrico(string marca, string modelo, string patente, bool bateriaCargada) : base(marca, modelo, patente)
        {
            BateriaCargada = bateriaCargada;
        }

        public override string ToString()
        {
            return "Marca: " + Marca + "\nModelo: " + Modelo + "\nPatente: " + Patente + "\nBateria cargada: " + BateriaCargada;
        }

        public override string Acelerar()
        {
            return "Acelerar auto eléctrico";
        }

        public override string Frenar()
        {
            return "Frenar auto eléctrico";
        }
    }
}
