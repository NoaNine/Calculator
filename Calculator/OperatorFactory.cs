using Calculator.Interface;
using Calculator.Models;
using System;

namespace Calculator
{
    public class OperatorFactory : IOperatorFactory
    {
        public IOperator CreateOperator(OperatorType operatorType)
        {
            switch (operatorType)
            {
                case OperatorType.Plus:
                    return new Plus();
                case OperatorType.Minus:
                    return new Minus();
                case OperatorType.Division:
                    return new Division();
                case OperatorType.Multiplication:
                    return new Multiplication();
                default:
                    throw new Exception();
            }
        }
    }
}
