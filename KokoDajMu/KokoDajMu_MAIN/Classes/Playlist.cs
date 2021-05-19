using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;

namespace KokoDajMu.Classes
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<Song> songList = new List<Song>();

        public Playlist(string name)
        {
            this.Name = name;
        }
    }
}
