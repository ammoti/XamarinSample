using Medyasoft.HealthCare.Contracts.Services.General;
using Medyasoft.HealthCare.Models;
using Medyasoft.HealthCare.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Medyasoft.HealthCare.ViewModels
{
    public class ChartViewModel:ViewModelBase
    {
        public ChartViewModel(IConnectionService connectionService,
          INavigationService navigationService, IDialogService dialogService
          )
          : base(connectionService, navigationService, dialogService)
        {
         
        }
        
    }
}