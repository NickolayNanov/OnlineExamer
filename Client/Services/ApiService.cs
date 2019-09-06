namespace OnlineExamer.Client.Services
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using OnlineExamer.Client.Infrastructure.LocalStorage.Contracts;
    using OnlineExamer.Client.Services.Contracts;
    using OnlineExamer.Shared;
    using OnlineExamer.Shared.Models;

    public class ApiService : IApiService
    {
        private readonly HttpClient httpClient;
        private readonly AuthenticationStateProvider authenticationStateProvider;
        private readonly ILocalStorageService localStorage;
        private readonly IAuthService authService;

        public ApiService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage,
                           IAuthService authService)
        {
            this.httpClient = httpClient;
            this.authenticationStateProvider = authenticationStateProvider;
            this.localStorage = localStorage;
            this.authService = authService;
        }

        public async Task<ApiResponse<WeatherForecast[]>> GetForecastAsync()
        {
            return await this.GetJson<WeatherForecast[]>("api/WeatherForecast");
        }

        private async Task<ApiResponse<T>> PostJson<T>(string url, object request)
        {
            var authState = await this.authenticationStateProvider.GetAuthenticationStateAsync();
            var token = await this.authService.GetAuthToken();

            if (authState.User.Identity.IsAuthenticated)
            {
                this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            else
            {
                this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            try
            {
                return await this.httpClient.PostJsonAsync<ApiResponse<T>>(url, request);
            }
            catch (Exception ex)
            {
                return new ApiResponse<T> { Errors = new List<string> { ex.Message, ex.InnerException?.Message }, Succeeded = false } ;
            }
        }

        private async Task<ApiResponse<T>> GetJson<T>(string url)
        {
            var authState = await this.authenticationStateProvider.GetAuthenticationStateAsync();
            var token = await this.authService.GetAuthToken();

            if (authState.User.Identity.IsAuthenticated)
            {
                this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            else
            {
                this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var data = await this.httpClient.GetJsonAsync<T>(url);

            try
            {
                return new ApiResponse<T>() { Succeeded = true, Data = data };
            }
            catch (Exception ex)
            {
                return new ApiResponse<T> { Errors = new List<string> { ex.Message, ex.InnerException?.Message }, Succeeded = false };
            }
        }
    }
}
