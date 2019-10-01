namespace OnlineExamer.Services
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;

    using OnlineExamer.Domain;
    using OnlineExamer.Models.Authentication;
    using OnlineExamer.Services.Contracts;

    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AuthenticationService(
            UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task Login(LoginModel loginModel)
        {
            if(loginModel == null)
            {
                throw new ArgumentNullException();
            }

            ApplicationUser applicationUser = await this.userManager.FindByEmailAsync(loginModel.Email);

            SignInResult result = await this.signInManager
                .PasswordSignInAsync(
                    applicationUser, 
                    loginModel.Password, 
                    false,
                    false);

            if (result.Succeeded)
            {
                await this.signInManager.SignInAsync(applicationUser, false);
            }
        }

        public async Task Register(RegisterModel registerModel)
        {
            if (registerModel == null)
            {
                throw new ArgumentNullException();
            }

            ApplicationUser applicationUser = new ApplicationUser(registerModel.Email, registerModel.FullName);
            await this.userManager.CreateAsync(applicationUser, registerModel.Password);
        }

        public async Task Logout()
        {
            await this.signInManager.SignOutAsync();
        }
    }
}
