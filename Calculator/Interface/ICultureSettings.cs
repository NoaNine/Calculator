namespace Calculator
{
    public interface ICultureSettings
    {
        string Culture { get; }
        char GetDecimalSeparator { get; }
    }
}