using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;

namespace KokoDajMu.Classes
{
    public class Album : IAlbum
    {
        public string Name { get; set; }
        public decimal AllSongsLength { get; }
        public List<Album> AlbumsList { get; set; }
        public List<Song> SongsList { get; set; }
        private List<Album> albumsList = new List<Album>();
        private List<Song> songsList = new List<Song>();

        public Album(string name)
        {
            this.Name = name;
        }

       
        public void PrintAlbums()
        {
            foreach (var album in this.albumsList)
            {
                Console.WriteLine(album);
            }
        }

        public void AddSongToAlbum()
        {
           
        }

        public decimal GetLengthOfAlbum(Album album)
        {
            decimal sumOfAllSongsLength = 0;

            foreach (var songLength in album.SongsList)
            {
                sumOfAllSongsLength += songLength.songLength;
            }

            return sumOfAllSongsLength;
        }

        public void PrintLengthOfAlbum(Album album)
        {
            Console.WriteLine("The length of all songs in Album {0} is: {1} minutes or {2} hours", album.Name,(double) GetLengthOfAlbum(album) / 60, (double) GetLengthOfAlbum(album) / 3600);
        }


        public void GetInfoForAlbum()
        {
           
        }

        public void PrintSongsInAlbum()
        {
            
        }
    }
}
