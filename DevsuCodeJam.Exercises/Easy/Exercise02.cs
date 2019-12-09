using System;

namespace DevsuCodeJam.Exercises.Easy
{
    public class Exercise02
    {
        public static float angles(string[] times)
        {
            string[] array;
            float sum = 0;
            int hour, minute;
            float angle;

            foreach (string value in times)
            {
                array = value.Split(':');

                if (array.Length == 2)
                {
                    hour = int.Parse(array[0]);

                    if (hour <= 23 && hour >= 0)
                    {
                        minute = int.Parse(array[1]);

                        if (minute <= 59 && minute >= 0)
                        {
                            if (hour >= 12)
                            {
                                hour -= 12;
                            }

                            angle = 0.5f * (60 * hour - 11 * minute);
                            if (angle > 180)
                            {
                                angle = 360 - angle;
                            }

                            angle = Math.Abs(angle);

                            sum += angle;
                        }
                    }
                }
                else
                {
                    sum -= 100;
                }
            }

            return sum;
        }
    }
}