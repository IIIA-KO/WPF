using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using Color = System.Windows.Media.Color;

namespace HW5
{
    public class RGBToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new SolidColorBrush(Color.FromRgb(System.Convert.ToByte(values[0]), System.Convert.ToByte(values[1]), System.Convert.ToByte(values[2])));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            Color Color = ((SolidColorBrush)value).Color;
            return new object[] { (byte)Color.R, (byte)Color.G, (byte)Color.B };
        }
    }
}
