
public class Solution
{
    static void Main(string[] args)
    {

    }

    //13. Roman to Integer: https://leetcode.com/problems/roman-to-integer/
    public static int RomanToInt(string s)
    {
        int num = 0;
        int initialLen = s.Length;

        for (int i = 0; i < initialLen; i++)
        {
            int len = s.Length;

            string lastChar = s.Length > 1 ? s.Substring(len - 1, 1) : s;

            string lastTwoChar = s.Length > 2 ? s.Substring(len - 2, 2) : s;

            if (lastTwoChar == "IV" || lastTwoChar == "IX" || lastTwoChar == "XL" || 
                lastTwoChar == "XC" || lastTwoChar == "CD" || lastTwoChar == "CM")
            {
                switch (lastTwoChar)
                {
                    case "IV":
                        s = s.Remove(len - 2, 2);
                        num += 4;
                        i++;
                        break;
                    case "IX":
                        s = s.Remove(len - 2, 2);
                        num += 9;
                        i++;
                        break;
                    case "XL":
                        s = s.Remove(len - 2, 2);
                        num += 40;
                        i++;
                        break;
                    case "XC":
                        s = s.Remove(len - 2, 2);
                        num += 90;
                        i++;
                        break;
                    case "CD":
                        s = s.Remove(len - 2, 2);
                        num += 400;
                        i++;
                        break;
                    case "CM":
                        s = s.Remove(len - 2, 2);
                        num += 900;
                        i++;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (lastChar)
                {
                    case "I":
                        s = s.Remove(len - 1, 1);
                        num++;
                        break;
                    case "V":
                        s = s.Remove(len - 1, 1);
                        num += 5;
                        break;
                    case "X":
                        s = s.Remove(len - 1, 1);
                        num += 10;
                        break;
                    case "L":
                        s = s.Remove(len - 1, 1);
                        num += 50;
                        break;
                    case "C":
                        s = s.Remove(len - 1, 1);
                        num += 100;
                        break;
                    case "D":
                        s = s.Remove(len - 1, 1);
                        num += 500;
                        break;
                    case "M":
                        s = s.Remove(len - 1, 1);
                        num += 1000;
                        break;
                    default:
                        break;
                }
            }
        }

        return num;
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



