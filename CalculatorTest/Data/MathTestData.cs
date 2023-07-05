namespace CalculatorTest.Data
{
    public class MathTestData
    {
        public static IEnumerable<object[]> Calculate_SimpleExpression_Data()
        {
            return new[]
            {
                new object[]
                {
                    "2+4-4",
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "2"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.Number, "4"),
                        new Lexeme(LexemeType.Minus, "-"),
                        new Lexeme(LexemeType.Number, "4"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    },
                    2.0
                }
            };
        }

        public static IEnumerable<object[]> Calculate_ReturnZero_Data()
        {
            return new[]
            {
                new object[]
                {
                    "2+4-6",
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "2"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.Number, "4"),
                        new Lexeme(LexemeType.Minus, "-"),
                        new Lexeme(LexemeType.Number, "6"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    },
                    0.0
                }
            };
        }

        public static IEnumerable<object[]> Calculate_ExpressionWithBracketsPriority_Data()
        {
            return new[]
            {
                new object[]
                {
                    "2+4/(0+1)-7",
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
                        new Lexeme(LexemeType.Number, "7"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    },
                    -1.0
                }
            };
        }

        public static IEnumerable<object[]> Calculate_DecimalNumber_Data()
        {
            return new[]
            {
                new object[]
                {
                    "2.894+4.22222*9.23453",
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "2.894"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.Number, "4.22222"),
                        new Lexeme(LexemeType.Multiplication, "*"),
                        new Lexeme(LexemeType.Number, "9.23453"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    },
                    41.884217256599996
                }
            };
        }

        public static IEnumerable<object[]> Calculate_BigDecimalNumber_Data()
        {
            return new[]
            {
                new object[]
                {
                    "44572.22222*9946.23453",
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "44572.22222"),
                        new Lexeme(LexemeType.Multiplication, "*"),
                        new Lexeme(LexemeType.Number, "9946.23453"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    },
                    443325775.72339725
                }
            };
        }

        public static IEnumerable<object[]> Calculate_LargeNumber_Data()
        {
            return new[]
            {
                new object[]
                {
                    "44578432.22222*9768946.23453",
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "44578432.22222"),
                        new Lexeme(LexemeType.Multiplication, "*"),
                        new Lexeme(LexemeType.Number, "9768946.23453"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    },
                    435484307598506.94
                }
            };
        }

        public static IEnumerable<object[]> Calculate_CheckCurrentCultureDecimalSeparator_Data()
        {
            return new[]
            {
                new object[]
                {
                    "3,4+5,9",
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "3,4"),
                        new Lexeme(LexemeType.Plus, "+"),
                        new Lexeme(LexemeType.Number, "5,9"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    },
                    9.3
                }
            };
        }

        public static IEnumerable<object[]> Calculate_DivisionByZero_Data()
        {
            return new[]
            {
                new object[]
                {
                    "5/0",
                    new List<Lexeme>
                    {
                        new Lexeme(LexemeType.Number, "5"),
                        new Lexeme(LexemeType.Division, "/"),
                        new Lexeme(LexemeType.Number, "0"),
                        new Lexeme(LexemeType.EndOfExpression, "")
                    }
                }
            };
        }
    }
}
