namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException()
            : base("Artist name should be between 3 and 20 symbols.")
        {
        }
    }
}