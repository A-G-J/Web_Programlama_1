using Berber_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Berber_Shop.Controllers
{
    public class HizmetlerController : Controller
    {
        public IActionResult Index()
        {
            
            var hizmetler = new List<string>
            {
                "Saç Kesimi",
                "Saç Boyama",
                "Sakal Tıraşı",
                "Cilt Bakımı"
            };

            return View(hizmetler);
        }

        public IActionResult Detay(string hizmet)
        {
            
            var calisanlar = new List<string>
    {
        "Ahmet Yılmaz",
        "Mehmet Kaya",
        "Ayşe Demir"
    };

            
            ViewBag.Hizmet = hizmet;

            
            return View(calisanlar);
        }
        private static List<Reservation> rezervasyonlar = new List<Reservation>();

        

        [HttpPost]
        public IActionResult RandevuAl(string calisan, string hizmet, DateTime tarih)
        {
            
            bool mevcut = rezervasyonlar.Any(r =>
                r.CalisanAdi == calisan && r.Tarih == tarih);

            if (mevcut)
            {
                ViewBag.Mesaj = "Bu tarih ve saat için zaten rezervasyon var!";
            }
            else
            {
                rezervasyonlar.Add(new Reservation
                {
                    Id = rezervasyonlar.Count + 1,
                    CalisanAdi = calisan,
                    HizmetAdi = hizmet,
                    Tarih = tarih
                });

                ViewBag.Mesaj = "Rezervasyon başarıyla alındı!";
            }

            ViewBag.Hizmet = hizmet;
            return View("Detay", new List<string> { "Ahmet Yılmaz", "Mehmet Kaya", "Ayşe Demir" });
        }
    }

}