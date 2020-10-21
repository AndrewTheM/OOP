using OnlineRadioDatabase.Exceptions;
using OnlineRadioDatabase.Models;
using System;

namespace OnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var playlist = new RadioPlaylist();
            int songsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < songsCount; ++i)
            {
                try
                {
                    var songInputs = Console.ReadLine().Split(';');

                    string artist = songInputs[0];
                    string name = songInputs[1];
                    var length = songInputs[2].Split(':');
                    int minutes = int.Parse(length[0]);
                    int seconds = int.Parse(length[1]);

                    var song = new Song(artist, name, minutes, seconds);
                    playlist.AddSong(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Songs added: {playlist.NumberOfSongs}");
            Console.WriteLine($"Playlist length: {playlist.Length:h'h 'm'm 's's'}");

            Console.ReadKey();
        }
    }
}
