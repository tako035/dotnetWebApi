using System;
using Core.Utilities.Security.jwt;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption
{
    public class SecuiryKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(securityKey));
        }
    }
}

