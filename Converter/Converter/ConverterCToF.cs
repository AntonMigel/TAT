namespace Converters
{
    class ConverterCToF : IConverter
    {
        const double firstBinder = 9 / 5;
        const int secondBinder = 32;
        public double Convert(double inputvalue)
        {
            return firstBinder * inputvalue  + secondBinder;
        }
    }
}
