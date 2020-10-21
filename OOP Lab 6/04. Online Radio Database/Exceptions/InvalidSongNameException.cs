namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException()
            : base("Song name should be between 3 and 30 symbols.")
        {
        }
    }
}
