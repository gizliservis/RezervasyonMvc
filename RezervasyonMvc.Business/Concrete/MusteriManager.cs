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
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteriDal;
        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public void Delete(Musteri t)
        {
            _musteriDal.Delete(t);
        }

        public void TAdd(Musteri t)
        {
            _musteriDal.Insert(t);
        }

        public Musteri TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Musteri> TGetList()
        {
            return _musteriDal.GetList();
        }

        public void Update(Musteri t)
        {
            _musteriDal.Update(t);
        }
    }
}
