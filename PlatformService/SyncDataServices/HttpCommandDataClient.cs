using System.Net.Http;
using System.Threading.Tasks;
using PlatformService.DTOS;

namespace PlatformService.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {

        private readonly HttpClient _httpClient;

        public HttpCommandDataClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task SendPlatformToCommand(PlatformReadDto plat)
        {
            var httpClient = new StringContext(
                JsonSerializer.Serialize(plat),
                Encoding.UTF8,
                "application/json");

            var response = await _httpClient.PostAsync("http://localhost:6000/api/c/platforms");
              
        } 
    }
}