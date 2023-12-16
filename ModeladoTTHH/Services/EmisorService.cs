using ModeladoTTHH.Models;

namespace ModeladoTTHH.Services;

public class EmisorService : IEmisorService
{
    private readonly HttpClient _httpClient;

    public EmisorService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Emisor>> ObtenerEmisores()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<Emisor>>($"api/Varios/GetEmisor");
    }
}