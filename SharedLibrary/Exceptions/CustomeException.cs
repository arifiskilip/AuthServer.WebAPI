using System;
using System.Runtime.Serialization;

namespace SharedLibrary.Exceptions
{
    public class CustomeException : Exception
    {
        public CustomeException(string message) : base(message)
        {
        }

        public CustomeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
