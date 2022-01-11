using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G200Torneo
    {
        [Key]
        public int Id { get; set; }
        public int Ejercicio { get; set; }
        public string Titulo { get; set; }
        public string Desc { get; set; }
        public G120Player Creador { get; set; }
        public G280FormatoTorneo Formato { get; set; }
        public int Rondas { get; set; }
        public G170Campo Nombre { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
