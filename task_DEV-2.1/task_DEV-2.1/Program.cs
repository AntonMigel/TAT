using System;

namespace task_DEV_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Invoker console = new Invoker();
                console.Show();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
