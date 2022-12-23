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
    public class OdaManager : IOdaService
    {
        IOdaDal _odaDal;
        public OdaManager(IOdaDal odaDal)
        {
            _odaDal = odaDal;
        }

        public void Delete(Oda t)
        {
            _odaDal.Delete(t);
        }

        public void TAdd(Oda t)
        {
            _odaDal.Insert(t);
        }

        public Oda TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Oda> TGetList()
        {
            return _odaDal.GetList();
        }

        public void Update(Oda t)
        {
           _odaDal.Update(t);
        }
    }
}
