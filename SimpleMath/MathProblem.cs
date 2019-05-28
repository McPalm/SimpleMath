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
        var split = problem.Split('*');
        var factors = new int[split.Length];
        for (int i = 0; i < split.Length; i++)
        {
            if (int.TryParse(split[i], out int n))
                factors[i] = n;
            else
                factors[i] = 1;
        }
        return MyMath.Multiply(factors);
    }
}
