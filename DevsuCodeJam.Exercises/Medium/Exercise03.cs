using System;
using System.Collections.Generic;

namespace DevsuCodeJam.Exercises.Medium
{
    public class Exercise03
    {
        public static string EerieMob(int numberOfGuys)
        {
            if (numberOfGuys < 1 || numberOfGuys > 255)
            {
                return "(O_o)";
            }

            var tempNumber = double.Parse(numberOfGuys.ToString());
            var k = int.Parse((tempNumber % 2 == 0 ? (numberOfGuys / 2) + 1 : Math.Round(tempNumber / 2)).ToString());
            var partialGuysPosition = new List<int>();
            var n = 1;

            while (true)
            {
                var left = k - 3 * n;
                var right = k + 3 * n;

                if (left < 2 && right > numberOfGuys - 1)
                {
                    break;
                }

                if (left >= 2)
                {
                    partialGuysPosition.Add(left);
                }

                if (right <= numberOfGuys - 1)
                {
                    partialGuysPosition.Add(right);
                }

                n++;
            }

            var result = "";

            for (var i = 1; i <= numberOfGuys; i++)
            {
                if (numberOfGuys > 7)
                {
                    if (i == 1)
                    {
                        result += "(-";
                        continue;
                    }
                    else if (i == numberOfGuys)
                    {
                        result += "-)";
                        continue;
                    }
                }

                var existsCurrentPosition = partialGuysPosition.Find(p => p == i);
                if (existsCurrentPosition > 0)
                {
                    if (i < k)
                    {
                        result += "(-_-";
                    }
                    else
                    {
                        result += "-_-)";
                    }
                }
                else
                {
                    if (i == k)
                    {
                        result += "(-_-)";
                    }
                    else
                    {
                        if (i < k)
                        {
                            result += "(-_";
                        }
                        else
                        {
                            result += "_-)";
                        }
                    }
                }
            }

            return result;
        }
    }
}