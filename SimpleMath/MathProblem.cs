using System;
using System.Text.RegularExpressions;

public class MathProblem
{
    public MathProblem[] LeftHand { get; set;}

    int value;
    public int Value => value;

    public MathProblem(string problem)
	{
        var split = Regex.Split(problem, @"(?=[-+])"); // Implement my own math library, use regex.
        var numbers = new int[split.Length];
        for (int i = 0; i < split.Length; i++)
        {
            numbers[i] = int.Parse(split[i]);
        }
        value = MyMath.Sum(numbers);
	}
}
