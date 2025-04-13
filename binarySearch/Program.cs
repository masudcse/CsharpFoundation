
// class BinarySearch
//{
//    static int GetTargetValue(int[] binaryValue, int target)
//    {
//        int left = 0;
//        int right = binaryValue.Length - 1;
//        while (left <= right)
//        {
//            int mid = left + (right - left) / 2;
//            if (binaryValue[mid] == target)
//                return mid;
//            if (binaryValue[mid] < target)
//                left = mid + 1;
//            else
//                right = mid - 1;
//        }
//        return -1;
//    }
//    static void Main()
//    {
//        int[] numbers = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
//        int target = 72;

//        int result = GetTargetValue(numbers, target);

//        if (result == -1)
//            Console.WriteLine("Element not present in array");
//        else
//            Console.WriteLine($"Element found at index {result}");
//    }
//}

//class BinarySear
//{
//    static int GetBinaryValue(int[] arraylist, int targetNumber)
//    {
//        int left = 0;
//        int right = arraylist.Length - 1;
//        while (left < right) 
//        {
//            int mid=left+(right-left)/2;
//            if (arraylist[mid] == targetNumber)
//                return mid;
//            if (arraylist[mid] < targetNumber)
//                left = mid + 1;
//            else
//                right = mid - 1;
//        }

//        return -1;
//    }
//    static void Main()
//    {
//        int[] numbers = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
//        int target = 56;
//        int result=GetBinaryValue(numbers, target);
//        Console.WriteLine(result);
//    }
//}

class fabonacci
{
    static List<int> GetFabbonacci(int lenght)
    {
        List<int> list = new List<int>();
        if (lenght >= 1)
            list.Add(0);
        if(lenght >= 2)
            list.Add(1);
        for (int i = 2; i < lenght; i++)
        {
            // f(n) = f(n-1) + f(n-2)
            int nextValue = list[i-1]+list[i-2];
            list.Add(nextValue);
        }
        return list;
    }
    static void Main()
    {
        List<int> sequence = GetFabbonacci(9);
        Console.WriteLine("Sequence 9: " + string.Join(" ",sequence));

        List<int> sequence2 = GetFabbonacci(20);
        Console.WriteLine("Sequence 20: " + string.Join(" ", sequence2));
    }
}