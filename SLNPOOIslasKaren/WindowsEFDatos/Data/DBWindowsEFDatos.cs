using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Data
{
    public class DBWindowsEFDatos:DbContext
    {
        public DBWindowsEFDatos() : base("KeyDB") { }

        public DbSet<Avión> avion { get; set; }
        public DbSet<LineaAerea> lineaAerea { get; set;}

    }
}
