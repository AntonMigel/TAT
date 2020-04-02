using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
          try
            {
                Console.WriteLine("Enter a number :");
                string number = Console.ReadLine();
                Console.WriteLine("Enter a radix :");
                string radix = Console.ReadLine();
                Console.WriteLine(сonvertFromDec.ConvertVariousSystem(number, radix));
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Ошибка: {exp.Message}");
            }
        }
    }
}
