namespace Converters
{
    class ConverterFtToMetrefactory : IConverterFactory
    {
        public IConverter Create()
        {
            return new ConverterFtToMetre();
        }
    }
}
