using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHouseDal : IHouseDal
    {
        public void Add(House entity)
        {
            using (HouseRentalDbContext context = new HouseRentalDbContext())
            {
                var addedEntity = context.Entry(entity); //db'de veri kaynagiyla eslestirme kodu
                addedEntity.State = EntityState.Added; //eklenecek nesne oldugunu belirtiyoruz
                context.SaveChanges();
            }
        }

        public void Delete(House entity)
        {
            using (HouseRentalDbContext context = new HouseRentalDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public House get(Expression<Func<House, bool>> filter)
        {
            //tek data dondurecek
            using (HouseRentalDbContext context = new HouseRentalDbContext())
            {
                return context.Set<House>().SingleOrDefault(filter);
            }
        }

        public List<House> GetAll(Expression<Func<House, bool>> filter = null)
        {
            //filtre dondurecek
            using (HouseRentalDbContext context = new HouseRentalDbContext())
            {
                return filter == null
                    ? context.Set<House>().ToList()
                    : context.Set<House>().Where(filter).ToList();

                //eger filtre null gelirse tum datayi dondur, null gelmezse filteli dondur
            }
        }

        public void Update(House entity)
        {
            using (HouseRentalDbContext context = new HouseRentalDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
