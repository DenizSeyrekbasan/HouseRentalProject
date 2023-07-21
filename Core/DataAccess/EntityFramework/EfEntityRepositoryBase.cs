using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    //yeni bir tablo olusturdugumuzda tum crud islemlerini hazir hale getirmek icin base bir class olusturuyoruz
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity> 
        where TEntity: class, IEntity,new()
        where TContext: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //db'de veri kaynagiyla eslestirme kodu
                addedEntity.State = EntityState.Added; //eklenecek nesne oldugunu belirtiyoruz
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity get(Expression<Func<TEntity, bool>> filter)
        {
            //tek data dondurecek
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            //filtre dondurecek
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();

                //eger filtre null gelirse tum datayi dondur, null gelmezse filteli dondur
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
