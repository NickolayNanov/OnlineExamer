namespace OnlineExamer.Services.Contracts
{
    using System.Threading.Tasks;

    using OnlineExamer.Models.Authentication;
    public interface IAuthenticationService
    {
        Task Login(LoginModel loginModel);

        Task Register(RegisterModel registerModel);

        Task Logout();
    }
}
