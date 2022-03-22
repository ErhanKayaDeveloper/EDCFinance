using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Models.Finans
{
    public class Meslek
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public bool Durum { get; set; }
        public List<Personel> Personeller { get; set; }
    }
}
