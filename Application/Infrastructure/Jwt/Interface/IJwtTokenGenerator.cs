using System.Security.Claims;

namespace Application.Infrastructure.Jwt.Interface
{
    public interface IJwtTokenGenerator
    {
        string CreateToken(List<Claim> claims);
    }
}
