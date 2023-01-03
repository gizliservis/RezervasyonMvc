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
    public class StokController : Controller
    {
        RezervasyonContext context=new RezervasyonContext();
        StokManager stokManager = new StokManager(new EfStokDal());
        public IActionResult Index()
        {
            var list=stokManager.TGetList();
            return View(list);
        }
        public IActionResult Update_Insert(int? Id)
        {
            Stok stok = new Stok();
            List<SelectListItem> stokGrup = (from s in context.Tanimlar
                                             where s.Turu == "StokGrup"
                                             select new SelectListItem
                                             {
                                                 Text = s.Tanimi,
                                                 Value = s.Tanimi
                                             }).ToList();
            List<SelectListItem> stokAltGrup = (from s in context.Tanimlar
                                                where s.Turu == "StokAltGrup"
                                                select new SelectListItem
                                                {
                                                    Text = s.Tanimi,
                                                    Value = s.Tanimi
                                                }).ToList();
            List<SelectListItem> stokBirim = (from s in context.Tanimlar
                                                where s.Turu == "Birim"
                                                select new SelectListItem
                                                {
                                                    Text = s.Tanimi,
                                                    Value = s.Tanimi
                                                }).ToList();
            if (Id == null)
            {
                ViewBag.stokGrup = stokGrup;
                ViewBag.stokAltGrup = stokAltGrup;
                ViewBag.stokBirim = stokBirim;
                return View(stok);
            }
            stok = context.Stoklar.FirstOrDefault(c => c.Id == Id);
            if (stok == null)
            {
                return NotFound();
            }
            ViewBag.stokAltGrup = stokAltGrup;
            ViewBag.stokGrup = stokGrup;
            ViewBag.stokBirim = stokBirim;
            return View(stok);
        }
        [HttpPost]
        public IActionResult Update_Insert(Stok stok)
        {
            if (ModelState.IsValid)
            {
                if (stok.Id == 0)
                {
                    stokManager.TAdd(stok);
                }
                else
                {
                    stokManager.Update(stok);
                }
                return RedirectToAction("Index");
            }
            return View(stok);
        }
        public IActionResult Sil(Stok stok)
        {
            stokManager.Delete(stok);
            return RedirectToAction("Index");
        }
    }
}
