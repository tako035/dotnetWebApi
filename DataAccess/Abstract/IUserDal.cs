using System.Linq.Expressions;
using Core.DataAccess;
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{

    public interface IUserDal : IEntityRepository<User>
    {

      List<UserOperations> GetOperations(User user);

    }

}