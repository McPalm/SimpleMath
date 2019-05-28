using System;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new MathProblem("1+3+5-3+5-5");
            Console.WriteLine(p.Value + " wants 6");
        }
    }
}
