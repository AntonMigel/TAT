using System;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV_2._1
{
    class DataBaseExecutor
    {
        private List<CarProduct> ProductList => DataBaseProduct.GetInstance().ProductList;

        public int CountAll()
        {
            return ProductList.Sum(x => x.Count);
        }

        public int CountTypes()
        {
            return ProductList.GroupBy(x => x.Brand).Count();
        }

        public double AveragePrice()
        {
            return ProductList.Average(x => x.Price);
        }

        public double AveragePriceType(string brand)
        {
            return ProductList.Where(x => String.Compare(x.Brand, brand) == 0).Average(x => x.Price);
        }

        public void AddToBase(CarProduct product)
        {
            Xml.UpgradeXmlData(product);
            ProductList.Add(product);
        }
    }
}
