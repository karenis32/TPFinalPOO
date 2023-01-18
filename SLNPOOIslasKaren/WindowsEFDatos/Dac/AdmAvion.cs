using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Models;
using WindowsEFDatos.Data;

namespace WindowsEFDatos.Dac
{
    public static class AdmAvion
    {
        private static DBWindowsEFDatos context = new DBWindowsEFDatos();
        public static List<Avión> Listar()
        {
            return context.avion.ToList();
        }

        public static int Insertar(Avión avión)
        {
            context.avion.Add(avión);

            return context.SaveChanges();
        }

        public static int Modificar(Avión avion)
        {
            Avión avionOrigen = context.avion.Find(avion.IdAvion);
            avionOrigen.IdAvion = avion.IdAvion;
            return context.SaveChanges();
        }

        public static int Eliminar(int Id)
        {
            Avión avionOrigen = context.avion.Find(Id);
            if (avionOrigen != null)
            {
                context.avion.Remove(avionOrigen);
                return context.SaveChanges();
            }
            return 0;
        }

        public static Avión TraerUno(int id)
        {
            return context.avion.Find(id);

        }
    }
}
