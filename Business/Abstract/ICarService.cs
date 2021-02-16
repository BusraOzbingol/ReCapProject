using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandid);
        IDataResult<List<Car>> GetCarsByColorId(int colorid);
        IDataResult<List<Car>> GetByUnitPrice(decimal min,decimal max);
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        
    }
}
