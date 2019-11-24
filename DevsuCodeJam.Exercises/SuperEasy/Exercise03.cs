namespace DevsuCodeJam.Exercises.SuperEasy
{
    public class Exercise03
    {
        public static string NthCase(int n, string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return string.Empty;
            }

            if (n <= 0)
            {
                return message;
            }

            string result = "";
            char[] array = message.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if ((i + 1) % n != 0)
                {
                    result += array[i];
                }
                else
                {
                    if (char.IsUpper(array[i]))
                    {
                        result += char.ToLower(array[i]);
                    }
                    else
                    {
                        result += char.ToUpper(array[i]);
                    }
                }
            }

            return result;
        }
    }
}