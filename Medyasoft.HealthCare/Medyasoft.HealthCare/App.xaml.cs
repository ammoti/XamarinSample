using System;
using Xamarin.Forms;
using Medyasoft.HealthCare.Views;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;
using Medyasoft.HealthCare.Bootstrap;
using Medyasoft.HealthCare.Contracts.Services.General;
using Medyasoft.HealthCare.ViewModels;

namespace Medyasoft.HealthCare
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InitializeApp();

            InitializeNavigation();
        }

        private async Task InitializeNavigation()
        {
            var navigationService = AppContainer.Resolve<INavigationService>();
            await navigationService.InitializeAsync();
        }

        private void InitializeApp()
        {
            AppContainer.RegisterDependencies();

            var shoppingCartViewModel = AppContainer.Resolve<ChartViewModel>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
