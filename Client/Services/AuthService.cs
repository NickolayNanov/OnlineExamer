namespace OnlineExamer.Client.Services
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using OnlineExamer.Client.Infrastructure;
    using OnlineExamer.Client.Infrastructure.LocalStorage.Contracts;
    using OnlineExamer.Client.Services.Contracts;
    using OnlineExamer.Shared.Models;

    public class AuthService : IAuthService
    {
        private readonly HttpClient httpClient;
        private readonly AuthenticationStateProvider authenticationStateProvider;
        private readonly ILocalStorageService localStorage;

        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            this.httpClient = httpClient;
            this.authenticationStateProvider = authenticationStateProvider;
            this.localStorage = localStorage;
        }

        //public async Task SetAuthenticationHeaderHeaderAsync()
        //{
        //    var token = await this.localStorage.GetItemAsync<string>("authToken");
        //    if (token != null)
        //    {
        //        this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
        //    }
        //}

        public async Task<LoginResult> Login(LoginModel loginModel)
        {
            var result = await this.httpClient.PostJsonAsync<LoginResult>("api/Accounts/Login", loginModel);

            if (result.Successful)
            {
                await this.localStorage.SetItemAsync("authToken", result.Token);
                ((OnlineExamerStateProvider)this.authenticationStateProvider).MarkUserAsAuthenticated(result.Email);
                this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Token);
                return result;
            }

            return result;
        }

        public async Task Logout()
        {
            await this.localStorage.RemoveItemAsync("authToken");
            ((OnlineExamerStateProvider)this.authenticationStateProvider).MarkUserAsLoggedOut();
            this.httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<RegisterResult> Register(RegisterModel registerModel)
        {
            var result = await this.httpClient.PostJsonAsync<RegisterResult>("api/Accounts/Register", registerModel);
            return result;
        }
    }
}
