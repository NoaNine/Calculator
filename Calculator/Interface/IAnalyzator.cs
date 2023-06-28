using Calculator.Models;
using System.Collections.Generic;

namespace Calculator
{
    public interface IAnalyzator
    {
        List<Lexeme> LexicalAnalyze(string expression);
    }
}