public class MaximumWealthSolution
{
    public int MaximumWealth(int[][] accounts) // [[1,2,3],[3,2,1]]
    {
        int maxNumber = 0;
        foreach (var account in accounts)
        {
            int tempSum = 0;
            for (int i = 0; i < account.Length; i++)
            {
                tempSum += account[i];
                if (tempSum >= maxNumber) maxNumber = tempSum;
            }
        }
        return maxNumber;
    }
}