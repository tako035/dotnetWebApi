using Core.DataAccess.EfEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Org.BouncyCastle.Asn1.Misc;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUSerDal : EfEntityRepositoryBase<User, ShopContext>, IUserDal
    {
        public List<UserOperations> GetOperations(User user)
        {
            using (var context = new ShopContext())
            {
              var result = from UserOperations in context.UserOperations
                join UserPermissions in context.UserPermissions
                  on UserOperations.Id equals UserPermissions.OperationId
                where UserPermissions.UserId == user.Id
                select new UserOperations { Id = UserOperations.Id, Name = UserOperations.Name};
              return result.ToList();
            }

        }
    }
}