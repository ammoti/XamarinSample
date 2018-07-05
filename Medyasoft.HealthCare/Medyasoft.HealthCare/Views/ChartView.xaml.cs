using Medyasoft.HealthCare.Models;
using Medyasoft.HealthCare.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Medyasoft.HealthCare.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartView : ContentPage
    {
        public ChartView()
        {
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {

            }
        }
    }
}