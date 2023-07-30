using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //Attribute
    public class HousesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            IHouseService houseService = new HouseManager(new EfHouseDal());
            var result = houseService.GetAll();
            return result.Message;

        }
    }
}
