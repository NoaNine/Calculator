using Calculator.Models;
using System.Collections.Generic;

namespace Calculator
{
    public class Math
    {
        public double Calculate(List<Lexeme> lexemeExpression)
        {
            Dictionary<int, string> operatorsPriority = new Dictionary<int, string>()
            {
                {1, "+"},
                {1, "-"},
                {2, "*"},
                {2, "/"}
            };
            Stack<Lexeme> operands = new Stack<Lexeme>();
            Stack<Lexeme> operators = new Stack<Lexeme>();
            return 0;
        }
    }
}
