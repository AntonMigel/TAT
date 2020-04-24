using System;

namespace Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input Value:");
                double inputvalue = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nCommand:\n" + "FC\n" +
                             "CF\n" + "FM\n" + "MF\n" 
                              );
                IConverterFactory converterFactory = FactoryCreator.CreateSpecificFactory("MF");
                IConverter converter = converterFactory.Create();
                Console.WriteLine(converter.Convert(inputvalue));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
