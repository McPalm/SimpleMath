using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class MathProblem
{
    public double Value { get; }

    public MathProblem(string problem)
	{
        // remove all white space
        problem = Regex.Replace(problem, @"\s+", "");
        // replace - with +-
        problem = Regex.Replace(problem, @"(?<v>[0-9])[-]", @"${v}+-");
        // split all + values
        Value = SolveAddition(problem);
	}

    double SolveAddition(string problem) => Solve(problem, '+', MyMath.Sum, SolveMultiplication);

    double SolveMultiplication(string problem)
    {
        return Solve(problem, '*', MyMath.Multiply, SolveDivision);
    }

    double SolveDivision(string problem) => Solve(problem, '/', MyMath.Divide, Constants);

    double Constants(string s)
    {
        switch(s.ToLower())
        {
            case "pi":
            case "π":
                return Math.PI;
            case "e":
                return Math.E;
            case "tau":
                return Math.PI * 2;
            case "root2":
                return 1.41421356237;
        }
        throw new Exception($"Unable to solve \"{s}\"");
    }

    double Solve(string problem, char symbol, System.Func<double[], double> operation, Func<string, double> fallback)
    {
        var split = problem.Split(symbol);
        var numbers = new double[split.Length];
        for (int i = 0; i < split.Length; i++)
        {
            if (double.TryParse(split[i], out double n))
                numbers[i] = n;
            else
                numbers[i] = fallback(split[i]);
        }
        return operation(numbers);
    }
}
