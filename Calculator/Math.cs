using Calculator.Models;
using System.Collections.Generic;

namespace Calculator
{
    public class Math
    {
        public double Calculate(List<Lexeme> lexemeExpression)
        {
            //Dictionary<int, string> operatorsPriority = new Dictionary<int, string>()
            //{
            //    {1, "+"},
            //    {2, "-"},
            //    {3, "*"},
            //    {4, "/"}
            //};
            Stack<Lexeme> operands = new Stack<Lexeme>();
            Stack<Lexeme> operators = new Stack<Lexeme>();
            return 0;
        }

        private int GetOperatorPriority(LexemeType lexemeType)
        {
            return 0;
        }
    }
}
