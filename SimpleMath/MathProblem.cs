using System;
using System.Text.RegularExpressions;

public class MathProblem
{
    public int Value { get; }

    public MathProblem(string problem)
	{
        var split = Regex.Split(problem, @"(?=[-+])"); // Implement my own math library, use regex.
        var numbers = new int[split.Length];
        for (int i = 0; i < split.Length; i++)
        {
            if (int.TryParse(split[i], out int n))
                numbers[i] = n;
            else
                numbers[i] = SolveMultiplication(split[i]);
        }
        Value = MyMath.Sum(numbers);
	}

    int SolveMultiplication(string problem)
    {
        return Solve(problem, '*', MyMath.Multiply, (s) => 1);
    }
    
    int Solve(string problem, char symbol, System.Func<int[], int> operation, Func<string, int> fallback)
    {
        var split = problem.Split(symbol);
        var numbers = new int[split.Length];
        for (int i = 0; i < split.Length; i++)
        {
            if (int.TryParse(split[i], out int n))
                numbers[i] = n;
            else
                numbers[i] = fallback(split[i]);
        }
        return operation(numbers);
    }
}
