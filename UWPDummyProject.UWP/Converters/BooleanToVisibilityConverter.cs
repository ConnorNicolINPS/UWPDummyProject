namespace UWPDummyProject.UWP.Converters
{
    using System;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Data;


    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Windows.UI.Xaml.Data.IValueConverter" />
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var invert = parameter is string && ((string)parameter).ToLowerInvariant() == "invert";
            var val = (bool)value;

            Visibility visibility;
            if (val)
            {
                visibility = invert ? Visibility.Collapsed : Visibility.Visible;
            }
            else
            {
                visibility = invert ? Visibility.Visible : Visibility.Collapsed;
            }

            return visibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
