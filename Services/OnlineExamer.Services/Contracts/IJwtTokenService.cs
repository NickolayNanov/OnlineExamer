namespace Examer.Services.Contracts
{
    public interface IJwtTokenService
    {
        string BuildToken(string email);
    }
}
