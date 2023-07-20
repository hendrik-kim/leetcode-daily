namespace leetcode
{
    public class UniqueOccurrencesSolution
    {
        public bool UniqueOccurrences(int[] arr) // arr = [1,2,2,1,1,3]
        {
            var numberDict = new Dictionary<int, int>();
            int conflictNumCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (numberDict.ContainsKey(arr[i])) { numberDict[arr[i]] += 1; }
                else { numberDict.Add(arr[i], 1); };
            }

            var array = new List<int>();
            foreach (var number in numberDict.Values)
            {
                array.Add(number);
            }


            for (int i = 0; i < array.Count; i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (array[i] == array[j]) conflictNumCount++;
                }
            }
            return conflictNumCount == 0;
        }
    }
}