namespace DevsuCodeJam.Exercises.SuperEasy
{
    public class Exercise02
    {
        public static long[] Track(long[] times)
        {
            long[] _times = new long[5];

            if (times == null)
            {
                _times[0] = 0;
                _times[1] = 0;
                _times[2] = 0;
                _times[3] = 0;
                _times[4] = 0;

                return _times;
            }

            long sum = 0;

            foreach (long value in times)
            {
                if (value > 0)
                {
                    sum += value;
                }
            }

            long miliDay = sum / 86400000;

            long difference = sum - (86400000 * miliDay);

            long miliHour = difference / 3600000;

            difference -= (3600000 * miliHour);

            long miliMinute = difference / 60000;

            difference -= (60000 * miliMinute);

            long miliSecond = difference / 1000;

            difference -= (1000 * miliSecond);

            _times[0] = miliDay;
            _times[1] = miliHour;
            _times[2] = miliMinute;
            _times[3] = miliSecond;
            _times[4] = difference;

            return _times;
        }
    }
}