using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaskedEntry
{
    public class MaskedPhone : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            object mask = "";
            if (value != null) {
                string _value = value.ToString();

                if (_value.Length == 12)
                {
                    string ddd = _value.Substring(0, 3);
                    string digInicial = _value.Substring(3, 5);
                    string digFinal = _value.Substring(8, 4);
                    mask = string.Format("({0}) {1}-{2}", ddd, digInicial, digFinal);
                    return mask;
                }
                else if (_value.Length == 11)
                {
                    string ddd = _value.Substring(0, 3);
                    string digInicial = _value.Substring(3, 4);
                    string digFinal = _value.Substring(7, 4);
                    mask = string.Format("({0}) {1}-{2}", ddd, digInicial, digFinal);
                    return mask;
                }
            }
        
            return mask;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
