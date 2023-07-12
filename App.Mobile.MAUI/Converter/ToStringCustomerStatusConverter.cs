using App.Mobile.MAUI.ViewModel;
using System.Globalization;

namespace App.Mobile.MAUI.Converter
{
    public class ToStringCustomerStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int)
            {
                var enumStatus = (CustomerStatus)value;

                return enumStatus.ToString();
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            var enumStatusValue = (int)value;

            return enumStatusValue;
        }
    }
}