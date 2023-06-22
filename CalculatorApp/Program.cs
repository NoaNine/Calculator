using System;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string expression1 = "2+4-4-9-5+3+4"; // -5
            string expression8 = "2-8"; // -6
            string expression7 = "2/0"; // throw exp
            string expression6 = "  2  +4- 4-  9-5+3     +4    "; //-5
            string expression10 = "2+(3-1)"; // 4
            string expression9 = "2+(3-1)*9"; // 20
            string expression2 = "(2*9*9)+4*(5*8-(3+2/(5*9)))+(3-6)-1/5"; //100.8
            string expression5 = "(2+4*(5*8)+(3-6)-1/5)/0"; // throw exp
            string expression4 = "2.9+4*(5*8.8)+(3.3-6)-1.9*5"; // 166.7
            string expression3 = "2302+43*(5*8)+(3-6)-12*522-139*2"; // -2523
        }
    }
}
