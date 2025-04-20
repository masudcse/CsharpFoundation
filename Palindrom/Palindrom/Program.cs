
public class Palindrom
{
    public bool isPalindrom(string s)
    {
        if (string.IsNullOrEmpty(s))
            return true;
        string sCleanInput = new string(s
            .ToLower()
            .Where(char.IsLetterOrDigit)
            .ToArray()
            );
        int left = 0;
        int right = sCleanInput.Length - 1;
        while (left < right)
        {
            if (sCleanInput[left] != sCleanInput[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    static void Main(string[] args)
    {
        string input = "A man, a plan, a canal: Panama";
        Palindrom p = new Palindrom();
        if (p.isPalindrom(input))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");

    }
}