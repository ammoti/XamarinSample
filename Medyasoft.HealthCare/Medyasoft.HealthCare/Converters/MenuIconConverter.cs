using Medyasoft.HealthCare.Enumerations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Medyasoft.HealthCare.Converters
{

    public class MenuIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = (MenuItemType)value;

            switch (type)
            {
                case MenuItemType.Home:
                    return "ic_home.png";
                case MenuItemType.Logout:
                    return "ic_logout.png";
                default:
                    return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Not needed here
            throw new NotImplementedException();
        }
    }
}
