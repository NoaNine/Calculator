namespace CalculatorTest.Data
{
    public class MathTestData
    {
        public static IEnumerable<object[]> Calculate_SimpleExpression()
        {
            return new[]
            {
                new object[]
                {
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "2"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.Number, "4"),
                        new Lexeme(LexemeType.Minus, "-"),
                        new Lexeme(LexemeType.Number, "4")
                    },
                    2.0
                }
            };
        }

        public static IEnumerable<object[]> Calculate_ReturnZero()
        {
            return new[]
            {
                new object[]
                {
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "2"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.Number, "4"),
                        new Lexeme(LexemeType.Minus, "-"),
                        new Lexeme(LexemeType.Number, "8")
                    },
                    0.0
                }
            };
        }

        public static IEnumerable<object[]> Calculate_ExpressionWithBracketsPriority()
        {
            return new[]
            {
                new object[]
                {
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "2"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.Number, "4"),
                        new Lexeme(LexemeType.Division, "/"),
                        new Lexeme(LexemeType.LeftBracket, "("),
                        new Lexeme(LexemeType.Number, "0"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.Number, "1"),
                        new Lexeme(LexemeType.RightBracket, ")"),
                        new Lexeme(LexemeType.Minus, "-"),
                        new Lexeme(LexemeType.Number, "7")
                    },
                    -1.0
                }
            };
        }

        public static IEnumerable<object[]> Calculate_DecimalNumber()
        {
            return new[]
            {
                new object[]
                {
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "2.894"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.Number, "4.22222"),
                        new Lexeme(LexemeType.Multiplication, "*"),
                        new Lexeme(LexemeType.Number, "9.23453")
                    },
                    41.8842172566
                }
            };
        }

        public static IEnumerable<object[]> Calculate_BigDecimalNumber()
        {
            return new[]
            {
                new object[]
                {
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "44572.22222"),
                        new Lexeme(LexemeType.Multiplication, "*"),
                        new Lexeme(LexemeType.Number, "9946.23453")
                    },
                    443325775.723397
                }
            };
        }

        public static IEnumerable<object[]> Calculate_LargeNumber()
        {
            return new[]
            {
                new object[]
                {
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "44578432.22222"),
                        new Lexeme(LexemeType.Multiplication, "*"),
                        new Lexeme(LexemeType.Number, "9768946.23453")
                    },
                    435484307598507
                }
            };
        }

        public static IEnumerable<object[]> Calculate_DivisionByZero()
        {
            return new[]
            {
                new object[]
                {
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "5"),
                        new Lexeme(LexemeType.Division, "/"),
                        new Lexeme(LexemeType.Number, "0")
                    }
                }
            };
        }
    }
}
