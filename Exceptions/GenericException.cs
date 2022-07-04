namespace EstudosGerais.Exceptions
{
    public class GenericException : Exception
    {
        public GenericException(string message) : base(message)
        {

        }

        public GenericException() : base()
        {

        }

        public GenericException(string message, Exception exception) : base(message, exception)
        {

        }

    }
}
