using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G122PlayerData
    {
        [Key]
        public int Id { get; set; }
        public int Player { get; set; }
        public int PlayerId { get; set; }
        public G120Player PlayerAll { get; set; }
        public PlayerData Tipo { get; set; }
        public string Dato { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
