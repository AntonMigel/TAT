namespace Converters
{
    class ConverterFtoC : IConverter
    {
        public double Convert(double inputvalue)
        {
            return 5 * (inputvalue-32) / 9 ;
        }
    }
}
