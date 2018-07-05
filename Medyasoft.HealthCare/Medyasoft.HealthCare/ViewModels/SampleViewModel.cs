using Medyasoft.HealthCare.Contracts.Services.General;
using Medyasoft.HealthCare.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medyasoft.HealthCare.ViewModels
{
    public class SampleViewModel : ViewModelBase
    {
        public SampleViewModel(IConnectionService connectionService, INavigationService navigationService, IDialogService dialogService) : base(connectionService, navigationService, dialogService)
        {
        }
    }
}
