namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException() : base("Invalid song length.")
        {
        }

        protected InvalidSongLengthException(string message) : base(message)
        {
        }
    }
}
