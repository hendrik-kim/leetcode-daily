namespace leetcode
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            if (strs.Length == 1) return strs[0];

            string result = "";
            string firstStr = strs[0];
            string secondStr = strs[1];

            int len = Math.Min(firstStr.Length, secondStr.Length);

            for (int i = 0; i < len; i++)
            {
                if (firstStr[i] == secondStr[i])
                {
                    result += firstStr[i];
                }
                else
                {
                    break;
                }
            }

            var newStrs = new string[strs.Length - 1];
            newStrs[0] = result;
            for (int i = 1; i < strs.Length - 1; i++)
            {
                newStrs[i] = strs[i + 1];
            }

            if (newStrs.Length > 1) { result = LongestCommonPrefix(newStrs); };

            return result;
        }
    }
}
