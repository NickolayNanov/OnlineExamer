namespace OnlineExamer.Client.Services.Contracts
{
    using System.Threading.Tasks;

    public interface ITokenService
    {
        Task SaveAccessToken(string Token);

        Task<string> GetAccessToken();
    }
}
