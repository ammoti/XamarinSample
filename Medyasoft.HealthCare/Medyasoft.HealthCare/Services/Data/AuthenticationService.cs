using Medyasoft.HealthCare.Contracts.Repository;
using Medyasoft.HealthCare.Contracts.Services.Data;
using Medyasoft.HealthCare.Contracts.Services.General;
using Medyasoft.HealthCare.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Medyasoft.HealthCare.Services.Data
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IGenericRepository _genericRepository;
        private readonly ISettingsService _settingsService;
        public AuthenticationService(IGenericRepository genericRepository, ISettingsService settingsService)
        {
            _settingsService = settingsService;
            _genericRepository = genericRepository;

        }      

        public bool IsUserAuthenticated()
        {
            return !string.IsNullOrEmpty(_settingsService.UserIdSetting);
        }

        public async Task<AuthenticationResponse> Authenticate(string userName, string password)
        {
            UriBuilder builder = new UriBuilder("http")
            {
                Path ="http"
            };

            AuthenticationRequest authenticationRequest = new AuthenticationRequest()
            {
                UserName = userName,
                Password = password
            };

            return await _genericRepository.PostAsync<AuthenticationRequest, AuthenticationResponse>(builder.ToString(), authenticationRequest);
        }
    }
}
