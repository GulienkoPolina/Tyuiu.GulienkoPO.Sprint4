using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GulienkoPO.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {
        public int Calculate(int[,] array)
        {
            int c = 0;
            int mx = 0;
            int ctr = array.GetUpperBound(0) + 1;
            int ct = array.Length / ctr;
            for (int i = 1; i <= 1; i++)
            {
                for (int j = 0; j < ct; j++)
                {
                    if (array[i, j] > 0)
                    {
                        c = array[i, j];
                        mx = Math.Max(c, mx);
                    }
                }
            }
            return mx;
        }
    }
}