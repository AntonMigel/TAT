namespace Converters
{
    class ConverterMetreToFt : IConverter
    {
        public double Convert(double inputvalue)
        {
            return inputvalue / 3.2808;
        }
    }
}
