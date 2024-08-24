
namespace ConsoleReaderTest
{
    public class ConsoleReaderTest
    {
        [Theory]
        [InlineData(5, 3, 9, 12)]
        [InlineData(-45, -33, -29, -62)]
        public void SumOfNumbers_WithInputs_ShouldReturnTheCorrectSum(int a, int b, int c, int expected)
        {
            int result = ConsoleReader.SumOfNumbers(a, b, c);
            Assert.Equal(expected, result);
        }
    }
}