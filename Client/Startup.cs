namespace OnlineExamer.Client
{
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Builder;
    using Microsoft.Extensions.DependencyInjection;

    using OnlineExamer.Client.Infrastructure;
    using OnlineExamer.Client.Infrastructure.LocalStorage;
    using OnlineExamer.Client.Infrastructure.LocalStorage.Contracts;
    using OnlineExamer.Client.Services;
    using OnlineExamer.Client.Services.Contracts;
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthorizationCore();

            services.AddScoped<ILocalStorageService, LocalStorageService>();
            services.AddSingleton<AuthenticationStateProvider, OnlineExamerStateProvider>();
            services.AddSingleton<ITokenService, TokenService>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddSingleton<IApiService, ApiService>();
        }
        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
