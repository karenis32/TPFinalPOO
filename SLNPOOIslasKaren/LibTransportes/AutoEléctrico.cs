using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class AutoEléctrico : Transporte
    {
        public bool BateriaCargada { get; set; }

        public AutoEléctrico(string marca, string modelo, string patente, bool bateriaCargada) : base(marca, modelo, patente)
        {
            BateriaCargada = bateriaCargada;
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
