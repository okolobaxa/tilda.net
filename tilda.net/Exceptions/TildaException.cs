using System;

namespace tilda.net.Exceptions
{
    class TildaException : Exception
    {
        public TildaException(string message) : base(message)
        {
        }
    }
}
