using System.IO;
using System.Xml.Linq;

namespace task_DEV_2._1
{
    class Xml
    {
        public static void UpgradeXmlData(CarProduct product) 
        {
            string filename = "ProductDataBase.xml";

            XElement element = null;

            using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                element = XElement.Load(stream);
            }

            element.Add(
                new XElement("CarProducts",
                    new XElement("brand", product.Brand),
                    new XElement("model", product.Model),
                    new XElement("count", product.Count),
                    new XElement("price", product.Price)));
            element.Save(filename);
        }   
    }
}
