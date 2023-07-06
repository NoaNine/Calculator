using Calculator.Interface;

namespace Calculator.Models
{
    public class Multiplication : IOperator
    {
        public double Operation(double a, double b)
        {
            return a * b;
        }
    }
}
