using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class MathProblem
{
    public int Value { get; }

    public MathProblem(string problem)
	{
        // remove all white space
        problem = Regex.Replace(problem, @"\s+", "");
        // replace - with +-
        problem = Regex.Replace(problem, @"(?<v>[0-9])[-]", @"${v}+-");
        // split all + values
        Value = SolveAddition(problem);
	}

    int SolveAddition(string problem) => Solve(problem, '+', MyMath.Sum, SolveMultiplication);

    int SolveMultiplication(string problem)
    {
        return Solve(problem, '*', MyMath.Multiply, SolveDivision);
    }

    int SolveDivision(string problem) => Solve(problem, '/', MyMath.Divide, (s) => throw new Exception($"Unable to solve \"{s}\""));
    
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
