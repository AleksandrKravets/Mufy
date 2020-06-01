using Mufy.Application.Factories.Contracts;
using System;
using System.Security.Cryptography;

namespace Mufy.Application.Factories.Implementations
{
    internal sealed class TokenFactory : ITokenFactory
    {
        public string GenerateToken(int size = 32)
        {
            var randomNumber = new byte[size];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }
    }
}
