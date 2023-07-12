using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HouseManager : IHouseService
    {
        IHouseDal _houseDal;

        public HouseManager(IHouseDal houseDal) 
        {
            //house manager newlendiginde consturctor kendisine bir tane ihouseDal referansi istiyor
            _houseDal = houseDal;
        }

        public List<House> GetAll()
        {
            //is kodlari
            return _houseDal.GetAll();
        }
    }
}
