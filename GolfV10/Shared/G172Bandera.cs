using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfV10.Shared
{
    public class G172Bandera
    {
        [Key]
        public int Id { get; set; }
        public G170Campo Campo { get; set; }
        public string Color { get; set; }
        public int Estado { get; set; } = 2;
        public bool Status { get; set; } = true;
    }
}
