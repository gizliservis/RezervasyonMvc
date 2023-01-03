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
    public class CariManager : ICariService
    {
        ICariDal _cariDal;
        public CariManager(ICariDal cariDal)
        {
            _cariDal = cariDal;
        }

        public void Delete(Cari t)
        {
            _cariDal.Delete(t);
        }

        public void TAdd(Cari t)
        {
            _cariDal.Insert(t);
        }

        public Cari TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cari> TGetList()
        {
           return _cariDal.GetList();
        }

        public void Update(Cari t)
        {
            _cariDal.Update(t);
        }
    }
}
