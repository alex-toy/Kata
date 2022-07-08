using FluentAssertions;

namespace Kata.Tests
{
    [TestFixture]
    class RomanNumberGeneratorTests
    {
        [TestCase(1, "I")][TestCase(2, "II")][TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")][TestCase(6, "VI")][TestCase(7, "VII")][TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")][TestCase(11, "XI")][TestCase(12, "XII")][TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(39, "XXXIX")]
        [TestCase(40, "XL")]
        [TestCase(41, "XLI")]
        [TestCase(49, "XLIX")]
        [TestCase(50, "L")]
        public void ToRoman_Should_Return_Exact_Roman_Number_Corresponding_To_Parameter(int arabNumber, string expectedRomanNumber)
        {
            string result = RomanNumberGenerator.ToRoman(arabNumber);
            result.Should().Be(expectedRomanNumber);
        }
    }
}
