namespace DevsuCodeJam.Exercises.SuperEasy
{
    public class Exercise04
    {
        public static int Series(int n)
        {
            if (n <= 0)
            {
                return -1;
            }

            int result = -3, inc = 1;

            if (n == 1)
            {
                return result;
            }

            for (int i = 2; i <= n; i++)
            {
                result += inc;
                inc += 2;
            }

            return result;
        }
    }
}