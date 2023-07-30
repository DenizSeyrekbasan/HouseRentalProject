using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class HouseDetailDto : IDto
    {
        public int HouseId { get; set; }
        public int HouseCategoryId { get; set; }
        public string HouseName { get; set; } 
        public string HouseCategoryName { get; set; }
    }
}
