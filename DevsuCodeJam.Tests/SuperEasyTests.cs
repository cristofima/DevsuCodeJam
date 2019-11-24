using DevsuCodeJam.Exercises.SuperEasy;
using Xunit;

namespace DevsuCodeJam.Tests
{
    public class SuperEasyTests
    {
        [Theory]
        [InlineData("dcjI ldcjovdcje prdcjOgrdcjAmmdcjing!", "dcj", "I love prOgrAmming!")]
        [InlineData("", "dcj", null)]
        [InlineData("HDCJellDCJo!", null, "Hello!")]
        public void Exercise01_Test(string resultExpected, string key, string message)
        {
            var result = Exercise01.Encrypt(key, message);

            Assert.Equal(resultExpected, result);
        }

        [Theory]
        [InlineData(new long[] { 3, 1, 41, 31, 961 }, new long[] { 65647440, 199644521 })]
        [InlineData(new long[] { 3, 1, 41, 31, 961 }, new long[] { 65647440, 199644521, -155545 })]
        [InlineData(new long[] { 0, 0, 0, 0, 0 }, new long[] { })]
        [InlineData(new long[] { 0, 0, 0, 0, 0 }, null)]
        public void Exercise02_Test(long[] resultExpected, long[] input)
        {
            var result = Exercise02.Track(input);

            Assert.Equal(resultExpected, result);
        }

        [Theory]
        [InlineData("GrEetIngS, ThiS iS An ExAMpLE!", 3, "Greetings, this is AN EXAMPLE!")]
        [InlineData("", 3, null)]
        [InlineData("Greetings, this is AN EXAMPLE!", 0, "Greetings, this is AN EXAMPLE!")]
        [InlineData("Greetings, this is AN EXAMPLE!", -554, "Greetings, this is AN EXAMPLE!")]
        public void Exercise03_Test(string resultExpected, int k, string message)
        {
            var result = Exercise03.NthCase(k, message);

            Assert.Equal(resultExpected, result);
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(-1, -56)]
        [InlineData(-3, 1)]
        [InlineData(-2, 2)]
        [InlineData(22, 6)]
        public void Exercise04_Test(int resultExpected, int n)
        {
            var result = Exercise04.Series(n);

            Assert.Equal(resultExpected, result);
        }
    }
}