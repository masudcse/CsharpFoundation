
//class PrintSulution
//{
//   public void Display()
//    {
//        for(int i = 1; i <= 100; i++)
//        {
//            bool isMatched = false;
//            bool isDiviedbyThreeFive=false;
//            if (i % 3 == 0 && i % 5 == 0)
//            {
//                Console.WriteLine("Confused");
//                isMatched = true;
//                isDiviedbyThreeFive = true;
//            }
//            if (i%3==0)
//            {
//                if (!isDiviedbyThreeFive)
//                {
//                    Console.WriteLine("Happy");
//                }
//                isMatched = true;

//            }
//            if(i%5==0)
//            {
//                if (!isDiviedbyThreeFive)
//                {
//                    Console.WriteLine("Sad");
//                }
//                isMatched = true;

//            }

//            if (!isMatched)
//            {
//                Console.WriteLine(i);
//            }

//        }
//    }
//}


class program
{
    static void Main(string[] args)
    {
        //PrintSulution sulution = new PrintSulution();
        // sulution.Display();
        int[] input = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 6, 7, 8 };
        SolutinDuplicate slnDuplicate = new SolutinDuplicate();
        slnDuplicate.FindDuplicateNumber(input);
        // string input= Console.ReadLine();
        //  string input = "abcdd";
        // Solution solution = new Solution();
        // solution.FindTheLongestSubstring(input);
    }
}

class SolutinDuplicate
{
    public void FindDuplicateNumber(int[] input)
    {
        int dupliate = 0;
        // bool isDupliate=false;
        for (int i = 0; i < input.Length; i++)
        {
            dupliate = 0;
            for (int j = i + 1; j < input.Length - i; j++)
            {
                if (input[i] == input[j])
                {
                    dupliate++;

                }
            }
            if (dupliate > 0)
            {
                Console.WriteLine($"duplicate No:{input[i]},repeat {dupliate} times");
            }
        }

    }
}

class Solution
{
    public void FindTheLongestSubstring(string input)
    {
        bool isDuplicate = false;
        if (string.IsNullOrEmpty(input))
            Console.WriteLine("");
        if (input.Length > 15)
            Console.WriteLine("invalid more than 15 char");
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 1; j < input.Length; j++)
            {
                //check Case

                if (input[i] == input[j])
                {
                    isDuplicate = true;
                }
            }
        }
    }
}