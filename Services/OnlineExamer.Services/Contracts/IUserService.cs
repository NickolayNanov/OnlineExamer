namespace OnlineExamer.Services.Contracts
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;

    using OnlineExamer.Shared.Models;

    public interface IUserService
    {
        Task<SignInResult> LoginAsync(LoginModel model);

        Task<IdentityResult> RegisterAsync(RegisterModel model);

        string BuildToken(string email);
    }
}
