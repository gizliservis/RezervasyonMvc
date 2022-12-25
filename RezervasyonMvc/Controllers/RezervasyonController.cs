using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RezervasyonMvc.Business.Concrete;
using RezervasyonMvc.DataAccess.Concrete;
using RezervasyonMvc.DataAccess.EntityFramework;
using RezervasyonMvc.Model.Models;
using RezervasyonMvc.Model.Models.OtherModel;
using System.Collections.Generic;
using System.Linq;

namespace RezervasyonMvc.Controllers
{
    public class RezervasyonController : Controller
    {
        private readonly RezervasyonContext _db = new RezervasyonContext();
          private readonly RezervasyonManager om = new RezervasyonManager(new EfRezervasyonDal());
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
    }
}
