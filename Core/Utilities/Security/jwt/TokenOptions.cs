﻿using System;
namespace Core.Utilities.Security.jwt
{
    public class TokenOptions
    {
        public string? Audience { get; set; }
        public string? Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string? SecurityKey { get; set; } 
    }
}

