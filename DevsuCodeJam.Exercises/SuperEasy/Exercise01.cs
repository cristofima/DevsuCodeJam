namespace DevsuCodeJam.Exercises.SuperEasy
{
    public class Exercise01
    {
        public static string Encrypt(string key, string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return string.Empty;
            }

            if (string.IsNullOrEmpty(key))
            {
                key = "DCJ";
            }

            string result = "";

            char[] array = message.ToCharArray();
            string itemAux;

            foreach (char item in array)
            {
                itemAux = item.ToString().ToLower();
                if (itemAux == "a" || itemAux == "e" || itemAux == "i" || itemAux == "o" || itemAux == "u")
                {
                    result += key;
                }

                result += item;
            }

            return result;
        }
    }
}