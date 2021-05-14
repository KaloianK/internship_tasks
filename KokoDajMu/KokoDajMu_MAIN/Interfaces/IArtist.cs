using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;

namespace KokoDajMu.Interfaces
{
    public interface IArtist
    {
        public void AddAlbum(Album album);
        public void RemoveAlbum(Album album);
        public void AddSong(Album album, Song song);
        public void RemoveSong(Album album, Song song);
    }
}
