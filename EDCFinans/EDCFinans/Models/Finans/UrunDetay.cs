using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Models.Finans
{
    public class UrunDetay
    {
        public int Id { get; set; }
        public Urun Urun { get; set; }
        public int UrunId { get; set; }
        public string Barkod { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public string Renk { get; set; }
        public bool Durum { get; set; }
        
    }
}
