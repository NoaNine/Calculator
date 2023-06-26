using Calculator.Models;
using System.Collections.Generic;

namespace Calculator
{
    public class Math
    {
        public double Calculate(List<Lexeme> lexemeExpression)
        {
            Dictionary<LexemeType, int> operatorsPriority = new Dictionary<LexemeType, int>()
            {
                {LexemeType.Number, 0},
                {LexemeType.Plus, 1},
                {LexemeType.Minus, 1},
                {LexemeType.Multiplication, 2},
                {LexemeType.Division, 2},
                {LexemeType.LeftBracket, 3},
                {LexemeType.RightBracket, 3}
            };
            Stack<Lexeme> operands = new Stack<Lexeme>();
            Stack<Lexeme> operators = new Stack<Lexeme>();
            return 0;
        }
    }
}
