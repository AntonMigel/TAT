using System;

namespace task_DEV_2._1
{
    class Invoker
    {
        ICommand command;
        DataBaseExecutor commandForBase = new DataBaseExecutor();
        public void Show()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nEnter Command:\n" + "1.Add product to Base\n" +
                             "2. Count All\n" +"3. Count Types\n" +"4. Average Price\n" +
                             "5. Average Price of Type\n" +"6. Exit\n");

                string inputString = Console.ReadLine();

                switch (inputString)
                {
                    case "1":
                        CarProduct product = InputInformation.GetProductToConsole();
                        command = new AddToBaseCommand(commandForBase, product);
                        command.Execute();
                        break;
                    case "2":
                        command = new CountAllCommand(commandForBase);
                        command.Execute();
                        break;
                    case "3":
                        command = new CountTypesCommand(commandForBase);
                        command.Execute();
                        break;
                    case "4":
                        command = new AveragePriceCommand(commandForBase);
                        command.Execute();
                        break;
                    case "5":
                        Console.WriteLine("Enter the brand of the product :");
                        string brand = Console.ReadLine();
                        command = new AveragePriceTypeCommand(commandForBase, brand);
                        command.Execute();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Unknown Command");
                        break;
                }
            }
        }

    }
}
