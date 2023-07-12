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
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(HouseCategory entity)
        {
            using (HouseRentalDbContext context = new HouseRentalDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(HouseCategory entity)
        {
            using (HouseRentalDbContext context = new HouseRentalDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public HouseCategory get(Expression<Func<HouseCategory, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<HouseCategory> GetAll(Expression<Func<HouseCategory, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(HouseCategory entity)
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
