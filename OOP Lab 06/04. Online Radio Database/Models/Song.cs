using System;
using OnlineRadioDatabase.Exceptions;

namespace OnlineRadioDatabase.Models
{
    public class Song
    {
        private string artist;
        private string name;
        private int minutes;
        private int seconds;

        public string Artist
        {
            get => artist;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 20)
                    throw new InvalidArtistNameException();
                artist = value;
            }
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 30)
                    throw new InvalidSongNameException();
                name = value;
            }
        }

        private int Minutes
        {
            set
            {
                if (value < 0 || value > 14)
                    throw new InvalidSongMinutesException();
                minutes = value;
            }
        }

        private int Seconds
        {
            set
            {
                if (value < 0 || value > 59)
                    throw new InvalidSongSecondsException();
                seconds = value;
            }
        }

        public TimeSpan Length => new TimeSpan(0, minutes, seconds);

        public Song(string artist, string name, int minutes, int seconds)
        {
            Artist = artist;
            Name = name;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
