using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;

namespace KokoDajMu.Interfaces
{
    interface IAlbum
    {
        public void AddSong(Song song);
        public void GetInfo();
        public void PrintSongs();
    }
}
