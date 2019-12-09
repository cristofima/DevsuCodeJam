using System.Text.RegularExpressions;

namespace DevsuCodeJam.Exercises.Easy
{
    public class Exercise01
    {
        public static string Decrypt(string key, string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return string.Empty;
            }

            if (string.IsNullOrEmpty(key))
            {
                key = "DCJ";
            }

            string[] vowels = new string[] { "a", "e", "i", "o", "u" };

            string result = message;

            foreach (string vowel in vowels)
            {
                result = Regex.Replace(result, $"{key}{vowel}", vowel);
                result = Regex.Replace(result, $"{key}{vowel.ToUpper()}", vowel.ToUpper());
            }

            return result;
        }
    }
}