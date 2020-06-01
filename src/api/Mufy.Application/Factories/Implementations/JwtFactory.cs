using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Mufy.Application.DataTransferObjects.Tokens;
using Mufy.Application.DataTransferObjects.Users;
using Mufy.Application.Factories.Contracts;
using Mufy.Common.Settings;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Mufy.Application.Factories.Implementations
{
    //internal sealed class JwtFactory : IJwtFactory
    //{
    //    private readonly JwtSettings _jwtSettings;

    //    internal JwtFactory(IOptions<JwtSettings> jwtSettings)
    //    {
    //        _jwtSettings = jwtSettings?.Value ?? throw new ArgumentNullException(nameof(jwtSettings));
    //        ThrowIfInvalidOptions(_jwtSettings);
    //    }

    //    public string GenerateEncodedToken(UserDto user)
    //    {
    //        var claims = new Claim[]
    //        {
    //            new Claim(JwtRegisteredClaimNames.Sub, user.Email),
    //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
    //            new Claim(JwtRegisteredClaimNames.Email, user.Email),
    //            //new Claim(Constants.CustomClaims.UserIdentifier, user.Id.ToString())
    //        };

    //        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
    //        var algorithm = SecurityAlgorithms.HmacSha256;
    //        var signingCredentials = new SigningCredentials(key, algorithm);

    //        var tokenDescriptor = new SecurityTokenDescriptor
    //        {
    //            Issuer = _jwtSettings.Issuer,
    //            Audience = _jwtSettings.Audience,
    //            NotBefore = DateTime.UtcNow,
    //            Subject = new ClaimsIdentity(claims),
    //            Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.AccessTokenLifetime),
    //            SigningCredentials = signingCredentials
    //        };

    //        var tokenHandler = new JwtSecurityTokenHandler();
    //        var token = tokenHandler.CreateToken(tokenDescriptor);
    //        string accessToken = tokenHandler.WriteToken(token);
    //        var refreshToken = GenerateRefreshToken();

    //        //await _tokenRepository.CreateAsync(new RefreshTokenDto
    //        //{
    //        //    JwtId = token.Id,
    //        //    CreationDate = DateTime.UtcNow,
    //        //    ExpiryDate = DateTime.UtcNow.AddMinutes(_jwtSettings.RefreshTokenLifetime),
    //        //    Token = refreshToken,
    //        //    UserId = user.Id
    //        //});

    //        return new TokensModel
    //        {
    //            AccessToken = accessToken,
    //            RefreshToken = refreshToken
    //        };
    //    }

    //    private static void ThrowIfInvalidOptions(JwtSettings options)
    //    {
    //        if (options.RefreshTokenLifetime <= 0)
    //        {
    //            throw new ArgumentException("Must be greater than zero.", nameof(options.RefreshTokenLifetime));
    //        }

    //        if (options.AccessTokenLifetime <= 0)
    //        {
    //            throw new ArgumentException("Must be greater than zero", nameof(options.AccessTokenLifetime));
    //        }
    //    }
    //}
}
