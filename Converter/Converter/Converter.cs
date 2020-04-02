using System;

namespace Converter
{
   public  class  сonvertFromDec
    {
        public static string ConvertVariousSystem(string number, string Radix )
        {
            const int BitsInIng = 32;
            const string Digits = "0123456789ABCDEFGHIJ";
            int decimalNumber = Convert.ToInt32(number);
            int radix = Convert.ToInt32(Radix);

            if (radix < 2 || radix > 20)
                throw new ArgumentException("The radix must be >= 2 and <=20 " );
            if (decimalNumber == 0)
            {
                return "0";
            }
            int index = BitsInIng - 1;
            char[] charArray = new char[BitsInIng];

            while (decimalNumber != 0)
            {
                int remainder = decimalNumber % radix;
                charArray[index--] = Digits[remainder];
                decimalNumber = decimalNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInIng - index - 1);
            return result;
        }
    }
}
