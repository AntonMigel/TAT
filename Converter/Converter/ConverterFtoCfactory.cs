namespace Converters
{
    class ConverterFtoCfactory : IConverterFactory
    {
        public IConverter Create()
        {
            return new ConverterFtoC();
        }
    }
}
