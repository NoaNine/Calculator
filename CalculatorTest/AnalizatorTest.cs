namespace CalculatorTest
{
    [TestClass]
    public class AnalizatorTest
    {
        [DataTestMethod]
        [DynamicData(nameof(AnalizatorTestData.LexicalAnalize_ConvertToListLexeme_SingleDigitsNumbers_Data), typeof(AnalizatorTestData), DynamicDataSourceType.Method)]
        public void LexicalAnalize_ConvertToListLexeme_SingleDigits(string input, List<Lexeme> expected)
        {
            var analizator = new Analizator();
            var result = analizator.LexicalAnalize(input);
            for(int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Type, result[i].Type);
                Assert.AreEqual(expected[i].Value, result[i].Value);
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(AnalizatorTestData.LexicalAnalize_ConvertToListLexeme_MultiDigitNumbers_Data), typeof(AnalizatorTestData), DynamicDataSourceType.Method)]
        public void LexicalAnalize_ConvertToListLexeme_MultiDigitNumbers(string input, List<Lexeme> expected)
        {
            var analizator = new Analizator();
            var result = analizator.LexicalAnalize(input);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Type, result[i].Type);
                Assert.AreEqual(expected[i].Value, result[i].Value);
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(AnalizatorTestData.LexicalAnalize_ConvertToListLexeme_DecimalNubmers_Data), typeof(AnalizatorTestData), DynamicDataSourceType.Method)]
        public void LexicalAnalize_ConvertToListLexeme_DecimalNubmers(string input, List<Lexeme> expected)
        {
            var analizator = new Analizator();
            var result = analizator.LexicalAnalize(input);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Type, result[i].Type);
                Assert.AreEqual(expected[i].Value, result[i].Value);
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(AnalizatorTestData.LexicalAnalize_ConvertToListLexeme_WithSpaces_Data), typeof(AnalizatorTestData), DynamicDataSourceType.Method)]
        public void LexicalAnalize_ConvertToListLexeme_WithSpaces(string input, List<Lexeme> expected)
        {
            var analizator = new Analizator();
            var result = analizator.LexicalAnalize(input);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Type, result[i].Type);
                Assert.AreEqual(expected[i].Value, result[i].Value);
            }
        }
    }
}
