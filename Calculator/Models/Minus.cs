using Calculator.Interface;

namespace Calculator.Models
{
    public class Minus : IOperator
    {
        public double Operation(double a, double b)
        {
            return a - b;
        }
    }
}
