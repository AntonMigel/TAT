namespace Converters
{
    class ConverterCToF : IConverter
    {
        public double Convert(double inputvalue)
        {
            return 9* inputvalue / 5 + 32;
        }
    }
}
