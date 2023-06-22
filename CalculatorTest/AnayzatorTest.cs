namespace CalculatorTest
{
    [TestClass]
    public class AnayzatorTest
    {
        [DataTestMethod]
        [DynamicData(nameof(AnalyzatorTestData.LexicalAnalyze_ConvertToListLexeme_SingleDigitsNumbers_Data), typeof(AnalyzatorTestData), DynamicDataSourceType.Method)]
        public void LexicalAnalize_ConvertToListLexeme_SingleDigits(string input, List<Lexeme> expected)
        {
            var analizator = new Analyzator();
            var result = analizator.LexicalAnalyze(input);
            for(int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Type, result[i].Type);
                Assert.AreEqual(expected[i].Value, result[i].Value);
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(AnalyzatorTestData.LexicalAnalyze_ConvertToListLexeme_MultiDigitNumbers_Data), typeof(AnalyzatorTestData), DynamicDataSourceType.Method)]
        public void LexicalAnalize_ConvertToListLexeme_MultiDigitNumbers(string input, List<Lexeme> expected)
        {
            var analizator = new Analyzator();
            var result = analizator.LexicalAnalyze(input);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Type, result[i].Type);
                Assert.AreEqual(expected[i].Value, result[i].Value);
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(AnalyzatorTestData.LexicalAnalyze_ConvertToListLexeme_DecimalNubmers_Data), typeof(AnalyzatorTestData), DynamicDataSourceType.Method)]
        public void LexicalAnalize_ConvertToListLexeme_DecimalNubmers(string input, List<Lexeme> expected)
        {
            var analizator = new Analyzator();
            var result = analizator.LexicalAnalyze(input);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Type, result[i].Type);
                Assert.AreEqual(expected[i].Value, result[i].Value);
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(AnalyzatorTestData.LexicalAnalyze_ConvertToListLexeme_WithSpaces_Data), typeof(AnalyzatorTestData), DynamicDataSourceType.Method)]
        public void LexicalAnalize_ConvertToListLexeme_WithSpaces(string input, List<Lexeme> expected)
        {
            var analizator = new Analyzator();
            var result = analizator.LexicalAnalyze(input);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Type, result[i].Type);
                Assert.AreEqual(expected[i].Value, result[i].Value);
            }
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LexicalAnalize_ThrowArgumentExeption()
        {
            var input = "2+a-1";
            var analizator = new Analyzator();
            var result = analizator.LexicalAnalyze(input);
        }
    }
}
