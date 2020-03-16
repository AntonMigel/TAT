
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
        /// <returns> count </returns>
        public int getCountDiffSymbol()
        {int number = 1, result = 1;
            if (LineProperty != null &&  LineProperty !=string.Empty)
            {
                for (int i = 0; i < LineProperty.Length-1; i++)
                {
                    if (LineProperty[i] != LineProperty[i + 1])
                    {
                        number++;
                    }
                    else
                    {
                        if (number > result)
                        {
                            result = number;
                        }

                        number = 1;
                    }
                }
                if (result > number)
                    return result;
                else
                    return number;
            }
            return 0;
        }
    }

}
