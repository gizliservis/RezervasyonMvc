using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RezervasyonMvc.Business.Concrete;
using RezervasyonMvc.DataAccess.Concrete;
using RezervasyonMvc.DataAccess.EntityFramework;
using RezervasyonMvc.Model.Models;
using RezervasyonMvc.Model.Models.OtherModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RezervasyonMvc.Controllers
{
    public class RezervasyonController : Controller
    {
        private readonly RezervasyonContext _db = new RezervasyonContext();
        private readonly RezervasyonManager om = new RezervasyonManager(new EfRezervasyonDal());
        private readonly MusteriManager md = new MusteriManager(new EfMusteriDal());
        private  Musteri musteri = new Musteri();

        public IActionResult Index()
        {

            List<Rezervasyon> list = _db.Rezervasyonlar.Include(a => a.Musteri).ToList();
            return View(list);
        }
        public IActionResult Update_Insert()
        {
            RezervasyonYap rzrv = new RezervasyonYap();
            return View(rzrv);
        }
        public IActionResult Insert(RezervasyonYap _rzv)
        {
            return View(_rzv);
        }

        public IActionResult InsertOf(RezervasyonYap _rzv)
        {

            DateTime dateGiris;
            DateTime dateCikis;
            dateGiris = _rzv.Rezervasyonlar.GrisTarihi;
            dateCikis = _rzv.Rezervasyonlar.CikisTarihi;
            TimeSpan ts = dateCikis - dateGiris;
            int kisiSayi = _rzv.Rezervasyonlar.KisiSayisi;
            int yatakSayi = _rzv.Rezervasyonlar.KisiSayisi;
            int haftaSonu = 0;
            _rzv.Rezervasyonlar.GunSayisi = Convert.ToInt32(ts.Days);
            if (kisiSayi > 3 && kisiSayi % 3 != 0)
            {
                _rzv.Rezervasyonlar.OdaSayisi = Convert.ToInt32(kisiSayi % 3) + Convert.ToInt32(kisiSayi / 3);
            }
            else
            {
                _rzv.Rezervasyonlar.OdaSayisi = kisiSayi / 3;
            }
            _rzv.Rezervasyonlar.YatakSayisi = yatakSayi;
            for (int i = 0; i <= ts.Days; i++)
            {
                DateTime dt = dateGiris.AddDays(i);
                string gun = dt.ToString("dddd");
                if (gun == "Cumartesi" || gun == "Pazar")
                {
                    haftaSonu++;
                }
            }
            int haftaIciGun = ts.Days - haftaSonu;
            var lst = _db.Odalar.FirstOrDefault();

            decimal odaFiyat = lst.OdaFiyat;
            decimal stToplam = 0m;
            if (kisiSayi % 3 != 0)
            {

                decimal standartOdaFiyat = (odaFiyat - ((odaFiyat * 30) / 100)) * (kisiSayi % 3);
                decimal stHaftaSonu = (standartOdaFiyat + (odaFiyat * 30) / 100) * haftaSonu;
                decimal stHaftaIci = standartOdaFiyat * haftaIciGun;
                stToplam = stHaftaIci + stHaftaSonu;
            }

            decimal haftaSonuFiyat = (odaFiyat + ((odaFiyat * 30) / 100)) * haftaSonu;
            decimal haftaIciFiyat = odaFiyat * haftaIciGun;
            _rzv.Rezervasyonlar.RezToplamTutar = ((haftaSonuFiyat + haftaIciFiyat) * ((kisiSayi) - (kisiSayi % 3))) + stToplam;
            musteri = _rzv.Musteriler;
            md.TAdd(musteri);
            _rzv.Rezervasyonlar.MusteriId = musteri.Id;
            om.TAdd(_rzv.Rezervasyonlar);
            return RedirectToAction("Index");
        }
    }
}
