using Core.Entities.Concrete;

namespace Business.Abstract
{
  public interface IUserService
  {
    List<UserOperations> GetClaims(User user);

    void Add(User user);

    User GetByMail(string email);
  }
}