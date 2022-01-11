using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G220TeamTorneo
    {
        [Key]
        public int Id { get; set; }
        public G200Torneo Torneo { get; set; }
        public G208CategoriaTorneo Catergoria { get; set; }
        public int Indice { get; set; }
        public string Titulo { get; set; }
        public int Integrantes { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
