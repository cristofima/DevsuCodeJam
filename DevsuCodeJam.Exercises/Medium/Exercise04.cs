namespace DevsuCodeJam.Exercises.Medium
{
    public class Exercise04
    {
        public static int PascalTriangle(int x, int y)
        {
            int rows = x + 1, val = 1, blank, i, j;

            for (i = 0; i < rows; i++)
            {
                for (blank = 1; blank <= rows - i; blank++)

                    for (j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0)
                            val = 1;
                        else
                            val = val * (i - j + 1) / j;

                        if(i == x && j == y)
                        {
                            return val;
                        }
                    }
            }

            return -1;
        }
    }
}