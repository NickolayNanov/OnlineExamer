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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            AuthenticationResult result = await this.authenticationService.Login(loginModel);

            if (result.Succeeded)
            {
                return this.Redirect("/");
            }
            else
            {
                this.ViewData["Errors"] = result.Errors;
                return this.View(loginModel);
            }
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            AuthenticationResult result = await this.authenticationService.Register(registerModel);

            if (result.Succeeded)
            {
                return this.Redirect("/Authentication/Login");
            }
            else
            {

                this.ViewData["Errors"] = result.Errors;
                return this.View(registerModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await this.authenticationService.Logout();
            return this.Redirect("/");
        }
    }
}