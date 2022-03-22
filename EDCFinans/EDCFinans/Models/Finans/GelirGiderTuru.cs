using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Models.Finans
{
    public class GelirGiderTuru
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public bool Durum { get; set; }
        public List<GelirGider> GelirGiderler{ get; set; }
    }
}
