using System;

namespace task_DEV_2._1
{
    class InputInformation
    {
        public static CarProduct GetProductToConsole()
        {
            Console.WriteLine("Input Product Brand :");
            string brand = Console.ReadLine();    
            Console.WriteLine("Input Product Model :");
            string model = Console.ReadLine();

            Console.WriteLine("Input Product Price :");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Product Count :");
            int count = int.Parse(Console.ReadLine());

            return new CarProduct(brand, model, count, price);    
        }
    }
}
