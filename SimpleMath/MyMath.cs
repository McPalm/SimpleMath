using System;

static public class MyMath
{
    /// <summary>
    /// Add an arbitary number of integers together and return their sum
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
	static public int Sum(params int[] numbers)
    {
        int r = 0;
        foreach (var n in numbers)
        {
            r += n;
        }
        return r;
    }

    static public int Subtract(int m, params int[] s)
    {
        return m - Sum(s);
    }

    static public int Multiply(params int[] factors)
    {
        int product = 1;
        foreach (var f in factors)
        {
            product *= f;
        }
        return product;
    }

    static public int Divide(params int[] Numbers)
    {
        int product = Numbers[0];
        for (int i = 1; i < Numbers.Length; i++)
        {
            product /= Numbers[i];
        }
        return product;
    }
}
