namespace leetcode
{
    public class PalindromeNumber
    {
        public bool IsPalindromeNumber(int x) //112311
        {
            if (x < 0) return false;
            var dict = new Dictionary<int, int>();
            //Put each digit of x into an int Dict
            int index = 0;
            do
            {
                dict.Add(index, x % 10);
                x /= 10;
                index++;
            } while (x > 0);
            //Traverse the Dict

            for (int i = 0; i < dict.Count; i++)
            {
                //Compare Dict's key 0-i with Dict.Length-1-i
                if (dict[i] != dict[dict.Count - 1 - i])
                {
                    //if find matched i return true;
                    return false;
                }

            }

            return true;
        }
    }
}