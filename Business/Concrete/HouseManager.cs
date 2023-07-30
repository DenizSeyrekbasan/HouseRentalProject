using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
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
    //business code'larini buraya yaziyoruz
    //ornegin ekleme islemi yaparken sart kostugumuzda sartlari saglarsa ekleme islemi yapilir
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

        public IResult Add(House house)
        {
            if (house.HouseName.Length < 2)
            {
                return new ErrorResult(Messages.HouseNameInvalid);
            }

            _houseDal.Add(house);
            return new SuccessResult(Messages.HouseAdded);
        }

        public IDataResult<List<House>> GetAll()
        {
            //is kodlari
            return new SuccessDataResult<List<House>>(_houseDal.GetAll(),Messages.HousesListed);
        }

        public IDataResult<List<House>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<House>>(_houseDal.GetAll(p => p.HouseCategoryId == id)); 
            //her p icin p'nin categoryId'si gonderilen id'ye esit ise onlari filtrele
        }

        public IDataResult<List<House>> GetAllCity(int cityId)
        {
            return new SuccessDataResult<List<House>> (_houseDal.GetAll(p => p.CityId == cityId));
            //Filter of Antalya Houses
        }

        public IDataResult<List<House>> GetAllUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<House>> (_houseDal.GetAll(p => p.Price >= min && p.Price <= max)); //iki fiyat arasi data
        }

        public IDataResult<House> GetById(int houseId)
        {
            return new SuccessDataResult<House>(_houseDal.get(p => p.HouseId == houseId));
        }

        public IDataResult<List<HouseDetailDto>> GetHouseDetails()
        {
            if (DateTime.Now.Hour == 12)
            {
                return new ErrorDataResult<List<HouseDetailDto>>(Messages.MaintanceTime);
            }

            return new SuccessDataResult<List<HouseDetailDto>> (_houseDal.GetHouseDetails());
        }
    }
}
