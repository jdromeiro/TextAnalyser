using System;

namespace Domain.Services
{
    internal class TextEngineException : Exception
    {
        public TextEngineException(string message) : base(message)
        { }
    }
}
