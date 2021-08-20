using DevsuCodeJam.Exercises.Difficult;
using Xunit;

namespace DevsuCodeJam.Tests
{
    public class DifficultTests
    {
        [Fact]
        public void Exercise01_Test()
        {
            var input = new int[,]
            {
                { 1,2,3,4,8,1 },
                { 5,1,2,3,4,8 },
                { 4,5,1,2,3,4 },
                { 7,4,5,1,2,3 }
            };

            var result = Exercise01.Toeplitz(input);
            var resultExpected = 7;

            Assert.Equal(resultExpected, result);
        }

        [Theory]
        [InlineData(new int[] { 5, 8 }, new int[] { 3, 4, -7, 5, -6, 2, 5, -1, 8 })]
        [InlineData(new int[] { 9 }, new int[] { 1, -7, 4, 2, 9, 0, -4, 2, 2 })]
        [InlineData(new int[] { 1, -7, 4, 1, 9 }, new int[] { 1, -7, 4, 1, 9, 0, -4, 2, 2 })]
        [InlineData(new int[] {  }, new int[] { 2, -6, -3, 7 })]
        [InlineData(new int[] { 8 }, new int[] { 8 })]
        [InlineData(new int[] { 3 }, new int[] { 0, 0, 3 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] {  }, null)]
        public void Exercise02_Test(int[] resultExpected, int[] input)
        {
            var result = Exercise02.SumToZero(input);

            Assert.Equal(resultExpected, result);
        }
    }
}