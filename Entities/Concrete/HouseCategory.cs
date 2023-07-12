using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HouseCategory : IEntity
    {
        public int HouseCategoryId { get; set; }
        public string HouseCategoryName { get; set; }
    }
}
