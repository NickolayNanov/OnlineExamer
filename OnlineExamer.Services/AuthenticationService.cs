namespace OnlineExamer.Services
{
    using System;
    using System.Linq;
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

        public async Task<AuthenticationResult> Login(LoginModel loginModel)
        {
            if (loginModel == null)
            {
                throw new ArgumentNullException();
            }

            AuthenticationResult authenticationResult = new AuthenticationResult();
            ApplicationUser applicationUser = await this.userManager.FindByEmailAsync(loginModel.Email);

            if (applicationUser == null)
            {
                authenticationResult.Errors = "Не съществува потребител с тази Е-Поща";
                return authenticationResult;
            }

            SignInResult result = await TryPsswordSignInAsync(loginModel, applicationUser);
            if (!result.Succeeded)
            {
                authenticationResult.Errors = "Невалидна парола!";
            }
            else
            {
                await PrepareSuccessfullResultAsync(authenticationResult, applicationUser);
            }

            return authenticationResult;
        }

        

        public async Task<AuthenticationResult> Register(RegisterModel registerModel)
        {
            if (registerModel == null)
            {
                throw new ArgumentNullException();
            }

            ApplicationUser applicationUser = new ApplicationUser(registerModel.Email, registerModel.FullName);
            IdentityResult result =  await this.userManager.CreateAsync(applicationUser, registerModel.Password);
            AuthenticationResult authenticationResult = new AuthenticationResult();

            if (!result.Succeeded)
            {
                authenticationResult.Errors = "Вероятно Е-пощата, която използвате е заета. Моля опитайте друга.";
            }
            else
            {
                await this.PrepareSuccessfullResultAsync(authenticationResult, applicationUser);
            }

            return authenticationResult;
        }

        public async Task Logout()
        {
            await this.signInManager.SignOutAsync();
        }

        private async Task PrepareSuccessfullResultAsync(AuthenticationResult authenticationResult, ApplicationUser applicationUser)
        {
            await this.signInManager.SignInAsync(applicationUser, true);
            authenticationResult.Succeeded = true;
        }

        private async Task<SignInResult> TryPsswordSignInAsync(LoginModel loginModel, ApplicationUser applicationUser)
        {
            return await this.signInManager
                            .PasswordSignInAsync(
                                applicationUser,
                                loginModel.Password,
                                false,
                                false);
        }
    }
}
