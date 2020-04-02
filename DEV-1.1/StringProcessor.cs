
namespace DEV_1._1
{
    public class StringProcessor
    {
        private string _line;
        public StringProcessor(string arr)
        {
            Line = arr;
        }
        public string Line { get; set; }
        public int getCountDiffSymbol()
        {int number = 1, result = 1;
            if (String.IsNullOrEmpty(Line))
            {
                for (int i = 0; i < Line.Length-1; i++)
                {
                    if (Line[i] != Line[i + 1])
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
