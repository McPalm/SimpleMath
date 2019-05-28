using System;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            var five = MyMath.Sum(2, 2, 1);
            Console.WriteLine($"{five} is five");
            var two = MyMath.Sum(1, 1);
            Console.WriteLine($"{two} is two");
        }
    }
}
