﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Infrastructure.Services.Interfaces
{
    public interface IKeyManager
    {
        Task<RsaSecurityKey> GetPrivateRsaSecurityKeyAsync();
        Task<RsaSecurityKey> GetPublicRsaSecurityKeyAsync();
        Task<byte[]> HmacKeyAsync {  get; }
    }
}
