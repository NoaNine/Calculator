using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Calculator
{
    public class Math
    {
        private Dictionary<LexemeType, int> _operatorsPriority = new Dictionary<LexemeType, int>()
            {
                {LexemeType.Plus, 1},
                {LexemeType.Minus, 1},
                {LexemeType.Multiplication, 2},
                {LexemeType.Division, 2}
            };
        private Stack<Lexeme> _operands = new Stack<Lexeme>();
        private Stack<Lexeme> _operators = new Stack<Lexeme>();
        private IAnalyzator _analyzator;
        private ICultureSettings _cultureSettings;

        public Math() 
        {

        }

        public Math(IAnalyzator analyzator, ICultureSettings cultureSettings)
        {
            _analyzator = analyzator;
            _cultureSettings = cultureSettings;
        }

        public double Calculate(List<Lexeme> lexemeExpression)
        {
            if (lexemeExpression.Count == 2)
            {
                return double.TryParse(lexemeExpression[0].Value, NumberStyles.Number, _cultureSettings.Culture, out double value) ? value : throw new ArgumentException("This is not operand.");
            }
            foreach (Lexeme lexeme in lexemeExpression)
            {
                if (IsNumber(lexeme))
                {
                    _operands.Push(lexeme);
                    continue;
                }
                OperatorHandler(lexeme);
            }
            if (_operands.Count > 1)
            {
                throw new ArgumentException("Not last operand.");
            }
            return double.TryParse(_operands.Pop().Value, NumberStyles.Number, _cultureSettings.Culture, out double result) ? result : throw new ArgumentException();
        }

        private void OperatorHandler(Lexeme lexeme)
        {
            if(_operators.Count != 0 && IsRigthAndLeftBracket(lexeme, _operators.Peek()))
            {
                _operators.Pop();
                return;
            }
            if (!IsEndOfExpression(lexeme) && (_operators.Count == 0 || IsLeftBracketOrHigerPriority(lexeme, _operators.Peek())))
            {
                _operators.Push(lexeme);
                return;
            }
            if (IsEndOfExpression(lexeme) || IsRightBracketOrSameOrLowerPriority(lexeme, _operators.Peek()))
            {
                Operation();
                OperatorHandler(lexeme);
            }
        }

        private bool IsNumber(Lexeme lexeme) => lexeme.Type == LexemeType.Number;

        private bool IsEndOfExpression(Lexeme lexeme) => lexeme.Type == LexemeType.EndOfExpression && _operators.Count != 0;
        private bool IsRigthAndLeftBracket(Lexeme lexeme, Lexeme firstOperatorInStack) => 
            lexeme.Type == LexemeType.RightBracket && firstOperatorInStack.Type == LexemeType.LeftBracket;

        private bool IsLeftBracketOrHigerPriority(Lexeme lexeme, Lexeme firstOperatorInStack)
        {
            if (lexeme.Type == LexemeType.LeftBracket || firstOperatorInStack.Type == LexemeType.LeftBracket)
            {
                return true;
            }
            if ((!_operatorsPriority.TryGetValue(lexeme.Type, out int lexemePriority) | 
                !_operatorsPriority.TryGetValue(firstOperatorInStack.Type, out int firstOperatorInStackPriority)) && 
                lexeme.Type != LexemeType.RightBracket)
            {
                throw new ArgumentException("Key is not found.");
            }
            return lexemePriority > firstOperatorInStackPriority ? true : false;
        }

        private bool IsRightBracketOrSameOrLowerPriority(Lexeme lexeme, Lexeme firstOperatorInStack)
        {
            if (lexeme.Type == LexemeType.RightBracket)
            {
                return true;
            }
            if ((!_operatorsPriority.TryGetValue(lexeme.Type, out int lexemePriority) | 
                !_operatorsPriority.TryGetValue(firstOperatorInStack.Type, out int firstOperatorInStackPriority)) && 
                lexeme.Type != LexemeType.LeftBracket)
            {
                throw new ArgumentException("Key is not found.");
            }
            return lexemePriority <= firstOperatorInStackPriority ? true : false;
        }

        private void Operation()
        { 
            switch (_operators.Pop().Type)
            {
                case LexemeType.Minus:
                    Minus();
                    break;
                case LexemeType.Plus:
                    Plus();
                    break;
                case LexemeType.Division:
                    Division();
                    break;
                case LexemeType.Multiplication:
                    Multiplication();
                    break;
                default:
                    throw new ArgumentException("Not found operation.");
            }
        }

        private void Minus()
        {
            Lexeme operand1 = _operands.Pop();
            Lexeme operand2 = _operands.Pop();
            if (!double.TryParse(operand2.Value, NumberStyles.Number, _cultureSettings.Culture, out double op2) | 
                !double.TryParse(operand1.Value, NumberStyles.Number, _cultureSettings.Culture, out double op1))
            {
                throw new ArgumentException("Not decimal number");
            }
            double result = op2 - op1;
            _operands.Push(new Lexeme(LexemeType.Number, result.ToString()));
        }

        private void Plus()
        {
            Lexeme operand1 = _operands.Pop();
            Lexeme operand2 = _operands.Pop();
            if (!double.TryParse(operand2.Value, NumberStyles.Number, _cultureSettings.Culture, out double op2) | 
                !double.TryParse(operand1.Value, NumberStyles.Number, _cultureSettings.Culture, out double op1))
            {
                throw new ArgumentException("Not decimal number");
            }
            double result = op2 + op1;
            _operands.Push(new Lexeme(LexemeType.Number, result.ToString()));
        }

        private void Division()
        {
            Lexeme operand1 = _operands.Pop();
            Lexeme operand2 = _operands.Pop();
            if (!double.TryParse(operand2.Value, NumberStyles.Number, _cultureSettings.Culture, out double op2) | 
                !double.TryParse(operand1.Value, NumberStyles.Number, _cultureSettings.Culture, out double op1))
            {
                throw new ArgumentException("Not decimal number");
            }
            if (op2 == 0 || op1 == 0)
            {
                throw new ArgumentException("Divide by zero.");
            }
            double result = op2 / op1;
            _operands.Push(new Lexeme(LexemeType.Number, result.ToString()));
        }

        private void Multiplication()
        {
            Lexeme operand1 = _operands.Pop();
            Lexeme operand2 = _operands.Pop();
            if (!double.TryParse(operand2.Value, NumberStyles.Number, _cultureSettings.Culture, out double op2) 
                | !double.TryParse(operand1.Value, NumberStyles.Number, _cultureSettings.Culture, out double op1))
            {
                throw new ArgumentException("Not decimal number");
            }
            double result = op2 * op1;
            _operands.Push(new Lexeme(LexemeType.Number, result.ToString()));
        }
    }
}
