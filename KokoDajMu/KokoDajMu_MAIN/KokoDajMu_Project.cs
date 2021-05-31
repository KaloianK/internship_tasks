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
            ReadFromFile test = new ReadFromFile();
            WriteInFile testWrite = new WriteInFile();

            testWrite.SaveUserListInTextFile();
            testWrite.SaveListenerListInTextFile();
            testWrite.SaveArtistListInTextFile();
            testWrite.SaveAlbumListInTextFile();
            testWrite.SaveSongListInTextFile();
            testWrite.SaveAllFilesInOne();

            List<Album> albums = test.GetAlbumFromFile();
            List<Artist> artists = test.GetArtistFromFile();
            List<Listener> listeners = test.GetListenersFromFile();
            List<User> users = test.GetUsersFromFile();
            List<Song> songs = test.GetSongFromFile();
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

            test.PrintAllInfoFromTxtFile();

            bool running = true;
            WriteInFile write = new WriteInFile();

            while (running)
            {
                string command = Console.ReadLine();

                switch (command)
                {

                    case "exit":
                        //write.overwriteFile();
                        running = false;
                        break;
                    default:
                        break;
                }
            }



        }
    }
}
