namespace OnlineExamer.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Primitives;
    using OnlineExamer.Services.Contracts;
    using OnlineExamer.Shared.Models;
    using System.Linq;
    using System.Threading.Tasks;

    public class AccountsController : ApiController
    {
        private readonly IUserService userService;

        public AccountsController(IUserService userService, IConfiguration configuration)
            : base(configuration)
        {
            this.userService = userService;
        }

        [HttpGet]
        [Route("GetUser")]
        public UserInfo GetUser()
        {
            return this.User.Identity.IsAuthenticated ?
                new UserInfo { Name = this.User.Identity.Name, IsAuthenticated = this.User.Identity.IsAuthenticated } :
                new UserInfo { IsAuthenticated = false };
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest("Invalid input");
            }

            var result = await this.userService.LoginAsync(loginModel);

            if (!result.Succeeded)
            {
                return this.BadRequest(new LoginResult() { Successful = false, Error = "Invalid Username or Password" });
            }

            var token = this.userService.BuildToken(loginModel.Email);

            return this.Ok(new LoginResult() { Successful = true, Token = token, Email = loginModel.Email });
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
            var result = await this.userService.RegisterAsync(registerModel);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(error => error.Description);

                return this.BadRequest(new RegisterResult() { Successful = false, Errors = errors });
            }

            return this.Ok(new RegisterResult() { Successful = true });
        }
    }
}
