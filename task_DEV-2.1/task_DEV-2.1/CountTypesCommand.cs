using System;

namespace task_DEV_2._1
{
    class CountTypesCommand : ICommand
    {
        DataBaseExecutor Executor { get; set; }
        public CountTypesCommand(DataBaseExecutor executor)
        {
            Executor = executor;
        }
        public void Execute()
        {
            Console.WriteLine(Executor.CountTypes());
        }

    }
}
