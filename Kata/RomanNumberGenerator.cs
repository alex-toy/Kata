namespace Kata
{
    public class RomanNumberGenerator
    {
        public static string ToRoman(int arabNumber)
        {
            if (arabNumber <= 3) return new string('I', arabNumber);
            if (arabNumber == 4) return "IV";
            return "V" + ToRoman(arabNumber-5);
        }
    }
}
