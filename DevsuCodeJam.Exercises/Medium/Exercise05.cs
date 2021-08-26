using System.Collections.Generic;
using System.Linq;

namespace DevsuCodeJam.Exercises.Medium
{
    public class Exercise05
    {
        public static int DistinctCharacters(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            text = text.ToLower();
            var distinctChars = new List<string>();

            var array = text.ToCharArray();
            for(var i = 0; i < array.Length; i++)
            {
                if(!distinctChars.Any(x => x == array[i].ToString()))
                {
                    distinctChars.Add(array[i].ToString());
                }
            }

            if(distinctChars.Count == text.Length)
            {
                return text.Length;
            }

            var init = 0;
            var smallestLen = text.Length;

            do
            {
                for(var i = init; i <= text.Length - distinctChars.Count; i++)
                {
                    var subString = string.Empty;
                    if(i == init)
                    {
                        subString = text.Substring(i, distinctChars.Count);
                    }
                    else if(i - init + distinctChars.Count < text.Length)
                    {
                        subString = text.Substring(init, i - init + distinctChars.Count);
                    }

                    if (!string.IsNullOrEmpty(subString) && HasAllDistinctCharacters(subString, distinctChars) && subString.Length < smallestLen)
                    {
                        smallestLen = subString.Length;
                    }
                }

                init++;
            } while (init < text.Length - distinctChars.Count);

            return smallestLen;
        }

        private static bool HasAllDistinctCharacters(string text, List<string> distinctChars)
        {
            var tempChars = new List<string>();
            var array = text.ToCharArray();
            for (var i = 0; i < array.Length; i++)
            {
                if (!tempChars.Any(x => x == array[i].ToString()) && distinctChars.Any(x => x == array[i].ToString()))
                {
                    tempChars.Add(array[i].ToString());
                }
            }

            return tempChars.Count == distinctChars.Count;
        }
    }
}
