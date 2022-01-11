using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G194Cita
    {
        [Key]
        public int Id { get; set; }
        public DateTime FIni { get; set; }
        public DateTime FFin { get; set; }
        public string Desc { get; set; }
        public int Player { get; set; }
        public string MasterId { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
