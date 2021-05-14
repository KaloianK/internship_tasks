using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;

namespace KokoDajMu.Interfaces
{
    public interface IListener
    {
        public void CreatePlaylist();
        public void DeletePlaylist();
        public void AddSongFromAlbumInFavorite();
        public void AddSongFromAlbumInPlaylist();
        public void AddSongByNameInGenre();
    }
}
