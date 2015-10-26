using System;

namespace Patterns
{
    /// <summary>
    /// Represents error that occurs during pattern matching
    /// </summary>
    public class MatchException : ArgumentOutOfRangeException
    {
        /// <summary>
        /// Error message
        /// </summary>
        public new string Message { get; set; }

        internal MatchException(string message)
        {
            Message = message;
        }
    }
}
