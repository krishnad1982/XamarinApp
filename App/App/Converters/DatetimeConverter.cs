using System;
using System.Globalization;
using Xamarin.Forms;

namespace App.Converters
{
    public class DatetimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            var dateTime = DateTime.Parse(value.ToString());

            return dateTime.ToString("dd/MM/yyyy hh:mm:ss");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
