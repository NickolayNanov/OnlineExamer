using Examer.Domain;
using Examer.Shared.Models;
using System.Threading.Tasks;

namespace Examer.Services.Contracts
{
    public interface IUserService
    {
        Task<string> LoginAsync(LoginModel model);

        Task<ExamerUser> RegisterAsync(RegisterModel model);
    }
}
