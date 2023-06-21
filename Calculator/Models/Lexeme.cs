namespace Calculator.Models
{
    public enum LexemeType
    {
        LeftBracket,
        RightBracket,
        Plus,
        Minus,
        Multiplication,
        Division,
        Number
    }

    public class Lexeme
    {
        public LexemeType Type { get; set; }
        public string Value { get; set; }
    }
}
