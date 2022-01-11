using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G240Score
    {
        [Key]
        public int Id { get; set; }
        public G224RolTorneo Rol { get; set; }
        public G222PlayerTorneo PlayerTorneo { get; set; }
        public G176Hoyo Hoyo { get; set; }
        public int Score { get; set; }
        public G120Player Capturo { get; set; }
        public DateTime HoraCaptura { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
