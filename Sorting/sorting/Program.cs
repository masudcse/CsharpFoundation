public class Solution
{
    //Sorting accedinign order 
    public void AccesingOrder(int[] input)
    {
        //5
        bool swapped;
        for (int i = 0; i < input.Length - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < input.Length - i - 1; j++)
            {
                if (input[j] > input[j + 1])
                {
                    int temp = input[j];
                    input[j] = input[j + 1];
                    input[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }

    }
}



public class Program
{
    static void Main(string[] args)
    {
        int[] input = { 5, 1, 4, 2, 8 };
        Solution solution = new Solution();
        solution.AccesingOrder(input);
        Console.WriteLine("Sorted"+string.Join(",",input));
    }
}
