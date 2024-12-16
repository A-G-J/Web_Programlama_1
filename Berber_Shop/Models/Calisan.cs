namespace Berber_Shop.Models
{
    public class Calisan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Uzmanlik { get; set; }
        public int HizmetId { get; set; }

        public Hizmet Hizmet { get; set; }
    }
}
