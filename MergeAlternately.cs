namespace leetcode_daily
{
    public class MergeAlternatelySolution
    {
        public string MergeAlternately(string word1, string word2) // word1 = "abc", word2 = "pqrabc"
        {
            string result = "";
            int minLength = Math.Min(word1.Length, word2.Length);

            for (int i = 0; i < minLength; i++)
            {
                result += word1[i];
                result += word2[i];
            }

            if (word1.Length > word2.Length)
            {
                for (int i = minLength; i < word1.Length; i++)
                {
                    result += word1[i];
                }
            }
            else if (word1.Length < word2.Length)
            {
                for (int i = minLength; i < word2.Length; i++)
                {
                    result += word2[i];
                }
            }

            return result;
        }//apbqcr
    }
}