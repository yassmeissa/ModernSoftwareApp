using Xunit;
using ModernSoftwareApp; // <- nécessaire pour accéder à Calculator

namespace ModernSoftwareApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Add(2, 3));
        }
    }
}