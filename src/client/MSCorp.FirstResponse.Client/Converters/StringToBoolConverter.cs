﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace MSCorp.FirstResponse.Client.Converters
{
    public class StringToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return false;
            }

            string stringValue = value.ToString();

            if (string.IsNullOrEmpty(stringValue))
            {
                return false;
            }
            else
            {
                if (parameter == null)
                {
                    return true;
                }
                else
                {
                    string parameterValue = parameter.ToString();
                    return stringValue.Equals(parameterValue);
                }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
