using Microsoft.AspNetCore.Mvc;
using RezervasyonMvc.Business.Concrete;
using RezervasyonMvc.DataAccess.Concrete;
using RezervasyonMvc.DataAccess.EntityFramework;
using RezervasyonMvc.Model.Models;
using System.Linq;

namespace RezervasyonMvc.Controllers
{
    public class MusteriController : Controller
    {
        private readonly RezervasyonContext _db = new RezervasyonContext();
        private readonly MusteriManager om = new MusteriManager(new EfMusteriDal());
        public IActionResult Index()
        {
            var list = om.TGetList();
            return View(list);
        }
        public IActionResult Update_Insert(int? Id)
        {
            Musteri musteri = new Musteri();
            if (Id == null)
            {
                return View(musteri);
            }
            musteri = _db.Musteriler.FirstOrDefault(c => c.Id == Id);
            if (musteri == null)
            {
                return NotFound();
            }
            return View(musteri);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update_Insert(Musteri musteri)
        {
          
                if (ModelState.IsValid)
                {
                    if (musteri.Id == 0)
                    {
                        om.TAdd(musteri);
                    }
                    else
                    {
                        om.Update(musteri);
                    }
                    return RedirectToAction("Index");
                }
                return View(musteri);
        }
        public IActionResult Sil(Musteri musteri)
        {
            om.Delete(musteri);
            return RedirectToAction("Index");
        }
    }
}
