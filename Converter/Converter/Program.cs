using System;

namespace Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Command: FC , CF , FM , MF
                double inputvalue = Convert.ToDouble(args[0]);
                string command = args[1];
                IConverterFactory converterFactory = FactoryCreator.CreateSpecificFactory(command);
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
