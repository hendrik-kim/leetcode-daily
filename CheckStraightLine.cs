namespace leetcode_daily
{
    public class CheckStraightLineSolution
    {
        public bool CheckStraightLine(int[][] coordinates) //[[1,3],[2,6],[3,9],[4,12],[5,15],[6,18]]
        {
            if (coordinates.Length == 2)
                return true;

            int dx = coordinates[1][0] - coordinates[0][0];
            int dy = coordinates[1][1] - coordinates[0][1];

            for (int i = 2; i < coordinates.Length; i++)
            {
                int dx1 = coordinates[i][0] - coordinates[i - 1][0];
                int dy1 = coordinates[i][1] - coordinates[i - 1][1];
                if (dy * dx1 != dy1 * dx)
                {
                    return false;
                }
            }
            return true;
        }
    }
}