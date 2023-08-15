using System;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user,List<UserOperations> userOperations);
    }
}

