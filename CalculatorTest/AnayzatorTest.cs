namespace CalculatorTest
{
    [TestClass]
    public class AnayzatorTest
    {
        private readonly Mock<ICultureSettings> _cultureSettingsMock = new Mock<ICultureSettings>();
        private readonly CultureInfo cultureInfo = new CultureInfo("en-US");

        [DataTestMethod]
        [DynamicData(nameof(AnalyzatorTestData.LexicalAnalyze_ConvertToListLexeme_SingleDigitsNumbers_Data), typeof(AnalyzatorTestData), DynamicDataSourceType.Method)]
        public void LexicalAnalize_ConvertToListLexeme_SingleDigitsNumbers(string input, List<Lexeme> expected)
        {
            _cultureSettingsMock.SetupGet(x => x.Culture).Returns(cultureInfo);
            _cultureSettingsMock.SetupGet(x => x.GetDecimalSeparator).Returns('.');
            var analizator = new Analyzator(_cultureSettingsMock.Object);
            var result = analizator.LexicalAnalyze(input);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Type, result[i].Type);
                Assert.AreEqual(expected[i].Value, result[i].Value);
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(AnalyzatorTestData.LexicalAnalyze_ConvertToListLexeme_MultiDigitNumbers_Data), typeof(AnalyzatorTestData), DynamicDataSourceType.Method)]
        public void LexicalAnalize_ConvertToListLexeme_MultiDigitNumbers(string input, List<Lexeme> expected)
        {
            _cultureSettingsMock.SetupGet(x => x.Culture).Returns(cultureInfo);
            _cultureSettingsMock.SetupGet(x => x.GetDecimalSeparator).Returns('.');
            var analizator = new Analyzator(_cultureSettingsMock.Object);
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
            _cultureSettingsMock.SetupGet(x => x.Culture).Returns(cultureInfo);
            _cultureSettingsMock.SetupGet(x => x.GetDecimalSeparator).Returns('.');
            var analizator = new Analyzator(_cultureSettingsMock.Object);
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
            _cultureSettingsMock.SetupGet(x => x.Culture).Returns(cultureInfo);
            _cultureSettingsMock.SetupGet(x => x.GetDecimalSeparator).Returns('.');
            var analizator = new Analyzator(_cultureSettingsMock.Object);
            var result = analizator.LexicalAnalyze(input);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Type, result[i].Type);
                Assert.AreEqual(expected[i].Value, result[i].Value);
            }
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LexicalAnalize_NotValidValue()
        {
            var input = "2+a-1";
            _cultureSettingsMock.SetupGet(x => x.Culture).Returns(cultureInfo);
            _cultureSettingsMock.SetupGet(x => x.GetDecimalSeparator).Returns('.');
            var analizator = new Analyzator(_cultureSettingsMock.Object);
            var result = analizator.LexicalAnalyze(input);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LexicalAnalize_NotBalancedBrackets()
        {
            var input = "2+((4-1)";
            _cultureSettingsMock.SetupGet(x => x.Culture).Returns(cultureInfo);
            _cultureSettingsMock.SetupGet(x => x.GetDecimalSeparator).Returns('.');
            var analizator = new Analyzator(_cultureSettingsMock.Object);
            var result = analizator.LexicalAnalyze(input);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LexicalAnalize_IsNullValue()
        {
            string? input = null;
            _cultureSettingsMock.SetupGet(x => x.Culture).Returns(cultureInfo);
            _cultureSettingsMock.SetupGet(x => x.GetDecimalSeparator).Returns('.');
            var analizator = new Analyzator(_cultureSettingsMock.Object);
            var result = analizator.LexicalAnalyze(input);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LexicalAnalize_IsEmptyValue()
        {
            var input = "";
            _cultureSettingsMock.SetupGet(x => x.Culture).Returns(cultureInfo);
            _cultureSettingsMock.SetupGet(x => x.GetDecimalSeparator).Returns('.');
            var analizator = new Analyzator(_cultureSettingsMock.Object);
            var result = analizator.LexicalAnalyze(input);
        }
    }
}
