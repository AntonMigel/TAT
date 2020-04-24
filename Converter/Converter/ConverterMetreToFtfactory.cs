namespace Converters
{
    class ConverterMetreToFtfactory : IConverterFactory
    {
        public IConverter Create()
        {
            return new ConverterMetreToFt();
        }
    }
}
