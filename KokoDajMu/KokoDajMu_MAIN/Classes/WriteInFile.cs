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
            TextWriter convertUserListInTextFile = new StreamWriter(Constants.PATH_TO_USER_LIST_TEXTFILE);

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
            TextWriter convertListenerListInTextFile = new StreamWriter(Constants.PATH_TO_LISTENER_LIST_TEXTFILE);

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
            TextWriter convertArtistListInTextFile = new StreamWriter (Constants.PATH_TO_ARTIST_LIST_TEXTFILE);

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
            TextWriter convertAlbumListInTextFile = new StreamWriter(Constants.PATH_TO_ALBUM_LIST_TEXTFILE);

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
            TextWriter convertSongListInTextFile = new StreamWriter(Constants.PATH_TO_SONG_LIST_TEXTFILE);

            using (convertSongListInTextFile)
            {
                foreach (Song song in this.songsList)
                {
                    convertSongListInTextFile.WriteLine("<song><{0}>[{1}]</song>", song.Name, song.SongDurationFromFile);
                }
            }
        }

        public void SaveAllFilesInOne()
        {
            StreamWriter textFileOverWritten = File.CreateText(Constants.PATH_TO_KOKO_DAJ_MU_OVERWIRTTEN_TEXTFILE);

            string[] userFile = File.ReadAllLines(Constants.PATH_TO_USER_LIST_TEXTFILE);
            string[] listenerFile = File.ReadAllLines(Constants.PATH_TO_LISTENER_LIST_TEXTFILE);
            string[] artistFile = File.ReadAllLines(Constants.PATH_TO_ARTIST_LIST_TEXTFILE);
            string[] albumFile = File.ReadAllLines(Constants.PATH_TO_ALBUM_LIST_TEXTFILE);
            string[] songFile = File.ReadAllLines(Constants.PATH_TO_SONG_LIST_TEXTFILE);

            using (textFileOverWritten)
            {
                for (int i = 0; i < userFile.Length || i < songFile.Length || i < albumFile.Length; i++)
                {
                    if (i < userFile.Length)
                    {
                        textFileOverWritten.WriteLine(userFile[i]);
                    }
                    if (i < listenerFile.Length)
                    {
                        textFileOverWritten.WriteLine(listenerFile[i]);
                    }
                    if (i < artistFile.Length)
                    {
                        textFileOverWritten.WriteLine(artistFile[i]);
                    }
                    if (i < albumFile.Length)
                    {
                        textFileOverWritten.WriteLine(albumFile[i]);
                    }
                    if (i < songFile.Length)
                    {
                        textFileOverWritten.WriteLine(songFile[i]);
                    }
                }
            }
        }
    }
}
