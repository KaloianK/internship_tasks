using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;

namespace KokoDajMu.Classes
{
    public class Listener : User, IListener
    {
        private List<Album> albumsList = new List<Album>();

        public void AddSongFromAlbumInFavorite()
        {
            //1. Get Song from Album And check if Song is already in Favorite
            //2. If true throw message song already in favorite and dont add
            //3. if not add song to list of favorite songs
        }

        public void AddSongFromAlbumInPlaylist()
        {
            //1. Get Song from Album And check if Song is already in playlist
            //2. If true throw message song already in playlist and dont add
            //3. if not add song to list of favorite songs

        }

        public void AddSongByNameInGenre()
        {
            //??????????
        }

        public void CreatePlaylist()
        {
            //1. Check if name is available and create if true
            //2. If false dont create / bring user back and ask for rename ??
        }

        public void DeletePlaylist()
        {
            //1. Check if Playlist name exists and delete if true
            //2. If false throw a message playlist does not exist
        }
    }
}
