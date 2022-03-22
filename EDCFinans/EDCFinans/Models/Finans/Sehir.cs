using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Models.Finans
{
    public class Sehir
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public Ulke Ulke { get; set; }
        public int UlkeId { get; set; }
        public bool Durum { get; set; }
        public List<Depo> Depolar { get; set; }
    }
}
