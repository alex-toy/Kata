namespace Kata
{
    public class RomanNumberGenerator
    {
        private static Dictionary<int, string> _thresholdRomanSymbols = new Dictionary<int, string>
        {
            [50] = "L",
            [40] = "XL",
            [10] = "X",
            [9] = "IX",
            [5] = "V",
            [4] = "IV",
        };

        public static string ToRoman(int arabNumber)
        {
            (int threshold, string romanSymbol) = _thresholdRomanSymbols.FirstOrDefault(a => arabNumber >= a.Key);

            if (romanSymbol != null) return romanSymbol + ToRoman(arabNumber - threshold);

            return new string('I', arabNumber);
        }
    }
}
