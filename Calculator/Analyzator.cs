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
                        continue;
                    case '-':
                        lexemeExpression.Add(new Lexeme(LexemeType.Minus, Char.ToString(token)));
                        position++;
                        continue;
                    case '/':
                        lexemeExpression.Add(new Lexeme(LexemeType.Division, Char.ToString(token)));
                        position++;
                        continue;
                    case '*':
                        lexemeExpression.Add(new Lexeme(LexemeType.Multiplication, Char.ToString(token)));
                        position++;
                        continue;
                    case '(':
                        lexemeExpression.Add(new Lexeme(LexemeType.LeftBracket, Char.ToString(token)));
                        position++;
                        continue;
                    case ')':
                        lexemeExpression.Add(new Lexeme(LexemeType.RightBracket, Char.ToString(token)));
                        position++;
                        continue;
                    case ' ':
                        position++;
                        continue;
                    default:
                        if (Char.IsNumber(token))
                        {
                            string number = NumberHandler(ref position, expression);
                            lexemeExpression.Add(new Lexeme(LexemeType.Number, number));
                            continue;
                        }
                        throw new ArgumentException("Invalid character input");
                }
            }
            CheckBalancedBrackets(lexemeExpression);
            return lexemeExpression;
        }

        private string NumberHandler(ref int position, string expression)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //char token = expression[position];
            //do
            //{
            //    stringBuilder.Append(token);
            //    position++;
            //    if (position >= expression.Length)
            //    {
            //        break;
            //    }
            //    token = expression[position];
            //}
            //while (Char.IsNumber(token) || token == _decimalSeparator);
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
