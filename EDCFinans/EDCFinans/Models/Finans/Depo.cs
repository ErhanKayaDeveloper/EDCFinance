using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Models.Finans
{
    public class Depo
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public Sirket Sirket { get; set; }
        public int SirketId { get; set; }
        public Sehir Sehir { get; set; }
        public int SehirId { get; set; }
        public bool Durum { get; set; }
    }
}
