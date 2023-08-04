using Business.Concrete;
using Business.Constans;
using Core.Utilities.Results;
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
            //DtoTest();
            //HouseDtoResultMessageTest();
            //CityNameAddedResultTest();
            //HouseAddedErrorResultTest();
            //HouseGetAllTest();

        }

        private static void HouseGetAllTest()
        {
            HouseManager houseManager = new HouseManager(new EfHouseDal());
            foreach (var house in houseManager.GetAll().Data)
            {
                Console.WriteLine(house.HouseName);
            }
        }

        private static void HouseAddedErrorResultTest()
        {
            HouseManager houseManager = new HouseManager(new EfHouseDal());
            var result = houseManager.Add(new House
            {
                HouseCategoryId = 3,
                HouseName = "a",
                Price = 5000000,
                CityId = 3
            });

            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CityNameAddedResultTest()
        {
            CityManager cityManager = new CityManager(new EfCityDal());
            var result = cityManager.Add(new City
            {
                CityName = "Bitlis"
            });

            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void HouseDtoResultMessageTest()
        {
            HouseManager houseManager = new HouseManager(new EfHouseDal());
            var result = houseManager.GetHouseDetails();

            if (result.Success == true)
            {
                foreach (var house in result.Data)
                {
                    Console.WriteLine(house.HouseName + "/" + house.HouseCategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void DtoTest()
        {
            HouseManager houseManager = new HouseManager(new EfHouseDal());

            foreach (var house in houseManager.GetHouseDetails().Data)
            {
                Console.WriteLine(house.HouseName + "/" + house.HouseCategoryName);
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
            foreach (var city in cityManager.GetAllByCategoryId(6).Data)
            {
                Console.WriteLine(city.CityName);
            }
        }

        private static void CityGetAllTest()
        {
            CityManager cityManager = new CityManager(new EfCityDal());
            foreach (var city in cityManager.GetAll().Data)
            {
                Console.WriteLine(city.CityName);
            }
        }

        private static void HouseTest()
        {
            HouseManager houseManager = new HouseManager(new EfHouseDal());

            foreach (var house in houseManager.GetAllByCategoryId(2).Data)
            {
                Console.WriteLine(house.CityId);
            }
        }
    }
}