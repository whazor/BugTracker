using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BugTrackerScreens
{
	public class PrioriteitConverter  : IValueConverter
	{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
		return "test";
        //return ((double)value * (double)parameter);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return true;
    }
	}
}