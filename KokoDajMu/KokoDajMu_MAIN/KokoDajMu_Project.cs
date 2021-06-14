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
            ReadFromFile reader = new ReadFromFile();
            WriteInFile writer = new WriteInFile();

            writer.SaveUserListInTextFile();
            writer.SaveListenerListInTextFile();
            writer.SaveArtistListInTextFile();
            writer.SaveAlbumListInTextFile();
            writer.SaveSongListInTextFile();
            writer.SaveAllFilesInOne();

            List<Album> albums = reader.GetAlbumFromFile();
            List<Artist> artists = reader.GetArtistFromFile();
            List<Listener> listeners = reader.GetListenersFromFile();
            List<User> users = reader.GetUsersFromFile();
            List<Song> songs = reader.GetSongFromFile();
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

            reader.PrintAllInfoFromTxtFile();

            bool running = true;

            while (running)
            {
                Console.WriteLine("Possible commands to type:\n" +
                    "To get all information: file info\n" +
                    "To get album information: album info\n" +
                    "To get user information: user info\n" +
                    "To exit: exit\n");

                string command = Console.ReadLine();

                switch (command)
                {
                    case "file info":
                        reader.PrintAllInfoFromTxtFile();
                        break;

                    case "album info":
                        myAlbum.GetInfo();
                        break;

                    case "user info":
                        myUser.PrintInfo();
                        break;
                        
                    case "exit":
                        writer.SaveAllFilesInOne();
                        running = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
