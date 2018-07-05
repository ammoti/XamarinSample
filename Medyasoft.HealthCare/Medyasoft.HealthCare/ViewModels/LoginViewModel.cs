using Medyasoft.HealthCare.Contracts.Services.Data;
using Medyasoft.HealthCare.Contracts.Services.General;
using Medyasoft.HealthCare.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Medyasoft.HealthCare.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly ISettingsService _settingsService;

        private string _userName;
        private string _password;

        public LoginViewModel(IConnectionService connectionService, ISettingsService settingsService,
            INavigationService navigationService,
            IAuthenticationService authenticationService,
            IDialogService dialogService)
            : base(connectionService, navigationService, dialogService)
        {
            _authenticationService = authenticationService;
            _settingsService = settingsService;
        }

        public ICommand LoginCommand => new Command(OnLogin);

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        private async void OnLogin()
        {
            IsBusy = true;
            if (_connectionService.IsConnected)
            {
                if (UserName=="kamil" && Password =="kamil")
                {
                    _settingsService.UserIdSetting = "1";
                    _settingsService.UserNameSetting = "kamil";
                    IsBusy = false;
                    await _navigationService.NavigateToAsync<MainViewModel>();
                }
                //var authenticationResponse = await _authenticationService.Authenticate(UserName, Password);

                //if (authenticationResponse.IsAuthenticated)
                //{
                //    // we store the Id to know if the user is already logged in to the application
                //    _settingsService.UserIdSetting = authenticationResponse.User.Id;
                //    _settingsService.UserNameSetting = authenticationResponse.User.FirstName;

                //    IsBusy = false;
                //    await _navigationService.NavigateToAsync<MainViewModel>();
                //}
            }
            else
            {
                await _dialogService.ShowDialog(
                    "This username/password combination isn't known",
                    "Error logging you in",
                    "OK");
            }
        }

    
    }
}
