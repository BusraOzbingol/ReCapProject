using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
          IDataResult<List<Brand>> GetAll();
          IDataResult<List<Brand>> GetCarsByBrandId(int brandid);
          IDataResult<List<Brand>> GetCarsByColorId(int colorid);
          IDataResult<List<Brand>> GetByUnitPrice(decimal min, decimal max);
          IDataResult<Brand> GetById(int id);
          IResult Add(Brand brand);
        /*  IDataResult<List<BrandDetailDto>> GetCarDetails();
        */
    }
}
