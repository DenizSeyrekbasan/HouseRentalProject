using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic constraint : generic kisitlama getiriyoruz, rastgele tanimlama yapilamasin
    //T 'nin referans tipi class olabilir ve sadece bizim class'larimizi kullanabilsin; onlarin ortak ozelligi de IEntity olmasi
    //IEntity kullanilmasini istemiyoruz o yuzden newlenebilir olmali ozelligini ekliyoruz
    //IEntity newlenemez ! (interface oldugu icin)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtreleme yapabilmek icin expressionlari kullaniyoruz
        T get(Expression<Func<T, bool>> filter);   
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
