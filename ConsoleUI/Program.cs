using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HouseTest();
            //CityGetAllTest();
            //CityGetAllByCategoryIdTest();
            //HouseLandLordTest();
            //CityNameAddedTest();
            HouseManager houseManager = new HouseManager(new EfHouseDal());

            foreach (var house in houseManager.GetHouseDetails())
            {
                Console.WriteLine(house.HouseName + "/" + house.HouseCategoryId);
            }

        }

        private static void CityNameAddedTest()
        {
            CityManager cityManager = new CityManager(new EfCityDal());
            cityManager.Add(new City
            {
                CityName = "Bingöl"
            });
        }

        private static void HouseLandLordTest()
        {
            HouseManager houseManager = new HouseManager(new EfHouseDal());
            houseManager.Add((new House
            {
                CityId = 5,
                HouseCategoryId = 3,
                HouseName = "Ozgun's House",
                Price = 475000
            }));
        }

        private static void CityGetAllByCategoryIdTest()
        {
            CityManager cityManager = new CityManager(new EfCityDal());
            foreach (var city in cityManager.GetAllByCategoryId(6))
            {
                Console.WriteLine(city.CityName);
            }
        }

        private static void CityGetAllTest()
        {
            CityManager cityManager = new CityManager(new EfCityDal());
            foreach (var city in cityManager.GetAll())
            {
                Console.WriteLine(city.CityName);
            }
        }

        private static void HouseTest()
        {
            HouseManager houseManager = new HouseManager(new EfHouseDal());

            foreach (var house in houseManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(house.CityId);
            }
        }
    }
}