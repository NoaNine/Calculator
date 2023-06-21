using System.Collections.Generic;
using System.Globalization;
using Calculator.Models;

namespace Calculator
{
    public class Analizator
    {
        private NumberFormatInfo _numberFormatInfo;

        public Analizator(NumberFormatInfo numberFormatInfo)
        {
            _numberFormatInfo = numberFormatInfo;
        }

        public List<Lexeme> LexicalAnalize(string expression)
        {
            List<Lexeme> lexemeExpression = new List<Lexeme>();
            return lexemeExpression;
        }
    }
}
