namespace Calculator.Models
{
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
