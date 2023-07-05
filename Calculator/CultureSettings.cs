using System;
using System.Globalization;

namespace Calculator
{
    public class CultureSettings : ICultureSettings
    {
        public static CultureSettings CurrentSettingsCulture = new CultureSettings(CultureInfo.CurrentCulture);
        public CultureInfo Culture { get; private set; }
        public char DecimalSeparator { get; private set; }

        public CultureSettings(CultureInfo culture)
        {
            Culture = culture ?? throw new ArgumentNullException();
            DecimalSeparator = char.Parse(Culture.NumberFormat.NumberDecimalSeparator);
        }
    }
}
