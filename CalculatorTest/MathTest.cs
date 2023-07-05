namespace CalculatorTest
{
    [TestClass]
    public class MathTest
    {
        private readonly Mock<IAnalyzator> _analyzatorMock = new Mock<IAnalyzator>();
        private readonly Mock<ICultureSettings> _cultureSettingsMock = new Mock<ICultureSettings>();
        private readonly CultureInfo Culture = CultureInfo.CurrentCulture;
        private readonly CultureInfo newCulture = new CultureInfo("en-US");

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_SimpleExpression_Data), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_SimpleExpression(string input, List<Lexeme> output, double expected)
        {   
            _analyzatorMock.Setup(c => c.LexicalAnalyze(input)).Returns(output);
            var math = new Calculator.Math(_analyzatorMock.Object, _cultureSettingsMock.Object);
            var result = math.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_ReturnZero_Data), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_ReturnZero(string input, List<Lexeme> output, double expected)
        {
            _analyzatorMock.Setup(c => c.LexicalAnalyze(input)).Returns(output);
            var math = new Calculator.Math(_analyzatorMock.Object, _cultureSettingsMock.Object);
            var result = math.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_ExpressionWithBracketsPriority_Data), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_ExpressionWithBracketsPriority(string input, List<Lexeme> output, double expected)
        {
            _analyzatorMock.Setup(c => c.LexicalAnalyze(input)).Returns(output);
            var math = new Calculator.Math(_analyzatorMock.Object, _cultureSettingsMock.Object);
            var result = math.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_BigDecimalNumber_Data), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_BigDecimalNumber(string input, List<Lexeme> output, double expected)
        {
            try
            {
                CultureInfo.CurrentCulture = newCulture;
                _cultureSettingsMock.SetupGet(x => x.Culture).Returns(newCulture);
                _analyzatorMock.Setup(c => c.LexicalAnalyze(input)).Returns(output);
                var math = new Calculator.Math(_analyzatorMock.Object, _cultureSettingsMock.Object);
                var result = math.Calculate(input);
                Assert.AreEqual(expected, result);
            }
            finally 
            {
                CultureInfo.CurrentCulture = Culture;
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_DecimalNumber_Data), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_DecimalNumber(string input, List<Lexeme> output, double expected)
        {
            try
            {
                CultureInfo.CurrentCulture = newCulture;
                _cultureSettingsMock.SetupGet(x => x.Culture).Returns(newCulture);
                _analyzatorMock.Setup(c => c.LexicalAnalyze(input)).Returns(output);
                var math = new Calculator.Math(_analyzatorMock.Object, _cultureSettingsMock.Object);
                var result = math.Calculate(input);
                Assert.AreEqual(expected, result);
            }
            finally 
            {
                CultureInfo.CurrentCulture = Culture;
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_LargeNumber_Data), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_LargeNumber(string input, List<Lexeme> output, double expected)
        {
            try
            {
                CultureInfo.CurrentCulture = newCulture;
                _cultureSettingsMock.SetupGet(x => x.Culture).Returns(newCulture);
                _analyzatorMock.Setup(c => c.LexicalAnalyze(input)).Returns(output);
                var math = new Calculator.Math(_analyzatorMock.Object, _cultureSettingsMock.Object);
                var result = math.Calculate(input);
                Assert.AreEqual(expected, result);
            }
            finally
            {
                CultureInfo.CurrentCulture = Culture;
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_CheckCurrentCultureDecimalSeparator_Data), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_CheckCurrentCultureDecimalSeparator(string input, List<Lexeme> output, double expected)
        {
            _analyzatorMock.Setup(c => c.LexicalAnalyze(input)).Returns(output);
            var math = new Calculator.Math(_analyzatorMock.Object);
            var result = math.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_DivisionByZero_Data), typeof(MathTestData), DynamicDataSourceType.Method)]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_DivisionByZero(string input, List<Lexeme> output)
        {
            _analyzatorMock.Setup(c => c.LexicalAnalyze(input)).Returns(output);
            var math = new Calculator.Math(_analyzatorMock.Object, _cultureSettingsMock.Object);
            var result = math.Calculate(input);
        }
    }
}