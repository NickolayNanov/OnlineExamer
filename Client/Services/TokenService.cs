namespace OnlineExamer.Client.Services
{
    using System.Threading.Tasks;

    using Microsoft.JSInterop;

    using OnlineExamer.Client.Services.Contracts;

    public class TokenService : ITokenService
    {
       
        private readonly IJSRuntime jSRuntime;

        public TokenService(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        public async Task<string> GetAccessToken()
        {
            return await this.jSRuntime.InvokeAsync<string>("wasmHelper.getAccessToken");
        }

        public Task SaveAccessToken(string token)
        {
            return this.jSRuntime.InvokeAsync<object>("wasmHelper.saveAccessToken", token);
        }
    }
}
