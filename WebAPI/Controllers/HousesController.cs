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
        //IHouseService turunde field
        IHouseService _houseService;

        //Loosely coupled - gevsek bagimlilik, soyuta bagimlilik
        public HousesController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        [HttpGet("getall")] 
        public IActionResult GetAllById()
        {
            //Dependency chain --bagimlilik
            var result = _houseService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result = _houseService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(House house)
        {
            var result = _houseService.Add(house);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result); 

        }
    }
}
