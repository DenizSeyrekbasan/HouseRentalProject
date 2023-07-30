using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.DTO;
using System.Diagnostics.Metrics;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHouseDal : EfEntityRepositoryBase<House, HouseRentalDbContext>, IHouseDal
    {
        public List<HouseDetailDto> GetHouseDetails()
        {
            using (HouseRentalDbContext context = new HouseRentalDbContext())
            {
                //linq sorgusu ile join islemi gerceklestiricez
                var result = from p in context.Houses
                             join c in context.HouseCategories
                             on p.HouseCategoryId equals c.HouseCategoryId
                             select new HouseDetailDto
                             {
                                 HouseId = p.HouseId,
                                 HouseName = p.HouseName,
                                 HouseCategoryId = p.HouseCategoryId,
                                 HouseCategoryName = c.HouseCategoryName

                                 };
                return result.ToList();
            }
        }
    }
}
