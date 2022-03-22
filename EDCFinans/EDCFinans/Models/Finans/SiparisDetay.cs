using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Models.Finans
{
    public class SiparisDetay
    {
        public int Id { get; set; }
        public int SiparisId { get; set; }
        public int UrunDetayId { get; set; }
        public int Adet { get; set; }
    }
}
