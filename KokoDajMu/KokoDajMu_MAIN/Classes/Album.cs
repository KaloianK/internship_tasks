using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;
using System.Linq;

namespace KokoDajMu.Classes
{
    public class Album : IAlbum
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public List<Song> songsList = new List<Song>();
        public List<string> songsListNames = new List<string>();
        public List<string> genresList = new List<string>();

        public Album(string name)
        {
            this.Name = name;
        }

        public Album(string name, string artist, string genre, string releaseDate)
        {
            this.Name = name;
            this.Artist = artist;
            this.Genre = genre;
            this.ReleaseDate = releaseDate;
        }

        public Album(string name, string releaseYear, List<string> genres, List<string> albumSongs)
        {
            this.Name = name;
            this.ReleaseDate = releaseYear;
            this.genresList = genres;
            this.songsListNames = albumSongs;
        }

        public void AddSong(Song song)
        {
            if (this.songsList.Contains(song))
            {
                throw new ArgumentException(string.Format("Song {0} Already exists in the album {1}", song.Name, this.Name));
            }
            else
            {
                this.songsList.Add(song);
            }
        }

        private decimal GetDuration()
        {
            return this.songsList.Select(song => song.SongDuration).Sum();
        }

        public void PrintDuration()
        {
            Console.WriteLine("The duration of all songs in Album {0} is: {1} minutes or {2} hours", this.Name, (double)GetDuration() / 60, (double)GetDuration() / 3600);
        }

        public void GetInfo()
        {
            Console.WriteLine("Name: {0}\nArtist: {1}\nGenre: {2}\nDate Of Release: {3}\nAll Songs In {0}: {4}\nDuration: {5}",
                this.Name, this.Artist, this.Genre, this.ReleaseDate, String.Join(", ", this.songsList.Select(song => song.Name).ToArray()), GetDuration());
        }

        public void PrintSongs()
        {
            foreach (Song songs in this.songsList)
            {
                Console.WriteLine(String.Join(", ", songs));
            }
        }
    }
}
