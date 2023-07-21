using Entities.Concrete;
using Entities.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHouseService
    {
        List<House> GetAll();
        List<House> GetAllByCategoryId(int id); //UI'de category'e gore filtreleme yapilacaginda
        List<House> GetallUnitPrice(decimal min, decimal max);
        List<House> GetAllCity(int city);
        public void Add(House house);
        List<HouseDetailDto> GetHouseDetails();
    }
}
