using Calculator.Interface;

namespace Calculator.Models
{
    public class Division : IOperator
    {
        public double Operation(double a, double b)
        {
            return a / b;
        }
    }
}
