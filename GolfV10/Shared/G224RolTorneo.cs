using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G224RolTorneo
    {
        [Key]
        public int Id { get; set; }
        public G200Torneo Torneo { get; set; }
        public DateTime Fecha { get; set; }
        public int Ronda { get; set; }
        public int Indice { get; set; }
        public G220TeamTorneo Team { get; set; }
        public G222PlayerTorneo PlayerTorneo { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
