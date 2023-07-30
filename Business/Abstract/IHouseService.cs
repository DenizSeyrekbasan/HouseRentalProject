using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHouseService
    {
        IDataResult<List<House>> GetAll(); //islem sonucu ve message dondurmek icin IDataResult
        IDataResult<List<House>> GetAllByCategoryId(int id); //UI'de category'e gore filtreleme yapilacaginda
        IDataResult<List<House>> GetAllUnitPrice(decimal min, decimal max);
        IDataResult<List<House>> GetAllCity(int city);
        IDataResult<House> GetById(int houseId); //tek bir house donduruyor, ilana tiklanildiginda sadece o ilanin property'leri geliyor
        IDataResult<List<HouseDetailDto>> GetHouseDetails();
        IResult Add(House house); // burada bir sey dondurmuyor sadece ekleme
    }
}
