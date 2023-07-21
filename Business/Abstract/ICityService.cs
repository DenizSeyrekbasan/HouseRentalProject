using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICityService 
    {
        List<City> GetAll();
        List<City> GetAllByCategoryId(int id);
        public void Add(City city);
    }
}
