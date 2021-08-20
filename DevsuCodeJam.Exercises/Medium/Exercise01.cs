using System;

namespace DevsuCodeJam.Exercises.Medium
{
    public class Exercise01
    {
        public static string Rochambeau(string[] player1, string[] player2)
        {
            if (player1 == null || player2 == null || player1.Length == 0 || player2.Length == 0)
            {
                return "players tied";
            }

            int pointsPlayer1 = 0, pointsPlayer2 = 0, resultPerRound;

            int minLenght = Math.Min(player1.Length, player2.Length);

            bool isValidP1, isValidP2;

            for (int i = 0; i < minLenght; i++)
            {
                isValidP1 = IsValid(player1[i]);
                isValidP2 = IsValid(player2[i]);

                if (!isValidP1 && !isValidP2)
                {
                    continue;
                }
                else
                {
                    if (isValidP1 && !isValidP2)
                    {
                        pointsPlayer1++;
                        continue;
                    }
                    else if (!isValidP1 && isValidP2)
                    {
                        pointsPlayer2++;
                        continue;
                    }

                    resultPerRound = PlayerWin(player1[i], player2[i]);

                    if (resultPerRound == 0)
                    {
                        continue;
                    }
                    else if (resultPerRound == 1)
                    {
                        pointsPlayer1++;
                    }
                    else
                    {
                        pointsPlayer2++;
                    }
                }
            }

            if (pointsPlayer1 > pointsPlayer2)
            {
                return $"player 1 won by {pointsPlayer1} point" + (pointsPlayer1 == 1 ? "" : "s");
            }
            else if (pointsPlayer1 == pointsPlayer2)
            {
                return "players tied";
            }
            else
            {
                return $"player 2 won by {pointsPlayer2} point" + (pointsPlayer2 == 1 ? "" : "s");
            }
        }

        private static bool IsValid(string text)
        {
            return text == "spock" || text == "rock" || text == "lizard" || text == "scissors" || text == "paper";
        }

        private static int PlayerWin(string op1, string op2)
        {
            switch (op1)
            {
                case "rock":
                    if (op2 == "rock")
                    {
                        return 0;
                    }

                    if (op2 == "scissors" || op2 == "lizard")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                case "scissors":
                    if (op2 == "scissors")
                    {
                        return 0;
                    }

                    if (op2 == "paper" || op2 == "lizard")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                case "paper":
                    if (op2 == "paper")
                    {
                        return 0;
                    }

                    if (op2 == "rock" || op2 == "spock")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                case "lizard":
                    if (op2 == "lizard")
                    {
                        return 0;
                    }

                    if (op2 == "spock" || op2 == "paper")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                case "spock":
                    if (op2 == "spock")
                    {
                        return 0;
                    }

                    if (op2 == "scissors" || op2 == "rock")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                default:
                    return 0;
            }
        }
    }
}