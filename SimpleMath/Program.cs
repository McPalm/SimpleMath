using System;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new MathProblem("1*2*3+1");
            Console.WriteLine(p.Value + " wants 7");
        }
    }
}
