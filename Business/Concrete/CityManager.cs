using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void Add(City city)
        {
            _cityDal.Add(city);
        }

        public List<City> GetAll()
        {
            return _cityDal.GetAll();
        }

        public List<City> GetAllByCategoryId(int id)
        {
            return _cityDal.GetAll(p => p.CityId == id);
        }
    }
}
