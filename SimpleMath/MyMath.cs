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
}
