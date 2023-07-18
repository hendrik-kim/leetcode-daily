namespace leetcode
{
    public class ValidParentheses
    {
        public bool IsValid(string s) //"{[]}"
        {
            if (s.Length % 2 != 0) return false;
            if (s[0] == '}' || s[0] == '}' || s[0] == ']') return false;
            int storeCount = 0;
            var dict = new Dictionary<char, char>();
            dict.Add('(', ')');
            dict.Add('[', ']');
            dict.Add('{', '}');

            var storage = new List<char>();

            //traverse s with for loop
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{' || s[i] == '[' || s[i] == '(')
                {
                    storage.Add(s[i]);
                    storeCount++;
                }
                else
                {
                    if (storage.Count == 0) return false;
                    if (s[i] == dict[storage[storage.Count - 1]])
                    {
                        storage.RemoveAt(storage.Count - 1);
                        storeCount--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (storeCount > 0) return false;
            return true;
        }
    }
}