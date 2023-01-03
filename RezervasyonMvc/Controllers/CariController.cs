using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RezervasyonMvc.Business.Concrete;
using RezervasyonMvc.DataAccess.Concrete;
using RezervasyonMvc.DataAccess.EntityFramework;
using RezervasyonMvc.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace RezervasyonMvc.Controllers
{
    public class CariController : Controller
    {
        RezervasyonContext context = new RezervasyonContext();
        CariManager cariManager = new CariManager(new EfCariDal());
        public IActionResult Index()
        {
           var list=cariManager.TGetList();
            return View(list);
        }
        public IActionResult Update_Insert(int? Id)
        {
            Cari cari = new Cari();
            List<SelectListItem> cariGrub = (from s in context.Tanimlar
                                             where s.Turu == "CariGrub"
                                             select new SelectListItem
                                             {
                                                 Text = s.Tanimi,
                                                 Value = s.Tanimi
                                             }).ToList();
            List<SelectListItem> cariAltGrub = (from s in context.Tanimlar
                                                where s.Turu == "CariAltGrub"
                                                select new SelectListItem
                                                {
                                                    Text = s.Tanimi,
                                                    Value = s.Tanimi
                                                }).ToList();
            if (Id == null)
            {
                ViewBag.cariGrup = cariGrub;
                ViewBag.cariAltGrup = cariAltGrub;
                return View(cari);
            }
            cari = context.Cariler.FirstOrDefault(c => c.Id == Id);
            if (cari == null)
            {
                return NotFound();
            }
            ViewBag.stokAltGrup = cariAltGrub;
            ViewBag.stokGrup = cariGrub;
            return View(cari);
        }
        [HttpPost]
        public IActionResult Update_Insert(Cari cari)
        {
            if (ModelState.IsValid)
            {
                if (cari.Id == 0)
                {
                    cariManager.TAdd(cari);
                }
                else
                {
                    cariManager.Update(cari);
                }
                return RedirectToAction("Index");
            }
            return View(cari);
        }
        public IActionResult Sil(Cari cari)
        {
            cariManager.Delete(cari);
            return RedirectToAction("Index");
        }
    }
}
