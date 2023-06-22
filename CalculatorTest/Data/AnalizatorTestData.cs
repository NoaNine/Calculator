namespace CalculatorTest.Data
{
    public class AnalizatorTestData
    {
        public static IEnumerable<object[]> LexicalAnalize_ConvertToListLexeme_SingleDigitsNumbers_Data()
        {
            return new[]
            {
                new object[]
                {
                    "2+(3*3)",
                    new List<Lexeme>
                    {
                        new Lexeme { Type = LexemeType.Number, Value = "2" },
                        new Lexeme { Type = LexemeType.Plus, Value="+" },
                        new Lexeme { Type = LexemeType.LeftBracket, Value="(" },
                        new Lexeme { Type = LexemeType.Number, Value="3" },
                        new Lexeme { Type = LexemeType.Multiplication, Value="*" },
                        new Lexeme { Type = LexemeType.Number, Value="3" },
                        new Lexeme { Type = LexemeType.RightBracket, Value=")" }
                    }
                }
            };
        }

        public static IEnumerable<object[]> LexicalAnalize_ConvertToListLexeme_MultiDigitNumbers_Data()
        {
            return new[]
            {
                new object[]
                {
                    "2222+(30*35)",
                    new List<Lexeme>
                    {
                        new Lexeme { Type = LexemeType.Number, Value = "2222" },
                        new Lexeme { Type = LexemeType.Plus, Value="+" },
                        new Lexeme { Type = LexemeType.LeftBracket, Value="(" },
                        new Lexeme { Type = LexemeType.Number, Value="30" },
                        new Lexeme { Type = LexemeType.Multiplication, Value="*" },
                        new Lexeme { Type = LexemeType.Number, Value="35" },
                        new Lexeme { Type = LexemeType.RightBracket, Value=")" }
                    }

                }
            };
        }

        public static IEnumerable<object[]> LexicalAnalize_ConvertToListLexeme_DecimalNubmers_Data()
        {
            return new[]
            {
                new object[]
                {
                    "2.35+(3*3.6876)",
                    new List<Lexeme>
                    {
                        new Lexeme { Type = LexemeType.Number, Value = "2.35" },
                        new Lexeme { Type = LexemeType.Plus, Value="+" },
                        new Lexeme { Type = LexemeType.LeftBracket, Value="(" },
                        new Lexeme { Type = LexemeType.Number, Value="3" },
                        new Lexeme { Type = LexemeType.Multiplication, Value="*" },
                        new Lexeme { Type = LexemeType.Number, Value="3.6876" },
                        new Lexeme { Type = LexemeType.RightBracket, Value=")" }
                    }

                }
            };
        }

        public static IEnumerable<object[]> LexicalAnalize_ConvertToListLexeme_WithSpaces_Data()
        {
            return new[]
            {
                new object[]
                {
                    " 2+ ( 3*3 ) ",
                    new List<Lexeme>
                    {
                        new Lexeme { Type = LexemeType.Number, Value = "2" },
                        new Lexeme { Type = LexemeType.Plus, Value="+" },
                        new Lexeme { Type = LexemeType.LeftBracket, Value="(" },
                        new Lexeme { Type = LexemeType.Number, Value="3" },
                        new Lexeme { Type = LexemeType.Multiplication, Value="*" },
                        new Lexeme { Type = LexemeType.Number, Value="3" },
                        new Lexeme { Type = LexemeType.RightBracket, Value=")" }
                    }

                }
            };
        }
    }
}
