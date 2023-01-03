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
    public class TanimManager : ITanimService
    {
        ITanimDal _tanimDal;
        public TanimManager(ITanimDal tanimDal)
        {
            _tanimDal = tanimDal;
        }

        public void Delete(Tanim t)
        {
           _tanimDal.Delete(t);
        }

        public void TAdd(Tanim t)
        {
           _tanimDal.Insert(t);
        }

        public Tanim TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tanim> TGetList()
        {
          return  _tanimDal.GetList();
        }

        public void Update(Tanim t)
        {
            _tanimDal.Update(t);
        }
    }
}
