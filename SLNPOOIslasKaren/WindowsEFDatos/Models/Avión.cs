using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Models
{
    [Table("Avión")]
    public class Avión
    {
        [Key]
        public int IdAvion { get; set; }

        public int Capacidad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Denominación { get; set; }

        public LineaAerea lineaAerea { get; set; }

        public Avión() { }

        public Avión(int capacidad, string denominación, LineaAerea lineaAerea)
        {
            Capacidad = capacidad;
            Denominación = denominación;
            this.lineaAerea = lineaAerea;
        }
    }
}
