using System;

namespace Converters
{
    class FactoryCreator
    {
        static public IConverterFactory CreateSpecificFactory(string command)
        {

            switch  (command)
            {
                case "CF":
                    {
                        return new ConverterCtoFfactory();
                    }
                case "FC":
                    {
                        return new ConverterFtoCfactory();
                    }
                case "FM":
                    {
                        return new ConverterFtToMetrefactory();
                    }
                case "MF":
                    {
                        return new ConverterMetreToFtfactory();
                    }
                default:
                    {
                        throw new ArgumentException();
                    }
            }
        }
    }
}