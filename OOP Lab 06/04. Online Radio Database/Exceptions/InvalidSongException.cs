using System;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongException : Exception
    {
        public InvalidSongException() : base("Invalid song.")
        {
        }

        protected InvalidSongException(string message) : base(message)
        {
        }
    }
}
