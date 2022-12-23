using RezervasyonMvc.Business.Abstract;
using RezervasyonMvc.DataAccess.Abstract;
using RezervasyonMvc.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Business.Concrete
{
    public class RezervasyonHareketManager : IRezervasyonHareketService
    {
        IRezervasyonHareketDal _rezervasyonHareketDal;
        public RezervasyonHareketManager(IRezervasyonHareketDal rezervasyonHareketDal)
        {
            _rezervasyonHareketDal = rezervasyonHareketDal;
        }

        public void Delete(RezervasyonHareket t)
        {
          _rezervasyonHareketDal.Delete(t);
        }

        public void TAdd(RezervasyonHareket t)
        {
            _rezervasyonHareketDal.Insert(t);
        }

        public RezervasyonHareket TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<RezervasyonHareket> TGetList()
        {
            return _rezervasyonHareketDal.GetList();
        }

        public void Update(RezervasyonHareket t)
        {
           _rezervasyonHareketDal.Update(t);
        }
    }
}
