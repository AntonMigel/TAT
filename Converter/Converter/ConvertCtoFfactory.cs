namespace Converters
{
    class ConverterCtoFfactory: IConverterFactory
    {
        public IConverter Create()
        {
            return new ConverterCToF();
        }
    }
}
