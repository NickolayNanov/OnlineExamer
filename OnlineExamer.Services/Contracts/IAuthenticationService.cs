namespace OnlineExamer.Services.Contracts
{
    using System.Threading.Tasks;
    using OnlineExamer.Domain;
    using OnlineExamer.Models.Authentication;
    public interface IAuthenticationService
    {
        Task<AuthenticationResult> Login(LoginModel loginModel);

        Task<AuthenticationResult> Register(RegisterModel registerModel);

        Task Logout();
    }
}
