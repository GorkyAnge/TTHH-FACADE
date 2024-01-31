using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ModeladoTTHH.Models;
using ModeladoTTHH.Services;

namespace ModeladoTTHH.Facades
{
    public class LoginFacade
    {
        private readonly IEmisorService _emisorService;
        private readonly NavigationManager _navigationManager;

        public LoginFacade(IEmisorService emisorService, NavigationManager navigationManager)
        {
            _emisorService = emisorService;
            _navigationManager = navigationManager;
        }

        public async Task<IEnumerable<Emisor>> ObtenerEmisores()
        {
            return await _emisorService.ObtenerEmisores();
        }

        public void NavigateToHome()
        {
            _navigationManager.NavigateTo("/");
        }
    }

}
