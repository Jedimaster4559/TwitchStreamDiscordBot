using System;
using System.Runtime.Serialization;

namespace TwitchAnnouncerBot.DataObjects
{
    [Serializable]
    internal class StreamNotFoundException : Exception
    {
        public StreamNotFoundException()
        {
        }

        public StreamNotFoundException(string message) : base(message)
        {
        }

        public StreamNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StreamNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}