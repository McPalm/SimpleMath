using System;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                var p = new MathProblem("10/5+2");
                Console.WriteLine(p.Value + " wants 4");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
