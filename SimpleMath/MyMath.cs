using System;

static public class MyMath
{
    /// <summary>
    /// Add an arbitary number of integers together and return their sum
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
	static public double Sum(params double[] numbers)
    {
        double r = 0;
        foreach (var n in numbers)
        {
            r += n;
        }
        return r;
    }

    static public double Subtract(double m, params double[] s)
    {
        return m - Sum(s);
    }

    static public double Multiply(params double[] factors)
    {
        double product = 1;
        foreach (var f in factors)
        {
            product *= f;
        }
        return product;
    }

    static public double Divide(params double[] Numbers)
    {
        double product = Numbers[0];
        for (int i = 1; i < Numbers.Length; i++)
        {
            if (Numbers[i] == 0)
                throw new DivideByZeroException();
            product /= Numbers[i];
        }
        return product;
    }
}
