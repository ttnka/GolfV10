using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G208CategoriaTorneo
    {
        [Key]
        public int Id { get; set; }
        public G200Torneo Torneo { get; set; }
        public string Titulo { get; set; }
        public string Desc { get; set; }
        public G172Bandera Bandera { get; set; }
        public int Players { get; set; }
        public Decimal HcpTecho { get; set; }
        public Decimal HcpPiso { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
