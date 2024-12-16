using System;

namespace Berber_Shop.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string CalisanAdi { get; set; }
        public string HizmetAdi { get; set; }
        public DateTime Tarih { get; set; }
    }
}
