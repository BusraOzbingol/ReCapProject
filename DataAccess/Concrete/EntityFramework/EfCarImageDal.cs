﻿using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, NorthwindContext>, ICarImageDal
    {

    }
}
