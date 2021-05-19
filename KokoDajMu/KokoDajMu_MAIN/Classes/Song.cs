using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;
using System.Data;

namespace KokoDajMu.Classes
{
    public class Song
    {
        public string Name { get; set; }
        public decimal SongDuration { get; set; }
        public string SongDurationFromTXTFile { get; set; }
        public string ArtistName { get; set; }
        public string Genre { get; set; }
        public string DateOfRelease { get; set; }

        public Song(string name, decimal songLength, string artistName, string genre, string dateOfRelease)
        {
            this.Name = name;
            this.SongDuration = songLength;
            this.ArtistName = artistName;
            this.Genre = genre;
            this.DateOfRelease = dateOfRelease;
        }

        public Song(string songName, string songDuration)
        {
            this.Name = songName;
            this.SongDurationFromTXTFile = songDuration;
        }
    }
}
