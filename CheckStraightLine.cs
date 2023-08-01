namespace leetcode_daily
{
    public class CheckStraightLineSolution
    {
        public bool CheckStraightLine(int[][] coordinates) //[[1,3],[2,6],[3,9],[4,12],[5,15],[6,18]]
        {
            int slope = 0;
            bool result = true;
            for (int i = 0; i < coordinates.Length - 1; i++)
            {
                int x1 = coordinates[i][0];
                int y1 = coordinates[i][1];
                int x2 = coordinates[i + 1][0];
                int y2 = coordinates[i + 1][1];

                int tempSlope = (y2 - y1) / (x2 - x1);
                slope = slope == 0 ? tempSlope : slope;
                if (slope != tempSlope)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}