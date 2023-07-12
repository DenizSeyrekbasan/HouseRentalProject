using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    //bu bolumde gercek memory kullanilmiyor, list ile houses tanimlama yapildi
    public class InMemoryHouseDal : IHouseDal
    {
        // _houses bu tip degiskenlere global degisken deniyor, metotlarin disarisinda tanimlandigi icin ve genelde alt tire ile gosterilir
        List<House> _houses;

        public InMemoryHouseDal()
        {
            //ctor yazarak constructor metot calistirdik, yani bellekte referans alindiginda calisacak olan blok
            _houses = new List<House> {
                new House{HouseId=1,HouseCategoryId=1,HouseName="Deniz's House", Price=500},
                new House{HouseId=2,HouseCategoryId=2,HouseName="Ahmet's House", Price=200},
                new House{HouseId=3,HouseCategoryId=3,HouseName="Mehmet's House", Price=400},
                new House{HouseId=4,HouseCategoryId=4,HouseName="Ali's House", Price=300}
                //burada sanki oracle,sql server, postgres veya mongodb gibi db'den geliyor gibi simule ettik   
            };

        }
        public void Add(House house)
        {
            _houses.Add(house);
        }

        public void Delete(House house)
        {
            //linq sorgusu ile delete islemi yapiyoruz
            //SingleOrDefault tek bir eleman bulmaya yarar
            //p tek tek dolasirken kullanilan takma isim

            House houseToDelete = _houses.SingleOrDefault(p=>p.HouseId == house.HouseId);
        }

        public House get(Expression<Func<House, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<House> GetAll()
        {
            return _houses; //tum db'nin donmesini istiyoruz
        }

        public List<House> GetAll(Expression<Func<House, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<House> GetAllByCategoryId(int categoryId)
        {
            return _houses.Where(p => p.HouseId == categoryId).ToList();
            //where komutu icerisine tum sartlara uyan tum elemanlari yeni bir listeleyip goruntuler
        }

        public void Update(House house)
        {
            //Gonderilen urun id'sine sahip urunu bul
            House houseToUpdate = _houses.SingleOrDefault(p => p.HouseId == house.HouseId);
            houseToUpdate.HouseName = house.HouseName;
            houseToUpdate.Price = house.Price;
            
        }
    }
}
