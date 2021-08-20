using System.Collections.Generic;

namespace DevsuCodeJam.Exercises.Difficult
{
    public class Exercise01
    {
        public static int Toeplitz(int[,] matrix)
        {
            if (CheckToeplitzMatrix(matrix))
            {
                List<int> uniqueNumbers = new List<int>();
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if (!uniqueNumbers.Contains(matrix[0, i]))
                    {
                        uniqueNumbers.Add(matrix[0, i]);
                    }
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (!uniqueNumbers.Contains(matrix[i, 0]))
                    {
                        uniqueNumbers.Add(matrix[i, 0]);
                    }
                }

                return uniqueNumbers.Count;
            }
            else
            {
                return -1;
            }
        }

        private static bool CheckToeplitzMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] != matrix[i + 1, j + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}