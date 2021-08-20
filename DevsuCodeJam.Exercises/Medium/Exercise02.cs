namespace DevsuCodeJam.Exercises.Medium
{
    public class Exercise02
    {
        public static char[,] Minesweeper(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == ' ')
                    {
                        board[i, j] = char.Parse(CountMines(board, i, j).ToString());
                    }
                }
            }

            return board;
        }

        private static int CountMines(char[,] board, int i, int j)
        {
            int result = 0, lastRow = board.GetLength(0) - 1, lastColumn = board.GetLength(1) - 1;

            // Up

            if (i - 1 >= 0)
            {
                if (j - 1 >= 0)
                {
                    if (board[i - 1, j - 1] == 'x')
                    {
                        result++;
                    }
                }

                if (board[i - 1, j] == 'x')
                {
                    result++;
                }

                if (j + 1 <= lastColumn)
                {
                    if (board[i - 1, j + 1] == 'x')
                    {
                        result++;
                    }
                }
            }

            // Left

            if (j - 1 >= 0)
            {
                if (board[i, j - 1] == 'x')
                {
                    result++;
                }
            }

            // Right

            if (j + 1 <= lastColumn)
            {
                if (board[i, j + 1] == 'x')
                {
                    result++;
                }
            }

            // Down

            if (i + 1 <= lastRow)
            {
                if (j - 1 >= 0)
                {
                    if (board[i + 1, j - 1] == 'x')
                    {
                        result++;
                    }
                }

                if (board[i + 1, j] == 'x')
                {
                    result++;
                }

                if (j + 1 <= lastColumn)
                {
                    if (board[i + 1, j + 1] == 'x')
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}