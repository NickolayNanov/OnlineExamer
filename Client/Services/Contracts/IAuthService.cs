namespace OnlineExamer.Client.Services.Contracts
{
    using System.Threading.Tasks;

    using OnlineExamer.Shared.Models;

    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);

        Task Logout();

        Task<RegisterResult> Register(RegisterModel registerModel);

        //Task SetAuthenticationHeaderHeaderAsync();
    }
}
