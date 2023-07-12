using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //erisim bildirgeci default olarak internal ancak biz tum katmanlardan erisebilmek icin public yapiyoruz
    public class House : IEntity
    {
        public int HouseId { get; set; }
        public int HouseCategoryId { get; set; }
        public string HouseName { get; set; }
        public int Price { get; set; }

             
    }
}
