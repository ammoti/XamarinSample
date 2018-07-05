using Medyasoft.HealthCare.Contracts.Services.General;
using Medyasoft.HealthCare.Models;
using Medyasoft.HealthCare.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Medyasoft.HealthCare.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private ObservableCollection<Pie> _piesOfTheWeek;

        public HomeViewModel(IConnectionService connectionService,
            INavigationService navigationService,
            IDialogService dialogService) : base(connectionService, navigationService, dialogService)
        {
           
         

        }

        public ICommand PieTappedCommand => new Command<Pie>(OnPieTapped);
        public ICommand AddToCartCommand => new Command<Pie>(OnAddToCart);

        public ObservableCollection<Pie> PiesOfTheWeek
        {
            get => _piesOfTheWeek;
            set
            {
                _piesOfTheWeek = value;
                OnPropertyChanged();
            }
        }

        public override async Task InitializeAsync(object data)
        {
         //  PiesOfTheWeek = (await _catalogDataService.GetPiesOfTheWeekAsync()).ToObservableCollection();
        }

        private void OnPieTapped(Pie selectedPie)
        {
         //   _navigationService.NavigateToAsync<PieDetailViewModel>(selectedPie);
        }

        private async void OnAddToCart(Pie selectedPie)
        {
          //  MessagingCenter.Send(this, MessagingConstants.AddPieToBasket, selectedPie);
            await _dialogService.ShowDialog("Pie added to your cart", "Success", "OK");
        }
    }
}