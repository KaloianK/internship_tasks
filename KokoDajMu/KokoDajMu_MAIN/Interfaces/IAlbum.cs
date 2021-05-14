using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;

namespace KokoDajMu.Interfaces
{
    interface IAlbum
    {
        public void PrintAlbums();
        public void AddSongToAlbum();
        public decimal GetLengthOfAlbum(Album album);
        public void GetInfoForAlbum();
        public void PrintSongsInAlbum();

    }
}
