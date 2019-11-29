namespace OnlineExamer.Services
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using OnlineExamer.Domain;
    using OnlineExamer.Models.Authentication;
    using OnlineExamer.Services.Contracts;

    public class AuthenticationService : IAuthenticationService
    {
        private const string EmailDoesNotExistErrorMessage = "- Не съществува потребител с тази Е-Поща";
        private const string InvalidPasswordErrorMessage = "- Невалидна парола!";
        private const string AlreadyTakenEmailErrorMessage = "- Вероятно Е-пощата, която използвате е заета. Моля опитайте друга.";
        private const string InvalidUsernameErrorMessage = "- Името ви може да съсържа само главни и малки латински букви. Не се допускат цифри и спейсове.";
        private const string AlreadyTakenUsernameErrorMessage = "- Името, което въведохте вече е заето.";
        private const string PasswordRequirementsErrorMessage = "- Паролата трябва да съдържа поне една (a-z).";
        private const string UserRole = "User";
        private const string AdminRole = "Admin";

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly StringBuilder stringBuilder;

        public AuthenticationService(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;

            this.stringBuilder = new StringBuilder();
        }

        public async Task<AuthenticationResult> Login(LoginModel loginModel)
        {
            await SeedAdmin();

            if (loginModel == null)
            {
                throw new ArgumentNullException();
            }

            AuthenticationResult authenticationResult = new AuthenticationResult();
            ApplicationUser applicationUser = await this.userManager.FindByEmailAsync(loginModel.Email);

            if (applicationUser == null)
            {
                authenticationResult.Errors = EmailDoesNotExistErrorMessage;
                return authenticationResult;
            }

            var result = await TryPsswordSignInAsync(loginModel, applicationUser);

            if (!result.Succeeded)
            {
                authenticationResult.Errors = InvalidPasswordErrorMessage;
            }
            else
            {
                await PrepareSuccessfullResultAsync(authenticationResult, applicationUser);
            }

            return authenticationResult;
        }



        public async Task<AuthenticationResult> Register(RegisterModel registerModel)
        {
            await SeedAdmin();

            if (registerModel == null)
            {
                throw new ArgumentNullException();
            }

            var authenticationResult = new AuthenticationResult();

            if (!await this.userManager.Users.AnyAsync(user => user.Email.Equals(registerModel.Email)))
            {
                var applicationUser = new ApplicationUser(registerModel.Email, registerModel.FullName);
                var result = await this.userManager.CreateAsync(applicationUser, registerModel.Password);

                if (!result.Succeeded)
                {
                    this.PrepareErrorMessages(result);
                    authenticationResult.Errors = stringBuilder.ToString();
                }
                else
                {
                    await this.userManager.AddToRoleAsync(applicationUser, UserRole);
                    await this.PrepareSuccessfullResultAsync(authenticationResult, applicationUser);
                }

                return authenticationResult;
            }

            authenticationResult.Succeeded = false;
            authenticationResult.Errors = AlreadyTakenEmailErrorMessage;
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


        private async Task SeedAdmin()
        {
            await SeedRoles();
            var admin = new ApplicationUser("admin@admin.bg", "Admin Admin Admin");

            if (!this.userManager.Users.Any(user => user.UserName == "admin@admin.bg"))
            {
                await this.userManager.CreateAsync(admin, "admin123");
                await this.userManager.AddToRoleAsync(admin, AdminRole);
            }
        }

        private async Task SeedRoles()
        {
            if (!this.roleManager.Roles.Any())
            {
                IdentityRole[] roles = new IdentityRole[] { new IdentityRole("Admin"), new IdentityRole("User") };

                for (int i = 0; i < roles.Length; i++)
                {
                    await this.roleManager.CreateAsync(roles[i]);
                }
            }
        }

        private void PrepareErrorMessages(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                if (error.Code.Equals("InvalidUserName"))
                {
                    stringBuilder.AppendLine(InvalidUsernameErrorMessage);
                }

                if (error.Code.Equals("DuplicateName"))
                {
                    stringBuilder.AppendLine(AlreadyTakenUsernameErrorMessage);
                }

                if (error.Code.Equals("AlreadyTakenEmailErrorMessage"))
                {
                    stringBuilder.AppendLine(InvalidPasswordErrorMessage);
                }

                if (error.Code.Equals("PasswordRequiresLower"))
                {
                    stringBuilder.AppendLine(PasswordRequirementsErrorMessage);
                }
            }
        }
    }
}
