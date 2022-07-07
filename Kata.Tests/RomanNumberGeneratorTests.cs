using FluentAssertions;

namespace Kata.Tests
{
    [TestFixture]
    class RomanNumberGeneratorTests
    {
        [TestCase(1, "I")][TestCase(2, "II")][TestCase(3, "III")]
        [TestCase(4, "IV")][TestCase(5, "V")]
        [TestCase(6, "VI")][TestCase(7, "VII")]
        public void ToRoman_Should_Return_Exact_Roman_Number_Corresponding_To_Parameter(int arabNumber, string expectedRomanNumber)
        {
            string result = RomanNumberGenerator.ToRoman(arabNumber);
            result.Should().Be(expectedRomanNumber);
        }
    }
}
