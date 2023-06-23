namespace Calculator.Models
{
    public enum LexemeType
    {
        LeftBracket = 0,
        RightBracket = 0,
        Plus = 1,
        Minus = 1,
        Multiplication = 2,
        Division = 2,
        Number = 3
    }

    public class Lexeme
    {
        public LexemeType Type { get; private set; }
        public string Value { get; private set; }

        public Lexeme(LexemeType type, string value) 
        {
            Type = type; 
            Value = value;
        }
    }
}
