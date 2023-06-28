namespace Calculator
{
    public class CultureSettings : ICultureSettings
    {
        public string Culture { get; private set; }
        public char GetDecimalSeparator { get; private set; }

        public CultureSettings()
        {

        }
    }
}
