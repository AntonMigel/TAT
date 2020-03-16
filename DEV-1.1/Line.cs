using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1._1
{
    public class Line
    {
        private string _line;
        public Line(string arr)
        {
            LineProperty = arr;
        }
        public string LineProperty { get; set; }
        /// <summary>
        /// Get count of different symbol
        /// </summary>
        /// <returns></returns>
        public int getCountDiffSymbol()
        {
            int number = 0;
            if (LineProperty == null)
                return number;
            else
            {
                for (int i = 0; i < LineProperty.Length; i++)
                {

                    for (int j = i + 1; j < LineProperty.Length; j++)
                    {
                        if (LineProperty[i] == LineProperty[j])
                            number++;
                        break;
                    }
                }
                return LineProperty.Length - number;
            }
        }
    }

}