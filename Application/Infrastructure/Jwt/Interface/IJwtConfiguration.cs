namespace Application.Infrastructure.Jwt.Interface
{
    public interface IJwtConfiguration
    {
        string SecretKey { get; }
    }
}
