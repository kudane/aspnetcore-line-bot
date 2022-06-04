using Application.Infrastructure.Jwt.Interface;

namespace Application.Infrastructure.Jwt
{
    public sealed class JwtConfiguration : IJwtConfiguration
    {
        public string SecretKey { get; set; }
    }
}
