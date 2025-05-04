
public class Solution
{
    public void FindMiniMaxArray(int[] input)
    {
        int min = input[0];
        int max = input[0];
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] < min)
            {
                min = input[i];
            }
            if (input[i] > max)
            {
                max = input[i];
            }
        }
        Console.WriteLine($"Min{min}-Max{max}");
    }

    //Check if an Array is Sorted in Ascending Order
    public void FindSortedArray(int[] input)
    {
        for (int i = 0;i < input.Length-1;i++)
        {
            if (input[i] > input[i + 1])
            {
                Console.WriteLine("False");
                return;
            }
        }
        Console.WriteLine("true");
    }
    public void FindSecondLargest(int[] input)
    {
        int firstLargest = input[0];
        int secondLargest= input[0];
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] > firstLargest)
            {
                secondLargest=firstLargest;
                firstLargest=input[i];
            }
            else if(input[i] > secondLargest && input[i]!=firstLargest)
            {
                secondLargest = input[i];
            }
          
        }
        Console.WriteLine(secondLargest);

    }
    //public void MovedAllZerosToEnd(int[] input)
    //{
    //    int pos = 0;
    //    for (int i = 0; i < input.Length; i++)
    //    {
    //        if (input[i] != 0)
    //        {
    //            input[pos] = input[i];
    //            pos++;
    //        }

    //    }

    //    for (int i = pos;i < input.Length; i++)
    //    {

    //        input[i] = 0;
    //    }
    //    foreach(int i in input)
    //    {
    //         Console.Write(i + " ");
    //    }

    //}
    public void MovedAllZerosToEnd(int[] nums)
    {
        if (nums == null || nums.Length <= 1)
            return;

        int nonZeroPos = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                // Only swap if positions are different to avoid unnecessary operations
                if (i != nonZeroPos)
                {
                    // Swap elements
                    int temp = nums[nonZeroPos];
                    nums[nonZeroPos] = nums[i];
                    nums[i] = temp;
                }
                nonZeroPos++;
            }
        }

        // Print the result if needed
        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
    }
    //Find duplicate value in Array
    //public void FindDuplicateValue(int[]input)
    //{
    //    for(int i=0;i<input.Length; i++)
    //    {
    //        int count = 0;
    //        for (int j = 0; j < input.Length; j++)
    //        {
    //            if (input[i] == input[j])
    //            {
    //                count++;
    //            }
    //        }
    //        if (count > 1)
    //        {
    //            Console.WriteLine($"Duplciate No:{input[i]}");
    //        }
    //    }
    //}
    public void FindDuplicateValue(int[] input)
    {
        int slow = input[0];
        int fast = input[0];
        while (true)
        {
            slow = input[slow];
            fast = input[input[fast]];
            if (slow == fast)
                break;
        }
        slow = input[0];
        while (slow != fast)
        {
            slow = input[slow];
            fast = input[fast];
        }
        Console.WriteLine(slow);
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] input = { 3, 1, 1, 4, 2 };
        Solution solution = new Solution();
        solution.FindDuplicateValue(input);
    }
}