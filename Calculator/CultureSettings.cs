using System.Globalization;

namespace Calculator
{
    public class CultureSettings : ICultureSettings
    {
        public CultureInfo Culture { get; private set; }
        public char GetDecimalSeparator { get; private set; }

        public CultureSettings(CultureInfo culture)
        {
            Culture = culture;
            GetDecimalSeparator = char.Parse(Culture.NumberFormat.NumberDecimalSeparator);
        }
    }
}
