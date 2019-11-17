using System;

namespace ExceptionHandling
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerExceptin) 
            : base(message, innerExceptin)
        {

        }
    }
}
