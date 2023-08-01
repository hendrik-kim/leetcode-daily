using leetcode;
using leetcode_daily;

// var palindromeNumber = new PalindromeNumber();
// Console.WriteLine(palindromeNumber.IsPalindromeNumber(-1112111));

// RomanToInteger romanToInteger = new RomanToInteger();
// Console.WriteLine(romanToInteger.RomanToInt("MCMXCIV"));

// LongestCommonPrefixSolution solution = new LongestCommonPrefixSolution();
// Console.WriteLine(solution.LongestCommonPrefix(new string[] { "r", "re", "ref",
// "refl", "reflo", "reflow", "reflowe", "reflower" }));

// ValidParentheses validParentheses = new ValidParentheses();
// Console.WriteLine(validParentheses.IsValid("(){}}{"));

// CountOddsSolution solution = new CountOddsSolution();
// Console.WriteLine(solution.CountOdds(0, 5));

// var solution = new RunningSumSolution();
// var result = solution.RunningSum(new int[] { 1, 2, 3, 4 });

// BinarySearch binarySearch = new BinarySearch();
// binarySearch.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2);

// var solution = new ClimbStairsSolution();
// Console.WriteLine(solution.ClimbStairs(3));

var solution = new CheckStraightLineSolution();
int[][] jaggedArray = new int[][]
{
    new int[] {1,2},
    new int[] {2,3},
    new int[] {3,4},
    new int[] {4,5},
    new int[] {5,6},
    new int[] {6,7}
};
solution.CheckStraightLine(jaggedArray);