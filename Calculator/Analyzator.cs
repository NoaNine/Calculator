using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Models;

namespace Calculator
{
    public class Analyzator : IAnalyzator
    {
        private char _decimalSeparator;

        public Analyzator(char decimalSeparator)
        {
            _decimalSeparator = decimalSeparator;
        }

        public List<Lexeme> LexicalAnalyze(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                throw new ArgumentNullException("The value can`t be null or empty");
            }
            List<Lexeme> lexemeExpression = new List<Lexeme>();
            int position = 0;
            while (position < expression.Length)
            {
                char token = expression[position];
                switch (token)
                {
                    case '+':
                        lexemeExpression.Add(new Lexeme(LexemeType.Plus, Char.ToString(token)));
                        position++;
                        break;
                    case '-':
                        lexemeExpression.Add(new Lexeme(LexemeType.Minus, Char.ToString(token)));
                        position++;
                        break;
                    case '/':
                        lexemeExpression.Add(new Lexeme(LexemeType.Division, Char.ToString(token)));
                        position++;
                        break;
                    case '*':
                        lexemeExpression.Add(new Lexeme(LexemeType.Multiplication, Char.ToString(token)));
                        position++;
                        break;
                    case '(':
                        lexemeExpression.Add(new Lexeme(LexemeType.LeftBracket, Char.ToString(token)));
                        position++;
                        break;
                    case ')':
                        lexemeExpression.Add(new Lexeme(LexemeType.RightBracket, Char.ToString(token)));
                        position++;
                        break;
                    case ' ':
                        position++;
                        break;
                    default:
                        if (Char.IsNumber(token))
                        {
                            string number = NumberHandler(ref position, expression);
                            lexemeExpression.Add(new Lexeme(LexemeType.Number, number));
                            break;
                        }
                        throw new ArgumentException("Invalid character input");
                }
                if (position == expression.Length)
                {
                    lexemeExpression.Add(new Lexeme(LexemeType.EndOfExpression, ""));
                }
            }
            CheckBalancedBrackets(lexemeExpression);
            return lexemeExpression;
        }

        private string NumberHandler(ref int position, string expression)
        {
            StringBuilder stringBuilder = new StringBuilder();
            while(IsNumber(position, expression))
            {
                char token = expression[position];
                stringBuilder.Append(token);
                position++;
            }
            return stringBuilder.ToString();
        }

        private bool IsNumber(int position, string expression) =>
            position < expression.Length && (Char.IsNumber(expression[position]) || (expression[position] == _decimalSeparator));

        private void CheckBalancedBrackets(List<Lexeme> lexemes)
        {
            int balancedBrackets = 0;
            foreach (Lexeme lexeme in lexemes)
            {
                if (lexeme.Type == LexemeType.LeftBracket)
                {
                    balancedBrackets++;
                }
                if (lexeme.Type == LexemeType.RightBracket)
                {
                    balancedBrackets--;
                }
            }
            if (balancedBrackets != 0)
            {
                throw new ArgumentException("Not balanced brackets");
            }
        }
    }
}
