using Microsoft.AspNetCore.Mvc;
using RezervasyonMvc.Business.Concrete;
using RezervasyonMvc.DataAccess.Concrete;
using RezervasyonMvc.DataAccess.EntityFramework;
using RezervasyonMvc.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace RezervasyonMvc.Controllers
{
    public class OdaController : Controller
    {
        private readonly RezervasyonContext _db=new RezervasyonContext();
        private readonly OdaManager om = new OdaManager(new EfOdaDal());
        
        public IActionResult Index()
        {
            var list = om.TGetList();
            return View(list);
        }
        public IActionResult Update_Insert(int? Id)
        {
            Oda oda=new Oda();
            if (Id==null)
            {
                return View(oda);
            }
            oda = _db.Odalar.FirstOrDefault(c=>c.Id==Id);
            if (oda==null)
            {
                return NotFound();
            }
            return View(oda);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update_Insert(Oda oda)
        {
            if (ModelState.IsValid)
            {
                if (oda.Id==0)
                {
                    om.TAdd(oda);
                }
                else
                {
                    om.Update(oda);
                }
                return RedirectToAction("Index");
            }
            return View(oda) ;
        }
        public IActionResult Sil(Oda oda)
        {
             om.Delete(oda);
            return RedirectToAction("Index");
        }
    }
}
