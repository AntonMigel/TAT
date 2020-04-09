
namespace task_DEV_2._1
{
    class AddToBaseCommand : ICommand
    {
        DataBaseExecutor Executor { get; set; }
        CarProduct Product { get; set; }
        public AddToBaseCommand(DataBaseExecutor executor, CarProduct product)
        {
            Executor = executor;
            Product = product;
        }

        public void Execute()
        {
            Executor.AddToBase(Product);
        }
    }
}
