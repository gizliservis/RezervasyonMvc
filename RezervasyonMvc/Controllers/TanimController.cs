using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RezervasyonMvc.Business.Concrete;
using RezervasyonMvc.DataAccess.Abstract;
using RezervasyonMvc.DataAccess.Concrete;
using RezervasyonMvc.DataAccess.EntityFramework;
using RezervasyonMvc.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace RezervasyonMvc.Controllers
{
    public class TanimController : Controller
    {
        RezervasyonContext context = new RezervasyonContext();
        TanimManager tanimManager = new TanimManager(new EfTanimDal());
        public IActionResult Index()
        {
            var list = tanimManager.TGetList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Update_Insert(int? Id)
        {
            Tanim tanim = new Tanim();
   
            if (Id == null)
            {
              
                return View(tanim);
            }
            tanim = context.Tanimlar.FirstOrDefault(c => c.Id == Id);
            if (tanim == null)
            {
                return NotFound();
            }
         
            return View(tanim);
        }
        [HttpPost]
        public IActionResult Update_Insert(Tanim tanim)
        {
            if (ModelState.IsValid)
            {
                if (tanim.Id==0)
                {
                    tanimManager.TAdd(tanim);
                }
                else
                {
                    tanimManager.Update(tanim);
                }
                return RedirectToAction("Index");
            }
            return View(tanim);
        }
        public IActionResult Sil(Tanim tanim)
        {
            tanimManager.Delete(tanim);
            return RedirectToAction("Index");
        }
    }
}
