using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G202CapturaTorneo
    {
        [Key]
        public int Id { get; set; }
        public G200Torneo Torneo { get; set; }
        public G120Player Player { get; set; }
        public TorneoRol Rol { get; set; }
        public G222PlayerTorneo Contrincante { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
