public class Solution
{
    // int[] fibonacciArray = new int[n + 1];
    public int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        
        int fibonacciSum = 0, x = 0, y = 1;
        for (int i = 2; i <= n; i++)
        {
            fibonacciSum = x + y;
            x = y;
            y = fibonacciSum;
        }

        return fibonacciSum;
    }
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.Fibonacci(4));
    }
}