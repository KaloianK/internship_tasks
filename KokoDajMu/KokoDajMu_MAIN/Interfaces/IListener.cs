using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;

namespace KokoDajMu.Interfaces
{
    public interface IListener
    {
        public void CreatePlaylist(string playlistName);
        public void DeletePlaylist(Playlist playlist);
        public void AddAlbumInFavorite(Album album);
        public void AddAlbumInPlaylist(Album album);
        public void AddSongToPlaylist(Playlist playlistName, Song songName);
        public void AddSongToFavorite(Song song);
        public void PrintFavorites();
        public void PrintPlaylist();
        public void PrintPlaylistsByName();
    }
}
