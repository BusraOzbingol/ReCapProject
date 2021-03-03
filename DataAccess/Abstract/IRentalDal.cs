using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        //   List<RentalDetailsDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
        //   List<int> GetAllIds(Expression<Func<Rental, bool>> predicatee);
        
    }
}
