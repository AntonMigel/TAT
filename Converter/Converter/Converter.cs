using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        /// <summary>
        /// Convert number to various systems(2-20)
        /// </summary>
        /// <returns>result</returns>
        public static string convertVariousSystem(string number, string Radix )
        {
            const int BitsInIng = 32;
            const string Digits = "0123456789ABCDEFGHIJ";
            int decimalNumber = Convert.ToInt32(number);
            int radix = Convert.ToInt32(Radix);

            if (decimalNumber == 0)
                return "0";
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
