using System.Globalization;

namespace Calculator
{
    public interface ICultureSettings
    {
        CultureInfo Culture { get; }
        char DecimalSeparator { get; }
    }
}