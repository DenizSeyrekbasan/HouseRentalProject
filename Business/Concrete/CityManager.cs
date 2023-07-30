using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
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

        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult(Messages.CityAdded);
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(), Messages.CityGetAll);
        }

        public IDataResult<List<City>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(p => p.CityId == id));
        }
    }
}
