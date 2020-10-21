using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineRadioDatabase.Models
{
    public class RadioPlaylist
    {
        private readonly List<Song> songs;

        public int NumberOfSongs => songs.Count;

        public TimeSpan Length
            => songs.Aggregate(TimeSpan.Zero, (total, next) => total + next.Length);

        public RadioPlaylist()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }
    }
}
