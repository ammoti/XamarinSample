using Autofac;
using Medyasoft.HealthCare.Contracts.Repository;
using Medyasoft.HealthCare.Contracts.Services.Data;
using Medyasoft.HealthCare.Contracts.Services.General;
using Medyasoft.HealthCare.Repository;
using Medyasoft.HealthCare.Services.Data;
using Medyasoft.HealthCare.Services.General;
using Medyasoft.HealthCare.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medyasoft.HealthCare.Bootstrap
{
    public class AppContainer
    {
        private static IContainer _container;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //ViewModels
            builder.RegisterType<LoginViewModel>();
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<MenuViewModel>();
            builder.RegisterType<HomeViewModel>();
            builder.RegisterType<ContactViewModel>();
            builder.RegisterType<ChartViewModel>();
            builder.RegisterType<SampleViewModel>();

            ////services - data
            //builder.RegisterType<CatalogDataService>().As<ICatalogDataService>();
            //builder.RegisterType<ShoppingCartDataService>().As<IShoppingCartDataService>();
            //builder.RegisterType<ContactDataService>().As<IContactDataService>();
            //builder.RegisterType<OrderDataService>().As<IOrderDataService>();

            //services - general
            builder.RegisterType<ConnectionService>().As<IConnectionService>();
            builder.RegisterType<NavigationService>().As<INavigationService>();
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>();
            builder.RegisterType<DialogService>().As<IDialogService>();
            //builder.RegisterType<PhoneService>().As<IPhoneService>();
            builder.RegisterType<SettingsService>().As<ISettingsService>().SingleInstance();

            ////General
            builder.RegisterType<GenericRepository>().As<IGenericRepository>();

            _container = builder.Build();
        }

        public static object Resolve(Type typeName)
        {
            return _container.Resolve(typeName);
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
