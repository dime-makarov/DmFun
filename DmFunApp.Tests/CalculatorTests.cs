namespace DmFunApp.Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SumReturnsSum()
        {
            // Arrange
            var calc = new Calculator();
            int n1 = 7;
            int n2 = 13;

            // Act
            int s = calc.Sum(n1, n2);

            // Assert
            Assert.That(s, Is.EqualTo(n1 + n2));
        }
    }
}