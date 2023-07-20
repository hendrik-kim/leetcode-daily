namespace leetcode_daily
{
    public class ClimbStairsSolution
    {
        public int ClimbStairs(int n) //4
        {
            if (n <= 1) return 1;

            var oneStep = ClimbStairs(n - 1);
            var twoStep = ClimbStairs(n - 2);


            return oneStep + twoStep;
        }
    }
}