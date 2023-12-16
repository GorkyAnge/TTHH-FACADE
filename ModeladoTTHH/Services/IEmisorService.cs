using ModeladoTTHH.Models;

namespace ModeladoTTHH.Services;

public interface IEmisorService
{
    Task<IEnumerable<Emisor>> ObtenerEmisores();
}