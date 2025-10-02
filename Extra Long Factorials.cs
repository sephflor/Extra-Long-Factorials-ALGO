using System;
using System.Numerics;

class Result
{
    public static void extraLongFactorials(int n)
    {
        
        BigInteger factorial = 1;
        
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        
        Console.WriteLine(factorial);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Result.extraLongFactorials(n);
    }
}
