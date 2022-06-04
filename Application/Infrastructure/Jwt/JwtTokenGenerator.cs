using Application.Infrastructure.Jwt.Interface;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Infrastructure.Jwt
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly IJwtConfiguration jwtConfiguration;

        public JwtTokenGenerator(IJwtConfiguration jwtConfiguration) 
        {
            this.jwtConfiguration = jwtConfiguration;
        }

        public string CreateToken(List<Claim> claims)
        {
            var key = Encoding.ASCII.GetBytes(jwtConfiguration.SecretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims.ToArray()),
                Expires = DateTime.Now.AddMinutes(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
