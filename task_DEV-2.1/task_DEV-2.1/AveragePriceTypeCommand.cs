using System;

namespace task_DEV_2._1
{
    class AveragePriceTypeCommand : ICommand
    {
        DataBaseExecutor Executor { get; set; }
        string Brand { get; set; }
        public AveragePriceTypeCommand(DataBaseExecutor executor, string brand)
        {
            Executor = executor;
            Brand = brand;
        }
        public void Execute()
        {
            Console.WriteLine(Executor.AveragePriceType(Brand));
        }
    }
}
