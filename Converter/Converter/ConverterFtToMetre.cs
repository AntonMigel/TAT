namespace Converters
{
    class ConverterFtToMetre : IConverter
    {
        public double Convert(double inputvalue)
        {
            return inputvalue * 3.2808;
        }
    }
}
