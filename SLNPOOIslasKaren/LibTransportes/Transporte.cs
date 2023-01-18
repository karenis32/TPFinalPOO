using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public abstract class Transporte
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }

        protected Transporte(string marca, string modelo, string patente)
        {
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
        }

        public abstract string Acelerar();

        public abstract string Frenar();
    }
}
