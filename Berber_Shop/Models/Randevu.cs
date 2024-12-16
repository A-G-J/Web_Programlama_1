namespace Berber_Shop.Models
{
    public class Randevu
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }
        public int CalisanId { get; set; }

        public Kullanici Kullanici { get; set; }
        public Calisan Calisan { get; set; }
    }
}
