namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException()
            : base("Song minutes should be between 0 and 14.")
        {
        }
    }
}
