using RezervasyonMvc.DataAccess.Abstract;
using RezervasyonMvc.DataAccess.Repository;
using RezervasyonMvc.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.DataAccess.EntityFramework
{
    public class EfStokDal:GenericRepoSitory<Stok>,IStokDal
    {
    }
}
