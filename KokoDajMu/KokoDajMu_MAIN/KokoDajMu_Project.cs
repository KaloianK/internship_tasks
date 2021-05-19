using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;


namespace KokoDajMu
{
    public class KokoDajMu_Project
    {
        static void Main()
        {
            List<Album> albums = new List<Album>();
            Artist myUser = new Artist();
            Song mySong = new Song("Sicko Mode", 312, "Travis Scott", "Hip-Hop", "21/08/2018");
            Album myAlbum = new Album("Astroworld");
            myAlbum.AddSong(mySong);

            Song song = new Song("Sicko Mode", 312, "Travis Scott", "Hip-Hop", "21/08/2018");
            myAlbum.AddSong(song);
            myAlbum.PrintSongs();
            myAlbum.PrintDuration();
            myAlbum.GetInfo();
            myUser.CreateAlbum("Astroworld", "Hip-Hop", "03/08/2018");

            ReadAndWrite test = new ReadAndWrite();

            test.PrintAllInfoFromTxtFile();
        }
    }
}
