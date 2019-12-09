using DevsuCodeJam.Exercises.Easy;
using Xunit;

namespace DevsuCodeJam.Tests
{
    public class EasyTests
    {
        [Theory]
        [InlineData("highEr ordEr fUnctions", "hi", "hhiighhiEr hiordhiEr fhiUncthiihions")]
        [InlineData("halls", "ll", "hllalls")]
        [InlineData("haDCJs!", null, "hDCJaDCJs!")]
        [InlineData("", "py", null)]
        public void Exercise01_Test(string resultExpected, string key, string message)
        {
            var result = Exercise01.Decrypt(key, message);

            Assert.Equal(resultExpected, result);
        }

        [Theory]
        [InlineData(360, new string[] { "12:00", "03:00", "06:00", "09:00" })]
        [InlineData(39.5f, new string[] { "12:00", "17:30", "blabla", "20:21", "26:88" })]
        [InlineData(-200, new string[] { "1200", "hola" })]
        public void Exercise02_Test(float resultExpected, string[] input)
        {
            var result = Exercise02.angles(input);

            Assert.Equal(resultExpected, result);
        }
    }
}