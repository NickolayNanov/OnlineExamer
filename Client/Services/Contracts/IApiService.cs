namespace OnlineExamer.Client.Services.Contracts
{
    using System.Threading.Tasks;

    using OnlineExamer.Shared;
    using OnlineExamer.Shared.Models;

    public interface IApiService
    {
        Task<ApiResponse<WeatherForecast[]>> GetForecastAsync();
    }
}
