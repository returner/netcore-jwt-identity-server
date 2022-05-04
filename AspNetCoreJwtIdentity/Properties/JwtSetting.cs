﻿using SharedModel.Interfaces.Configuration;

namespace AspNetCoreJwtIdentity.Properties
{
    public record JwtSetting : IJwtSetting
    {
        public string? SecretKey { get; init; }
        public string? Issuer { get; init; }
        public string? Audience { get; init; }
    }
}
