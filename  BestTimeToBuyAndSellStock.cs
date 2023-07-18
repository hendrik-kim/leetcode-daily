namespace leetcode
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices) // prices = [7,1,5,3,6,4]
        {
            int currProfit = 0;
            if (prices.Length <= 1) return currProfit;

            //traverse prices from back
            //if(prices[i] - prices[i-j] > currProfit)
            //currProfit = prices[i] - prices[i-j]
            for (int i = prices.Length - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (prices[i] - prices[j] >= currProfit)
                    {
                        currProfit = prices[i] - prices[j];
                    }
                }
            }

            return currProfit;
        }
    }
}