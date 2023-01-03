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
    public class StokManager : IStokService
    {
        IStokDal _stokDal;
        public StokManager(IStokDal stokDal)
        {
            _stokDal= stokDal;
        }
        public void Delete(Stok t)
        {
            _stokDal.Delete(t);
        }

        public void TAdd(Stok t)
        {
            _stokDal.Insert(t);
        }

        public Stok TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Stok> TGetList()
        {
            return _stokDal.GetList();
        }

        public void Update(Stok t)
        {
           _stokDal.Update(t);
        }
    }
}
