using System;

namespace task_DEV_2._1
{
    class AveragePriceCommand :ICommand
    {
        DataBaseExecutor Executor { get; set; }
        public AveragePriceCommand(DataBaseExecutor executor)
        {
            Executor = executor;
        }
        public void Execute()
        {
            Console.WriteLine(Executor.AveragePrice());
        }
    }
}
