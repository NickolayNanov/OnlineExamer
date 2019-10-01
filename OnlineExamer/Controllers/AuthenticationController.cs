namespace OnlineExamer.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using OnlineExamer.Models.Authentication;
    using OnlineExamer.Services.Contracts;

    [AllowAnonymous]
    public class AuthenticationController : BaseController
    {
        private readonly IAuthenticationService authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.Redirect("/");
            }

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            await this.authenticationService.Login(loginModel);
            return this.Redirect("/");
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.Redirect("/");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            await this.authenticationService.Register(registerModel).ConfigureAwait(true);
            return this.Redirect("/Authentication/Login");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await this.authenticationService.Logout();
            return this.Redirect("/");
        }
    }
}