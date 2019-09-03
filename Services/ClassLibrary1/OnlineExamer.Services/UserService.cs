namespace OnlineExamer.Services
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;
    using OnlineExamer.Domain;
    using OnlineExamer.Services.Contracts;
    using OnlineExamer.Shared.Models;
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        private readonly UserManager<ExamerUser> userManager;
        private readonly SignInManager<ExamerUser> signInManager;
        private readonly IConfiguration configuration;

        public UserService(UserManager<ExamerUser> userManager, SignInManager<ExamerUser> signInManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
        }

        public string BuildToken(string email)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["JwtSettings:SecretKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(this.configuration["JwtSettings:"]));

            var token = new JwtSecurityToken(
                this.configuration["JwtSettings:Issuer"],
                this.configuration["JwtSettings:Audience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<SignInResult> LoginAsync(LoginModel loginModel)
        {
            var user = await this.userManager.FindByEmailAsync(loginModel.Email);
            return await this.signInManager.PasswordSignInAsync(user, loginModel.Password, true, true);
        }

        public async Task<IdentityResult> RegisterAsync(RegisterModel registerModel)
        {
            var user = new ExamerUser() { Email = registerModel.Email, UserName = registerModel.Email };
            return await this.userManager.CreateAsync(user, registerModel.Password);
        }
    }
}
