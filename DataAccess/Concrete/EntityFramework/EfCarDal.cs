using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from a in context.Cars
                             join b in context.Brands
                             // join cl in context.Colors
                             on a.Id equals b.BrandId
                             join c in context.Colors
                             on a.Id equals c.ColorId
                             select new CarDetailDto { 
                                 Id = a.Id, 
                                 BrandName = b.BrandName,
                                 ColorName=c.ColorName,
                                 ModelYear = a.ModelYear, 
                                 DailyPrice = a.DailyPrice, 
                                 Description = a.Description };

                
                return result.ToList();
            }

        }
    }
}
