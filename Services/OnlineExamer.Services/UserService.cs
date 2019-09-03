namespace OnlineExamer.Services
{
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;

    using OnlineExamer.Data.Domain;
    using OnlineExamer.Services.Contracts;
    using OnlineExamer.Shared.Models;

    public class UserService : IUserService
    {
        private readonly IConfiguration configuration;
        private readonly UserManager<ExamerUser> userManager;
        private readonly SignInManager<ExamerUser> signInManager;

        public UserService(UserManager<ExamerUser> userManager,SignInManager<ExamerUser> signInManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
        }

        public async Task<SignInResult> LoginAsync(LoginModel model)
        {
            var user = await this.userManager.FindByEmailAsync(model.Email);
            if(user == null)
            {
                return null;
            }

            return await this.signInManager.PasswordSignInAsync(user, model.Password, true, true);
        }

        public async Task<IdentityResult> RegisterAsync(RegisterModel model)
        {
            ExamerUser user = new ExamerUser() { Email = model.Email, UserName = model.Email };
            return await this.userManager.CreateAsync(user, model.Password);
        }

        public string BuildToken(string email)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(this.configuration["JwtSettings:SecretKey"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = this.configuration["JwtSettings:Issuer"],
                Audience = this.configuration["JwtSettings:Audience"],
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, email)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        } 
    }
}
