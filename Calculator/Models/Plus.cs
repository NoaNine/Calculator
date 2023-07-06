using Calculator.Interface;

namespace Calculator.Models
{
    public class Plus : IOperator
    {
        public double Operation(double a, double b)
        {
            return a + b;
        }
    }
}
