﻿using System;

namespace Application.Framework.Responses.Identity
{
    public class TokenResponse
    {
        public string Token { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public string UserImageURL { get; set; } = string.Empty;
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}