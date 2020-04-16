using System.Collections.Generic;

namespace task_DEV_2._1
{
    class DataBaseProduct
    {
        private static DataBaseProduct instance;
        public List <CarProduct> ProductList;
        private DataBaseProduct()
        {
            ProductList = new List <CarProduct> ();
        }

        public static DataBaseProduct GetInstance()
        {
            if (instance == null)
            {
                instance = new DataBaseProduct();
            }
            return instance;
        }
    }
}
