namespace CalculatorTest.Data
{
    public class AnalyzatorTestData
    {
        public static IEnumerable<object[]> LexicalAnalyze_ConvertToListLexeme_SingleDigitsNumbers_Data()
        {
            return new[]
            {
                new object[]
                {
                    "2+(3*3)",
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "2"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.LeftBracket, "("),
                        new Lexeme(LexemeType.Number, "3"),
                        new Lexeme(LexemeType.Multiplication, "*"),
                        new Lexeme(LexemeType.Number, "3"),
                        new Lexeme(LexemeType.RightBracket, ")"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    }
                }
            };
        }

        public static IEnumerable<object[]> LexicalAnalyze_ConvertToListLexeme_MultiDigitNumbers_Data()
        {
            return new[]
            {
                new object[]
                {
                    "2222+(30*35)",
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "2222"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.LeftBracket, "("),
                        new Lexeme(LexemeType.Number, "30"),
                        new Lexeme(LexemeType.Multiplication, "*"),
                        new Lexeme(LexemeType.Number, "35"),
                        new Lexeme(LexemeType.RightBracket, ")"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    }

                }
            };
        }

        public static IEnumerable<object[]> LexicalAnalyze_ConvertToListLexeme_DecimalNubmers_Data()
        {
            return new[]
            {
                new object[]
                {
                    "2.35+(3*3.6876)",
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "2.35"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.LeftBracket, "("),
                        new Lexeme(LexemeType.Number, "3"),
                        new Lexeme(LexemeType.Multiplication, "*"),
                        new Lexeme(LexemeType.Number, "3.6876"),
                        new Lexeme(LexemeType.RightBracket, ")"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    }

                }
            };
        }

        public static IEnumerable<object[]> LexicalAnalyze_ConvertToListLexeme_WithSpaces_Data()
        {
            return new[]
            {
                new object[]
                {
                    " 2+ ( 3*3 )   ",
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "2"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.LeftBracket, "("),
                        new Lexeme(LexemeType.Number, "3"),
                        new Lexeme(LexemeType.Multiplication, "*"),
                        new Lexeme(LexemeType.Number, "3"),
                        new Lexeme(LexemeType.RightBracket, ")"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    }
                }
            };
        }
    }
}
