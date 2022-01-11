using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G222PlayerTorneo
    {
        [Key]
        public int Id { get; set; }
        public G220TeamTorneo TeamTorneo { get; set; }
        public G120Player PlayerToreno { get; set; }
        public int HcpTorneo { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
