using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;

namespace KokoDajMu.Interfaces
{
    public interface IArtist
    {
        public void CreateAlbum(string albumName, string genre, string releaseDate);
        public void RemoveAlbum(Album album);
        public void AddSongToAlbum(string albumName, Song song);
        public void RemoveSongFromAlbum(string albumName, Song song);
        public void PrintAlbumsByName();
    }
}
