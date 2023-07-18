namespace leetcode
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices) // prices = [7,1,5,3,6,4]
        {
            int max = 0;
            int min = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (min > prices[i])
                {
                    min = prices[i];
                }

                if (prices[i] - min > max)
                {
                    max = prices[i] - min;
                }
            }

            return max;
        }
    }
}