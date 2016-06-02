using System;

namespace tilda.net.Exceptions
{
    public class TildaException : Exception
    {
        public TildaException(string message) : base(message)
        {
        }
    }
}
