using Calculator.Interface;
using Calculator.Models;

namespace Calculator
{
    public interface IOperatorFactory
    {
        IOperator CreateOperator(OperatorType operatorType);
    }
}