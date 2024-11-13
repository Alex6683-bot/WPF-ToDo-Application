using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ToDo.ValueConverters
{
    class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(DateTime))
            {
                DateTime dateTime = (DateTime)value;
                return dateTime.ToString("dd/MM/yyyy");
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        { 
            try 
            {
                DateTime date = DateTime.Parse((string)value);
                return date;

            } catch { return null; }
        }
    }
}
