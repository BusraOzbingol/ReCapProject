using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, NorthwindContext>, IRentalDal
    {
        //public List<RentalDetailsDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        //{
        //    using (RentACarContext context = new RentACarContext())
        //    {
        //        var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
        //                     join c in context.Cars on r.CarId equals c.CarId
        //                     join b in context.Brands on c.BrandId equals b.BrandId
        //                     join cu in context.Customers on r.CustomerId equals cu.Id
        //                     join u in context.Users on cu.UserId equals u.Id
        //                     select new RentalDetailsDto
        //                     {
        //                         Id = r.Id,
        //                         UserName = u.FirstName + " " + u.LastName,
        //                         CarName = c.CarName,
        //                         CompanyName = cu.CompanyName,
        //                         BrandName = b.BrandName,
        //                         RentDate = r.RentDate,
        //                         ReturnDate = r.ReturnDate
        //                     };
        //        return result.ToList();
        //    }
        //}
    }

}
