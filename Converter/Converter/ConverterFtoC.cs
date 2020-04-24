namespace Converters
{
    class ConverterFtoC : IConverter
    {
        const double firstBinder = 5 / 9;
        const int secondBinder = 32;
        public double Convert(double inputvalue)
        {
            return firstBinder * (inputvalue- secondBinder) ;
        }
    }
}
