using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Models.Finans
{
    public class FinansContext: DbContext
    {
        public DbSet<Depo> Depolar  { get; set; }
        public DbSet<Fatura> Faturalar  { get; set; }
        public DbSet<GelirGider> GelirGiderler { get; set; }
        public DbSet<GelirGiderTuru> GelirGiderTurleri { get; set; }
        public DbSet<Maas> Maaslar { get; set; }
        public DbSet<Meslek> Meslekler { get; set; }
        public DbSet<ParaBirimi> ParaBirimleri  { get; set; }
        public DbSet<Personel> Personeller  { get; set; }
        public DbSet<Sehir> Sehirler  { get; set; }
        public DbSet<Siparis> Siparisler  { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylar  { get; set; }
        public DbSet<SiparisDurum> SiparisDurumlar  { get; set; }
        public DbSet<Sirket> Sirketler  { get;set; }
        public DbSet<Stok> Stoklar  { get; set; }
        public DbSet<Ulke> Ulkeler  { get; set; }
        public DbSet<Urun> Urunler  { get; set; }
        public DbSet<UrunDetay> UrunDetaylar  { get; set; }
        public DbSet<UrunKategori> UrunKategoriler  { get; set; }
        public FinansContext(DbContextOptions<FinansContext> options):base(options)
        {
            
        }
    }
}
