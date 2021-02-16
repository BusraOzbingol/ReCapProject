using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
            
        }
        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Messages.Descriptionİnvalid);
            }
            _brandDal.Add(brand);

            return new SuccessResult(Messages.CarAdded);

        }

        public IDataResult<List<Brand>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Brand> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetCarsByBrandId(int brandid)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetCarsByColorId(int colorid)
        {
            throw new NotImplementedException();
        }
    }
}
