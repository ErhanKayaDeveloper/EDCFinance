using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Models.Finans
{
    public class GelirGider
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public GelirGiderTuru GelirGiderTuru { get; set; }
        public int GelirGiderTurId  { get; set; }
        public Fatura Fatura { get; set; }
        public int FaturaId  { get; set; }
        public string Aciklama  { get; set; }
        public bool Durum  { get; set; }
    }
}
