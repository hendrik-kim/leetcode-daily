namespace leetcode
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            //LVIII
            int result = 0;
            //IIII is not possible
            if (s == "IIII") return -1;

            //I, II, III is plus 1
            //I, X, C can be before V, L, D

            var dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            //Traverse the s 
            int prevNumber = 0;
            for (int i = s.Length - 1; i >= 0; i--) //6...
            {
                //MCMXCIV
                if (dict[s[i]] >= prevNumber)
                {
                    result += dict[s[i]]; //5
                    prevNumber = dict[s[i]] > prevNumber ? dict[s[i]] : prevNumber;
                }
                else
                {
                    result -= dict[s[i]];
                    continue;
                }

            }

            //int indexNumb = 0;
            //if s[i] <= s[i-1] add to result
            //else take away from result
            return result;
        }
    }
}