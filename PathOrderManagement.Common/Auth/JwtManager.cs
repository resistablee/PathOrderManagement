using Microsoft.IdentityModel.Tokens;
using PathOrderManagement.Common.Auth.Concrete;
using PathOrderManagement.Common.Constans;
using PathOrderManagement.Contract.App.Response.Login;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace PathOrderManagement.Common.Auth
{
    public class JwtManager
    {
        private static readonly byte[] SymmetricKey = Encoding.UTF8.GetBytes(AppConstants.SymmetricKey);

        public static TokenValidationParameters ValidationParameters => new TokenValidationParameters
        {
            RequireExpirationTime = true,
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateIssuerSigningKey = true,
            ClockSkew = TimeSpan.Zero,
            IssuerSigningKey = new SymmetricSecurityKey(SymmetricKey)
        };

        public GetTokenResponse GenerateToken(JwtContract user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Id", user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Name ?? String.Empty),
                    new Claim(ClaimTypes.Email, user.Email ?? String.Empty),
                    new Claim(ClaimTypes.Role, user.UserType.ToString() ?? String.Empty)
                }),
                Expires = DateTime.UtcNow.AddMinutes(AppConstants.AccessTokenExpireMinute),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(AppConstants.SymmetricKey)), SecurityAlgorithms.HmacSha256Signature)
            };

            var jwtToken = (JwtSecurityToken)tokenHandler.CreateToken(tokenDescriptor);

            return new GetTokenResponse
            {
                AccessToken = jwtToken.RawData,
                ExpiresIn = jwtToken.Payload.Exp,
                RefreshToken = GenerateRefreshToken(),
                RefreshTokenExpireDate = DateTime.UtcNow.AddMinutes(AppConstants.RefreshTokenExpireMinute),
            };
        }

        private static string GenerateRefreshToken()
        {
            var number = new byte[32];
            using var random = RandomNumberGenerator.Create();
            random.GetBytes(number);
            return Convert.ToBase64String(number);
        }
    }
}
