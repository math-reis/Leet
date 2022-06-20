
public class Solution
{
    static void Main(string[] args)
    {

    }

    //9. Palindrome Number: https://leetcode.com/problems/palindrome-number/
    public static bool IsPalindrome(int x)
    {
        bool IsPalindrome = false;

        string strX = x.ToString();

        if (strX.Length == 0 || strX.Length == 1)
        {
            IsPalindrome = true;

            return IsPalindrome;
        }

        string firstCh = strX.Substring(0, 1);

        string lastCh = strX.Substring(strX.Length - 1, 1);

        while (firstCh == lastCh) 
        {
            strX = strX.Remove(0, 1);

            strX = strX.Remove(strX.Length - 1, 1);

            int len = strX.Length;

            if (len == 1 || len == 0)
            {
                IsPalindrome = true;

                break;
            }
            else
            {
                firstCh = strX.Substring(0, 1);

                lastCh = strX.Substring(strX.Length - 1, 1);

                IsPalindrome = false;
            }
        }

        return IsPalindrome;
    }

    //1. Two Sum: https://leetcode.com/problems/two-sum/
    public static int[] TwoSum(int[] nums, int target)
    {
        int i = 0;
        int first = 0;
        int second = 0;
        int[] result = new int[2];
        bool breakResult = false;

        while (i != nums.Length)
        {
            foreach (int num in nums)
            {
                int sum = nums[first] + nums[second];

                if (sum == target)
                {
                    if (first == second)
                    {
                        result[0] = first;
                        result[1] = second + 1;
                    }
                    else
                    {
                        result[0] = first;
                        result[1] = second;
                    }

                    breakResult = true;
                    break;
                }

                second++;
            }

            if (breakResult)
            {
                break;
            }

            i++;
            first++;
            second = 0;
        }

        return result;
    }
}



