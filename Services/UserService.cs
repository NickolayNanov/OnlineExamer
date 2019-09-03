namespace Examer.Services
{
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;
    using Examer.Domain;
    using Examer.Services.Contracts;
    using Examer.Shared.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;

    public class UserService : IUserService
    {
        private readonly UserManager<ExamerUser> _userManager;
        private readonly IConfiguration configuration;


        public UserService(
            UserManager<ExamerUser> userManager,
            IConfiguration configuration)
        {
            this._userManager = userManager;
            this.configuration = configuration;
        }


        public async Task<string> LoginAsync(LoginModel model)
        {
            var user = await this._userManager.FindByEmailAsync(model.Email);
            var result = await this._userManager.CheckPasswordAsync(user, model.Password);

            if (!result)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(this.configuration["JwtTokenValidation:JwtSecurityKey"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(ClaimTypes.Email, user.Email),
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public async Task<ExamerUser> RegisterAsync(RegisterModel model)
        {
            var user = new ExamerUser() { Email = model.Email, UserName = model.Email };
            var result = await this._userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return null;
            }

            return await this._userManager.FindByEmailAsync(model.Email);
        }
    }
}
