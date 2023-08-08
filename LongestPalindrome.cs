namespace leetcode_daily
{
    public string LongestPalindrome(string s)
    {
        if (s == null || s.Length < 1) return ""; // Return an empty string if the input is null or empty
        int start = 0, end = 0; // Variables to keep track of the start and end indices of the palindrome
        for (int i = 0; i < s.Length; i++)
        {
            int len1 = ReturnRangeExpandedAroundIndex(s, i, i); // Check odd-length palindrome
            int len2 = ReturnRangeExpandedAroundIndex(s, i, i + 1); // Check even-length palindrome
            int len = Math.Max(len1, len2); // Choose the longer palindrome length
            if (len > end - start)
            { // If a longer palindrome is found, update the start and end indices
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }
        return s.Substring(start, end - start + 1); // Return the palindrome substring based on the start and end indices
    }

    // Function to find and return the length of a palindrome by expanding around a given index
    private int ReturnRangeExpandedAroundIndex(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        { // Expand as long as the characters are equal
            left--;
            right++;
        }
        return right - left - 1; // Return the length of the palindrome after expansion
    }

}