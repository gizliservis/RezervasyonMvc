using RezervasyonMvc.DataAccess.Abstract;
using RezervasyonMvc.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.DataAccess.Repository
{
    public class GenericRepoSitory<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new RezervasyonContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetList()
        {
            using var c = new RezervasyonContext();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new RezervasyonContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new RezervasyonContext();
            c.Update(t);
            c.SaveChanges() ;
        }
    }
}
