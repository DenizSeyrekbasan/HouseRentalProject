using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTO;
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
        //business layer veri erisimine bagli bu daha sonra degisebilir(Ef, Nhibernate gibi), o yuzden bagimliligi en aza indiriyoruz
        //bagimliligi constructor injection ile yapiyoruz

        public HouseManager(IHouseDal houseDal) 
        {
            //house manager newlendiginde consturctor kendisine bir tane ihouseDal referansi istiyor
            _houseDal = houseDal;
        }

        public void Add(House house)
        {
            _houseDal.Add(house);
        }

        public List<House> GetAll()
        {
            //is kodlari
            return _houseDal.GetAll();
        }

        public List<House> GetAllByCategoryId(int id)
        {
            return _houseDal.GetAll(p => p.HouseCategoryId == id); 
            //her p icin p'nin categoryId'si gonderilen id'ye esit ise onlari filtrele
        }

        public List<House> GetAllCity(int cityId)
        {
            return _houseDal.GetAll(p => p.CityId == cityId);
            //Filter of Antalya Houses
        }

        public List<House> GetallUnitPrice(decimal min, decimal max)
        {
            return _houseDal.GetAll(p => p.Price >= min && p.Price <= max); //iki fiyat arasi data
        }

        public List<HouseDetailDto> GetHouseDetails()
        {
            return _houseDal.GetHouseDetails();
        }
    }
}
