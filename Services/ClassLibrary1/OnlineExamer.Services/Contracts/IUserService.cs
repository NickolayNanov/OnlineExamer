namespace OnlineExamer.Services.Contracts
{
    using Microsoft.AspNetCore.Identity;
    using OnlineExamer.Shared.Models;
    using System.Threading.Tasks;

    public interface IUserService
    {
        Task<IdentityResult> RegisterAsync(RegisterModel registerModel);

        Task<SignInResult> LoginAsync(LoginModel loginModel);

        string BuildToken(string email);
    }
}
