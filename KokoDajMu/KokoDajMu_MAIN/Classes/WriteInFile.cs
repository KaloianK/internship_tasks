using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace KokoDajMu.Classes
{
    public class WriteInFile
    {
        private static ReadFromFile reader = new ReadFromFile();
        private List<User> usersList = reader.GetUsersFromFile();
        private List<Listener> listenersList = reader.GetListenersFromFile();
        private List<Artist> artistsList = reader.GetArtistFromFile();
        private List<Album> albumsList = reader.GetAlbumFromFile();
        private List<Song> songsList = reader.GetSongFromFile();
        private User testUser = new User("Koko", "Koko2311", "Listener");
        private Listener testListener = new Listener();
        private Artist testArtist = new Artist();
        private Album testAlbum = new Album("KokoAlbum2021");
        private Song testSong = new Song("KokoMix2021", "36000");

        public void SaveUserListInTextFile()
        {
            TextWriter convertUserListInTextFile = new StreamWriter(@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\UserList.txt");

            using (convertUserListInTextFile)
            {
                foreach (User user in this.usersList)
                {
                    convertUserListInTextFile.WriteLine("<user><{0}>({1}){{{2}}}</user>", user.UserName, user.Password, user.Type);
                }
            }
        }

        public void SaveListenerListInTextFile()
        {
            TextWriter convertListenerListInTextFile = new StreamWriter(@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\ListenerList.txt");

            using (convertListenerListInTextFile)
            {
                foreach (Listener listener in this.listenersList)
                {
                    convertListenerListInTextFile.WriteLine("<listener><{0}><{1}>[{2}](genres: [{3}])(likedSongs: [{4}])(playlists: [{5}])</listener>",
                        listener.UserName, listener.FullName, listener.DateOfBirth, String.Join(", ", listener.genres), String.Join(", ", listener.FavoriteSongs), String.Join(", ", listener.playlists.Select(playlistNames => playlistNames.Name)));
                }
            }
        }

        public void SaveArtistListInTextFile()
        {
            TextWriter convertArtistListInTextFile = new StreamWriter(@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\ArtistList.txt");

            using (convertArtistListInTextFile)
            {
                foreach (Artist artist in this.artistsList)
                {
                    convertArtistListInTextFile.WriteLine("<artist><{0}><{1}>[{2}](genres:[{3}])(albums: [{4}])</artist>",
                        artist.UserName, artist.FullName, artist.DateOfBirth, String.Join(", ", artist.genres), String.Join(", ", artist.albumNames));
                }
            }
        }

        public void SaveAlbumListInTextFile()
        {
            TextWriter convertAlbumListInTextFile = new StreamWriter(@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\AlbumList.txt");

            using (convertAlbumListInTextFile)
            {
                foreach (Album album in this.albumsList)
                {
                    convertAlbumListInTextFile.WriteLine(" <album><{0}>[{1}](genres: [{2}])(songs: [{3}])<//album>",
                      album.Name, album.ReleaseDate, String.Join(", ", album.genresList), String.Join(", ", album.songsListNames));
                }
            }
        }

        public void SaveSongListInTextFile()
        {
            TextWriter convertSongListInTextFile = new StreamWriter(@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\SongList.txt");

            using (convertSongListInTextFile)
            {
                foreach (Song song in this.songsList)
                {
                    convertSongListInTextFile.WriteLine("<song><{0}>[{1}]</song>", song.Name, song.SongDurationFromTXTFile);
                }
            }
        }

        public void SaveAllFilesInOne()
        {
            StreamWriter allFilesWrittenHere = File.CreateText((@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\KokoDajMuOverWritten.txt"));

            string[] userFile = File.ReadAllLines((@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\UserList.txt"));
            string[] listenerFile = File.ReadAllLines((@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\ListenerList.txt"));
            string[] artistFile = File.ReadAllLines((@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\ArtistList.txt"));
            string[] albumFile = File.ReadAllLines((@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\AlbumList.txt"));
            string[] songFile = File.ReadAllLines((@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\SongList.txt"));

            using (allFilesWrittenHere)
            {
                for (int i = 0; i < userFile.Length || i < songFile.Length || i < albumFile.Length; i++)
                {
                    if (i < userFile.Length)
                    {
                        allFilesWrittenHere.WriteLine(userFile[i]);
                    }
                    if (i < listenerFile.Length)
                    {
                        allFilesWrittenHere.WriteLine(listenerFile[i]);
                    }
                    if (i < artistFile.Length)
                    {
                        allFilesWrittenHere.WriteLine(artistFile[i]);
                    }
                    if (i < albumFile.Length)
                    {
                        allFilesWrittenHere.WriteLine(albumFile[i]);
                    }
                    if (i < songFile.Length)
                    {
                        allFilesWrittenHere.WriteLine(songFile[i]);
                    }
                }
            }
        }
    }
}
