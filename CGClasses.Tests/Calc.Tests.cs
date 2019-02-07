using Xunit;

namespace CGClasses.Tests
{
    public class CalcTests
    {
        [Theory]
        [InlineData(33, 12)]
        [InlineData(5, 4)]
        public void AddTest(int x, int y)
        {
            Assert.Equal($"{x + y}", $"{ Calc.Add(x, y)}");
        }
        [Theory]
        [InlineData(33, 12)]
        [InlineData(5, 4)]
        public void SubTest(int x, int y)
        {
            Assert.Equal($"{x - y}", $"{ Calc.Sub(x, y)}");
        }
        [Theory]
        [InlineData(33, 12)]
        [InlineData(5, 4)]
        public void MultTest(int x, int y)
        {
            Assert.Equal($"{x * y}", $"{ Calc.Mult(x, y)}");
        }
        [Theory]
        [InlineData(33, 12)]
        [InlineData(5, 4)]
        public void DivTest(int x, int y)
        {
            Assert.Equal($"{x / y}", $"{ Calc.Div(x, y)}");
        }
        [Fact]
        public void FactTest()
        {

            Assert.Equal($"{3628800}", $"{ Calc.Fact(10)}");
            Assert.Equal($"{1}", $"{ Calc.Fact(0)}");
            Assert.Equal($"{0}", $"{ Calc.Fact(22)}");
        }
    }
}