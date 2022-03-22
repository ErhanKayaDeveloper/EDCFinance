using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Models.Finans
{
    public class Urun
    {
        public int Id { get; set; }
        public UrunKategori UrunKategori { get; set; }
        public int UrunKategoriId { get; set; }
        public string Ad { get; set; }
        public bool Durum { get; set; }
        public List<UrunDetay> UrunDetaylar { get; set; }

    }
}
