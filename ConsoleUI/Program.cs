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
            HouseManager houseManager = new HouseManager(new EfHouseDal());

            foreach (var house in houseManager.GetAll())
            {
                Console.WriteLine(house.Price);
            }
        }
    }
}