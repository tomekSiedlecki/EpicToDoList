﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace EpicToDoList.converters
{
    public class BoolToImageConverter : IValueConverter
    {
        const string basePath = "../assets/";
        const string donePath = basePath + "paprika.gif";
        const string notDonePath = basePath + "nerd-emoji.gif";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool val = (bool)value;
            if (val)
            {
                return donePath;
            }
            else
            {
                return notDonePath;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
