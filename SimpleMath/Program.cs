using System;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a math problem");
            for (string input = Console.ReadLine(); input.ToLower() != "quit"; input = Console.ReadLine())
            {
                try
                {
                    var p = new MathProblem(input);
                    Console.WriteLine(input + " = " + p.Value);
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("Not defined, tried to divide by zero");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Enter another math problem or type quit to quit");
            }
        }
    }
}
