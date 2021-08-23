using System.Linq;

namespace DevsuCodeJam.Exercises.Difficult
{
    public class Exercise03
    {
        public static int KaprekarConstant(int number)
        {
            if (IsValidNumber(number))
            {
                var KAPREKAR_CONSTANT = 6174;

                var count = 0;
                var tempNumber = number;

                while(tempNumber != KAPREKAR_CONSTANT)
                {
                    count++;
                    var ascNumber = GetNumber(tempNumber, false);
                    var descNumber = GetNumber(tempNumber, true);

                    tempNumber = descNumber - ascNumber;
                }

                return count;
            }

            return -1;
        }

        private static int GetNumber(int number, bool desc)
        {
            var list = number.ToString().ToList();
            list.Sort();

            if (desc)
            {
                list.Reverse();
            }

            return int.Parse(string.Join("", list.ToArray()));
        }

        private static bool IsValidNumber(int number)
        {
            if(number >= 1000 && number <= 9999)
            {
                var list = number.ToString().ToList().Distinct().ToList();
                return list.Count() > 1;
            }

            return false;
        }
    }
}
