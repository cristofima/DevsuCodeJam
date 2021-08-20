using System;
using System.Linq;

namespace DevsuCodeJam.Exercises.Difficult
{
    public class Exercise02
    {
        public static int[] SumToZero(int[] array)
        {
            if (array == null || array.Sum() == 0)
            {
                return Array.Empty<int>();
            }

            if (array.Length == 1)
            {
                return array;
            }

            return CheckArray(0, 1, array);
        }

        private static int[] CheckArray(int firstIndex, int lastIndex, int[] array)
        {
            if (firstIndex == lastIndex)
            {
                return array;
            }

            if (firstIndex + 1 == array.Length - 1 && array[firstIndex] + array[lastIndex] != 0)
            {
                return array;
            }

            var tempArray = Slice(array, firstIndex, lastIndex);

            if (tempArray.Sum() == 0)
            {
                if (firstIndex == 0)
                {
                    array = Slice(array, lastIndex + 1, array.Length - 1);
                }
                else
                {
                    var list = Slice(array, 0, firstIndex - 1).ToList();
                    list.AddRange(Slice(array, lastIndex + 1, array.Length - 1).ToList());
                    array = list.ToArray();
                }

                if (array.Length <= 1)
                {
                    return array;
                }

                return CheckArray(0, 1, array);
            }

            if (lastIndex + 1 < array.Length)
            {
                return CheckArray(firstIndex, lastIndex + 1, array);
            }
            else if(array.Length > 2)
            {
                return CheckArray(firstIndex + 1, firstIndex + 2, array);
            }

            return null;
        }

        private static int[] Slice(int[] source, int start, int end)
        {
            // Handles negative ends.
            if (end < 0)
            {
                end = source.Length + end;
            }

            int len = end - start;

            // Return new array.
            var res = new int[len + 1];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = source[i + start];
            }

            return res;
        }
    }
}