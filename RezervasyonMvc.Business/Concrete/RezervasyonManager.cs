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
    public class RezervasyonManager : IRezervasyonService
    {
        IRezervasyonDal _rezervasyonDal;
        public RezervasyonManager(IRezervasyonDal rezervasyonDal)
        {
            _rezervasyonDal = rezervasyonDal;
        }

        public void Delete(Rezervasyon t)
        {
            _rezervasyonDal.Delete(t);
        }

        public void TAdd(Rezervasyon t)
        {
            _rezervasyonDal.Insert(t);
        }

        public Rezervasyon TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rezervasyon> TGetList()
        {
            return _rezervasyonDal.GetList();
        }

        public void Update(Rezervasyon t)
        {
            _rezervasyonDal.Update(t);
        }
    }
}
