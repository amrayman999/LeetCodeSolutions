

# LeetCode C# Solutions

Welcome to my LeetCode solution archive, written in **C# with .NET** using **Visual Studio**. Each problem is modularized with clean architecture, testable code, and CLI support. ??

---

## Solution Structure

```bash
LeetCodeSolutions/
??? Core/                  # Shared models & helpers (TreeNode, ListNode, etc.)
??? Problems/              # Class libraries for each problem
??? Runner/                # CLI runner for manual execution
??? LeetCodeSolutions.sln  # Visual Studio solution
```

---

## Solved Problems


| #  | Problem Name                                 | Difficulty | Solution File                                                                                  | LeetCode Link                                                      |
|----|----------------------------------------------|------------|-----------------------------------------------------------------------------------------------|--------------------------------------------------------------------|
| 1  | Two Sum                                      | Easy       | [TwoSum.cs](./LeetCode.Problems/TwoSum.cs)                                    | [LeetCode 1](https://leetcode.com/problems/two-sum/)               |
| 2  | Container With Most Water                    | Medium     | [ContainerWithMostWater.cs](./LeetCode.Problems/ContainerWithMostWater.cs)    | [LeetCode 11](https://leetcode.com/problems/container-with-most-water/) |
| 3  | Longest Common Prefix                        | Easy       | [LongestCommonPrefix.cs](./LeetCode.Problems/LongestCommonPrefix.cs)          | [LeetCode 14](https://leetcode.com/problems/longest-common-prefix/) |
| 4  | Remove Duplicates From Sorted Array          | Easy       | [RemoveDuplicatesFromSortedArray.cs](./LeetCode.Problems/RemoveDuplicatesFromSortedArray.cs) | [LeetCode 26](https://leetcode.com/problems/remove-duplicates-from-sorted-array/) |
| 5  | Remove Element                               | Easy       | [RemoveElement.cs](./LeetCode.Problems/RemoveElement.cs)                      | [LeetCode 27](https://leetcode.com/problems/remove-element/)        |
| 6  | Search Insert Position                       | Easy       | [SearchInsertPosition.cs](./LeetCode.Problems/SearchInsertPosition.cs)         | [LeetCode 35](https://leetcode.com/problems/search-insert-position/) |
| 7  | Merge Sorted Array                           | Easy       | [MergeSortedArray.cs](./LeetCode.Problems/MergeSortedArray.cs)                 | [LeetCode 88](https://leetcode.com/problems/merge-sorted-array/)    |
| 8  | Pascal's Triangle                            | Easy       | [Pascal_sTriangle.cs](./LeetCode.Problems/Pascal_sTriangle.cs)                | [LeetCode 118](https://leetcode.com/problems/pascals-triangle/)     |
| 9  | Longest Substring Without Repeating Characters| Medium    | [LongestSubstringWithoutRepeatingCharacters.cs](./LeetCode.Problems/LongestSubstringWithoutRepeatingCharacters.cs) | [LeetCode 3](https://leetcode.com/problems/longest-substring-without-repeating-characters/) |
| 10 | Longest Palindromic Substring                | Medium     | [LongestPalindromicSubstring.cs](./LeetCode.Problems/LongestPalindromicSubstring.cs) | [LeetCode 5](https://leetcode.com/problems/longest-palindromic-substring/) |
| 11 | Roman to Integer                             | Easy       | [RomanToInteger.cs](./LeetCode.Problems/RomanToInteger.cs)                   | [LeetCode 13](https://leetcode.com/problems/roman-to-integer/)      |
| 12 | Add Two Numbers                              | Medium     | [AddTwoNumbers.cs](./LeetCode.Problems/AddTwoNumbers.cs)                  | [LeetCode 2](https://leetcode.com/problems/add-two-numbers/)        |
| 13 | Palindrome Number                            | Easy       | [PalindromeNumber.cs](./LeetCode.Problems/PalindromeNumber.cs)                  | [LeetCode 9](https://leetcode.com/problems/palindrome-number/)      |
| 14 | Valid Parentheses                            | Easy       | [ValidParentheses.cs](./LeetCode.Problems/ValidParentheses.cs)                 | [LeetCode 20](https://leetcode.com/problems/valid-parentheses/)     |
| 15 | Find the Index of the First Occurrence in a String | Easy | [FindTheIndexOfTheFirstOccurrenceInaString.cs](./LeetCode.Problems/FindTheIndexOfTheFirstOccurrenceInaString.cs) | [LeetCode 28](https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/) |
| 16 | Length of Last Word                          | Easy       | [LengthOfLastWord.cs](./LeetCode.Problems/LengthOfLastWord.cs)               | [LeetCode 58](https://leetcode.com/problems/length-of-last-word/)   |
| 17 | Add Binary                                   | Easy       | [AddBinary.cs](./LeetCode.Strings/Problems/AddBinary.cs)  

---

## How to Run

### Run Manually via CLI

```bash
dotnet run --project Runner/LeetCode.Runner -- twosum
```

---

## Features

- ? Clean folder structure per topic
- ??? Console runner to test interactively
- ?? Easy to expand: just add a new class and run

---

## How to Add New Problem

1. Create a new class in `LeetCode.Problems/[Problem Name]` 
2. Optionally create a `Run_ProblemName.cs` CLI file
3. Register it in `Program.cs` and `Menu.cs`

---

> Made with ?? by [[amrayman1999](https://github.com/amrayman999)]

