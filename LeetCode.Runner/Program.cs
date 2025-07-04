using LeetCode.Runner;
using LeetCode.Runner.ProblemExecutors;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            switch (args[0].ToLower())
            {
                case "twosum":
                    Run_TwoSum.Run();
                    break;
                case "containerwithmostwater":
                    Run_ContainerWithMostWater.Run();
                    break;
                case "longestcommonprefix":
                    Run_LongestCommonPrefix.Run();
                    break;
                case "removeduplicatesfromsortedarray":
                    Run_RemoveDuplicatesFromSortedArray.Run();
                    break;
                case "removeelement":
                    Run_RemoveElement.Run();
                    break;
                case "searchinsertposition":
                    Run_SearchInsertPosition.Run();
                    break;
                case "mergesortedarray":
                    Run_MergeSortedArray.Run();
                    break;
                case "pascaltriangle":
                    Run_Pascal_sTriangle.Run();
                    break;
                case "longestsubstringwithoutrepeatingcharacters":
                    Run_LongestSubstringWithoutRepeatingCharacters.Run();
                    break;
                case "longestpalindromicsubstring":
                    Run_LongestPalindromicSubstring.Run();
                    break;
                case "romantointeger":
                    Run_RomanToInteger.Run();
                    break;
                case "addtwonumbers":
                    Run_AddTwoNumbers.Run();
                    break;
                case "palindromenumber":
                    Run_PalindromeNumber.Run();
                    break;
                case "validparentheses":
                    Run_ValidParentheses.Run();
                    break;
                case "findtheindexofthefirstoccurenceinastring":
                    Run_FindTheIndexOfTheFirstOccurrenceInaString.Run();
                    break;
                case "lengthoflastword":
                    Run_LengthOfLastWord.Run();
                    break;
                case "addbinary":
                    Run_AddBinary.Run();
                    break;
                default:
                    Console.WriteLine("Unknown problem key: " + args[0]);
                    break;
            }
        }
        else
        {
            Menu.Show(); // fallback to menu
        }
    }
}
