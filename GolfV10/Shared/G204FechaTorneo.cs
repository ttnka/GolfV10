using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G204FechaTorneo
    {
        [Key]
        public int Id { get; set; }
        public G200Torneo Torneo { get; set; }
        public int Ronda { get; set; }
        public G208CategoriaTorneo Categoria { get; set; }
        public DateTime Fecha { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
