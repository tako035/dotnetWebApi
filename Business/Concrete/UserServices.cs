using System;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Core.Entities.Concrete;

namespace Business.Concrete
{
    public class UserServices: IUserService
    {
        IUserDal _userDal;

        public UserServices(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<UserOperations> GetClaims(User user)
        {
            return _userDal.GetOperations(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}

