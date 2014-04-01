using System;

namespace Patterns
{
    public class MatchException : ArgumentOutOfRangeException
    {
        public new string Message { get; set; }

        public MatchException(string message)
        {
            Message = message;
        }
    }
}
