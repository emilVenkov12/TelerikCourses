using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows;

namespace HumansAndCanibals.ViewModels
{
    public class BoatPosToFlowDirectionConventer : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            char boatPos = char.Parse(value.ToString());
            return boatPos == 'L' ? FlowDirection.LeftToRight : FlowDirection.RightToLeft;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
