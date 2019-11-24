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
    }
}