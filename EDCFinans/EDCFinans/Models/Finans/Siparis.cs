using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Models.Finans
{
    public class Siparis
    {
        public int Id { get; set; }
        public int FaturaId { get; set; }
        public int SiparisDurumId { get; set; }
        public int CikisDepoId { get; set; }
        public int GirisDepoId { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
    }
}
