using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace univer.Models.Domain
{
    public class JwtAuthPayload
    {

        public int ExpireMinutes { get; set; } = 10080;
        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha256Signature;
        public Claim[] Claims { get; set; }

        public JwtAuthPayload(long userId)
        {
            Claims = new Claim[] { new Claim("userId", userId.ToString()) };
        }
    }
}
