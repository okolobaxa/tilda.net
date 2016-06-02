using System;

namespace TildaNET.Exceptions
{
    public class TildaException : Exception
    {
        public TildaException(string message) : base(message)
        {
        }
    }
}
