using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Medyasoft.HealthCare.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HealthCareNavigationPage : NavigationPage
    {
        public HealthCareNavigationPage()
        {
            InitializeComponent();
        }

        public HealthCareNavigationPage(Page root) : base(root)
        {
            InitializeComponent();
        }
    }
}