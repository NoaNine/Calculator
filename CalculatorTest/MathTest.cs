namespace CalculatorTest
{
    [TestClass]
    public class MathTest
    {
        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_SimpleExpression), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_SimpleExpression(List<Lexeme> input, double expected)
        {
            Calculator.Math math = new Calculator.Math();
            var result = math.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_ReturnZero), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_ReturnZero(List<Lexeme> input, double expected)
        {
            Calculator.Math math = new Calculator.Math();
            var result = math.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_ExpressionWithBracketsPriority), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_ExpressionWithBracketsPriority(List<Lexeme> input, double expected)
        {
            Calculator.Math math = new Calculator.Math();
            var result = math.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_BigDecimalNumber), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_BigDecimalNumber(List<Lexeme> input, double expected)
        {
            Calculator.Math math = new Calculator.Math();
            var result = math.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_DecimalNumber), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_DecimalNumber(List<Lexeme> input, double expected)
        {
            Calculator.Math math = new Calculator.Math();
            var result = math.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_LargeNumber), typeof(MathTestData), DynamicDataSourceType.Method)]
        public void Calculate_LargeNumber(List<Lexeme> input, double expected)
        {
            Calculator.Math math = new Calculator.Math();
            var result = math.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DynamicData(nameof(MathTestData.Calculate_DivisionByZero), typeof(MathTestData), DynamicDataSourceType.Method)]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_DivisionByZero(List<Lexeme> input)
        {
            Calculator.Math math = new Calculator.Math();
            var result = math.Calculate(input);
        }
    }
}