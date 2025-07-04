using LeetCode.Runner.ProblemExecutors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner
{
    public static class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Choose a problem to run:");
            Console.WriteLine("1. Two Sum");
            Console.WriteLine("2. Container With Most water");
            Console.WriteLine("3. Longest Common Prefix");
            Console.WriteLine("4. Remove Duplicates From Sorted Array");
            Console.WriteLine("5. Remove Element");
            Console.WriteLine("6. Search Insert Position");
            Console.WriteLine("7. Merge Sorted Array");
            Console.WriteLine("8. Pascal's Triangle");
            Console.WriteLine("9. Longest Substring Without Repeating Characters");
            Console.WriteLine("10. Longest Palindromic Substring");
            Console.WriteLine("11. Roman to Integer");
            Console.WriteLine("12. Add Two Numbers");
            Console.WriteLine("13. Palindrome Number");
            Console.WriteLine("14. Valid Parentheses");
            Console.WriteLine("15. Find the Index of the First Occurrence in a String");
            Console.WriteLine("16. Length of Last Word");
            Console.WriteLine("17. Add Binary");

            var key = Console.ReadLine();

            switch (key)
            {
                case "1": 
                    Run_TwoSum.Run(); 
                    break;
                case "2":
                    Run_ContainerWithMostWater.Run(); 
                    break;
                case "3":
                    Run_LongestCommonPrefix.Run(); 
                    break;
                case "4":
                    Run_RemoveDuplicatesFromSortedArray.Run(); 
                    break;
                case "5":
                    Run_RemoveElement.Run(); 
                    break;
                case "6":
                    Run_SearchInsertPosition.Run(); 
                    break;
                case "7":
                    Run_MergeSortedArray.Run();
                    break;
                case "8":
                    Run_Pascal_sTriangle.Run();
                    break;
                case "9":
                    Run_LongestSubstringWithoutRepeatingCharacters.Run();
                    break;
                case "10":
                    Run_LongestPalindromicSubstring.Run();
                    break;
                case "11":
                    Run_RomanToInteger.Run();
                    break;
                case "12":
                    Run_AddTwoNumbers.Run();
                    break;
                case "13":
                    Run_PalindromeNumber.Run();
                    break;
                case "14":
                    Run_ValidParentheses.Run();
                    break;
                case "15":
                    Run_FindTheIndexOfTheFirstOccurrenceInaString.Run();
                    break;
                case "16":
                    Run_LengthOfLastWord.Run();
                    break;
                case "17":
                    Run_AddBinary.Run();
                    break;
                default:
                    Console.WriteLine("Unknown problem key: " + key);
                    Console.WriteLine("Please try again.");
                    Show(); // Show the menu again for a valid input
                    break;


            }
        }
    }
}
