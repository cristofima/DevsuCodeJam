using DevsuCodeJam.Exercises.Medium;
using Xunit;

namespace DevsuCodeJam.Tests
{
    public class MediumTests
    {
        [Theory]
        [InlineData("player 2 won by 3 points", new string[] { "rock", "lizard ", "scissors", "scissors" }, new string[] { "paper", "rock", "spock", "paper" })]
        [InlineData("player 1 won by 1 point", new string[] { "paper", "lizard", "scissors", "spock" }, new string[] { "spock", "lizard", "scissors", "spock" })]
        [InlineData("player 2 won by 1 point", new string[] { "rock", "lizard ", "scissors", "paper" }, new string[] { "paper", "lizard ", "scissors", "paper" })]
        [InlineData("players tied", new string[] { "paper", "lizard", "scissors", "spock" }, new string[] { })]
        [InlineData("players tied", null, null)]
        public void Exercise01_Test(string resultExpected, string[] player1, string[] player2)
        {
            var result = Exercise01.Rochambeau(player1, player2);

            Assert.Equal(resultExpected, result);
        }

        [Fact]
        public void Exercise02_Test()
        {
            var input = new char[,] {
                { ' ', ' ', ' ','x', ' ', ' ', ' ','x', ' ', ' '},
                { ' ', ' ','x', ' ', ' ','x', ' ', ' ', ' ','x'},
                { ' ','x', ' ', ' ', ' ','x','x','x','x', ' '},
                { ' ', ' ', ' ','x', ' ','x', ' ','x', ' ', ' '},
                { ' ', ' ', ' ', ' ', ' ','x','x','x', ' ','x'},
                { ' ','x', ' ', ' ','x','x','x', ' ', ' ', ' '}
            };

            var resultExpected = new char[,] {
                {'0','1','2','x','2','1','2','x','2','1'},
                {'1','2','x','2','3','x','5','4','4','x'},
                {'1','x','3','2','4','x','x','x','x','2'},
                {'1','1','2','x','4','x','8','x','5','2'},
                {'1','1','2','2','5','x','x','x','3','x'},
                {'1','x','1','1','x','x','x','3','2','1'}
            };

            var result = Exercise02.Minesweeper(input);

            Assert.Equal(result, resultExpected);
        }
    }
}