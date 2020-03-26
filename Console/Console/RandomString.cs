using System;
using System.Collections.Generic;
using System.Text;

namespace StudentEvent
{
    class  RandomString
    {
        public static string getRandomString() 
        {
            string symbols = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int length = 7;
            var rand = new Random();
            StringBuilder builder = new StringBuilder(length);

            for (int i = 0; i < length; ++i) 
            {
                builder.Append(symbols[rand.Next(symbols.Length)]); 
            }
            return builder.ToString();
        }
    }
}
