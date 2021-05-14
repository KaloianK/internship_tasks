using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;

namespace KokoDajMu.Classes
{
    public class Song
    {
        public string Name { get; set; }
        public decimal songLength { get; set; }
        public List<Song> SongsList { get; set; }
    }
}
