namespace Converters
{
    class ConverterMetreToFt : IConverter
    {
        const double Binder = 3.2808;
        public double Convert(double inputvalue)
        {
            return inputvalue / Binder;
        }
    }
}
