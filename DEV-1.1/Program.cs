using System;

namespace DEV_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
           string line = Console.ReadLine();
           StringProcessor stringProcessor = new StringProcessor(line);
           Console.WriteLine(stringProcessor.getCountDiffSymbol());
        }
    }
}
