using Medyasoft.HealthCare.Contracts.Services.General;
using Medyasoft.HealthCare.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medyasoft.HealthCare.ViewModels
{
    public class ContactViewModel : ViewModelBase
    {
        private string _email;
        private string _message;

        public ContactViewModel(IConnectionService connectionService,
            INavigationService navigationService, IDialogService dialogService
            )
            : base(connectionService, navigationService, dialogService)
        {
          
        }
        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        private async void OnSubmitMessage()
        {
         
        }

        private void OnCallPhone()
        {
            
        }
    }
}
