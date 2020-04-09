using System;

namespace task_DEV_2._1
{
    class CountAllCommand : ICommand
    {
        DataBaseExecutor Executor { get; set; }
        public CountAllCommand(DataBaseExecutor executor)
        {
            Executor = executor;
        }
        public void Execute()
        {
            Console.WriteLine(Executor.CountAll());
        }
    }
}
