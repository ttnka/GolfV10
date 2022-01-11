using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G280FormatoTorneo
    {
        [Key]
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Titulo { get; set; }
        public string Desc { get; set; }
        public int Rondas { get; set; }
        public int Players { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
