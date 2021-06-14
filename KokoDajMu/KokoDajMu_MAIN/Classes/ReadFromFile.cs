using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace KokoDajMu.Classes
{
    public class ReadFromFile
    {
        public List<User> GetUsersFromFile()
        {
            StreamReader reader = new StreamReader(@"\\files\Public\Transfer\Kaloian Karaivanov\Internship\internship_tasks\KokoDajMu\KokoDajMu_MAIN\TextDocuments\KokoDajMu.txt");
            Regex findUserInfo = new Regex(@"<user><(?<name>\w+)>\((?<password>\S{4,})\)\{(?<type>listener|artist)\}<\/user>");

            using (reader)
            {
                string text = reader.ReadToEnd();
                List<User> listOfUsers = new List<User>();

                Match userInfoFromFile = findUserInfo.Match(text);

                while (userInfoFromFile.Success)
                {
                    listOfUsers.Add(new User(userInfoFromFile.Groups["name"].Value, userInfoFromFile.Groups["password"].Value, userInfoFromFile.Groups["type"].Value));
                    userInfoFromFile = userInfoFromFile.NextMatch();
                }

                return listOfUsers;
            }
        }

        public List<Listener> GetListenersFromFile()
        {
            StreamReader reader = new StreamReader(Constants.PATH_TO_TEXT_FILES_TO_READ);
            Regex findListenersInfo = new Regex(@"<listener><(?<username>\w+)><(?<fullName>\D+)>\[(?<dateOfBirth>(\d+)\/(\d+)\/(\d+))\]\(genres: *\[(?<genres>\D+)\]\)\(likedSongs: *\[(?<likedSongs>\D+)\]\)\(playlists: *\[(?<playlists>\w+)*\]\)<\/listener>");

            using (reader)
            {
                string text = reader.ReadToEnd();
                List<Listener> listOfListeners = new List<Listener>();

                Match listenerInfoFromFile = findListenersInfo.Match(text);

                while (listenerInfoFromFile.Success)
                {
                    List<string> listOfGenresFromFile = new List<string>(listenerInfoFromFile.Groups["genres"].Value.Split(','));
                    List<string> listOfLikedSongsFromFile = new List<string>(listenerInfoFromFile.Groups["likedSongs"].Value.Split(','));

                    listOfListeners.Add(new Listener(listenerInfoFromFile.Groups["username"].Value,
                        listenerInfoFromFile.Groups["fullName"].Value,
                        listenerInfoFromFile.Groups["dateOfBirth"].Value,
                        listOfGenresFromFile,
                        listOfLikedSongsFromFile));

                    listenerInfoFromFile = listenerInfoFromFile.NextMatch();
                }

                return listOfListeners;
            }
        }

        public List<Artist> GetArtistFromFile()
        {
            StreamReader reader = new StreamReader(Constants.PATH_TO_TEXT_FILES_TO_READ);
            Regex findArtistInfo = new Regex(@"<artist><(?<username>\w+)><(?<fullName>\D+)>\[(\d+\/\d+\/\d+)\]\(genres: *\[(?<genres>\D+)\]\)\(albums: *\[(?<albums>\D+)\]\)<\/artist>");

            using (reader)
            {
                string text = reader.ReadToEnd();
                List<Artist> listOfArtists = new List<Artist>();

                Match artistInfoFromFile = findArtistInfo.Match(text);

                while (artistInfoFromFile.Success)
                {
                    List<string> listOfGenresFromFile = new List<string>(artistInfoFromFile.Groups["genres"].Value.Split(','));
                    List<string> listOfAlbumsFromFile = new List<string>(artistInfoFromFile.Groups["albums"].Value.Split(','));

                    listOfArtists.Add(new Artist(artistInfoFromFile.Groups["username"].Value,
                        artistInfoFromFile.Groups["fullName"].Value,
                        listOfGenresFromFile,
                        listOfAlbumsFromFile));

                    artistInfoFromFile = artistInfoFromFile.NextMatch();
                }

                return listOfArtists;
            }
        }

        public List<Song> GetSongFromFile()
        {
            StreamReader reader = new StreamReader(Constants.PATH_TO_TEXT_FILES_TO_READ);
            Regex findSongInfo = new Regex(@"<song><(?<songName>\D+)>\[(?<songDuration>\S+)\]<\/song>");

            using (reader)
            {
                string text = reader.ReadToEnd();
                List<Song> listOfSongs = new List<Song>();

                Match songInfoFromFile = findSongInfo.Match(text);

                while (songInfoFromFile.Success)
                {
                    listOfSongs.Add(new Song(songInfoFromFile.Groups["songName"].Value,
                        songInfoFromFile.Groups["songDuration"].Value));

                    songInfoFromFile = songInfoFromFile.NextMatch();
                }

                return listOfSongs;
            }
        }

        public List<Album> GetAlbumFromFile()
        {
            StreamReader reader = new StreamReader(Constants.PATH_TO_TEXT_FILES_TO_READ);
            Regex findAlbumInfo = new Regex(@"<album><(?<albumName>\D+ *)>\[(?<releaseYear>\d+)\]\(genres: *\[(?<albumGenres>\w+)\]\)\(songs: *\[(?<albumSongs>\D+)\]\)<\/album>");

            using (reader)
            {
                string text = reader.ReadToEnd();
                List<Album> listOfAlbum = new List<Album>();

                Match albumInfoFromFile = findAlbumInfo.Match(text);

                while (albumInfoFromFile.Success)
                {
                    List<string> listOfAlbumGenresFromFile = new List<string>(albumInfoFromFile.Groups["albumGenres"].Value.Split(','));
                    List<string> listOfAlbumSongsFromFile = new List<string>(albumInfoFromFile.Groups["albumSongs"].Value.Split(','));

                    listOfAlbum.Add(new Album(albumInfoFromFile.Groups["albumName"].Value,
                        albumInfoFromFile.Groups["releaseYear"].Value,
                        listOfAlbumGenresFromFile,
                        listOfAlbumSongsFromFile));

                    albumInfoFromFile = albumInfoFromFile.NextMatch();
                }

                return listOfAlbum;
            }
        }

        public void PrintAllInfoFromTxtFile()
        {
            Console.WriteLine("Result for Get User From File:\n");

            foreach (User users in GetUsersFromFile())
            {
                Console.WriteLine("Username: {0}\nPassword: {1}\nType: {2}\n", users.UserName, users.Password, users.Type);
            }

            Console.WriteLine("Result for Get Listeners From File:\n");

            foreach (Listener listeners in GetListenersFromFile())
            {
                Console.WriteLine("Username: {0}\nFull Name: {1}\nDate of birth: {2}\nGenres: {3}\nFavorite Songs: {4}\n",
                    listeners.UserName,
                    listeners.FullName,
                    listeners.DateOfBirth,
                    String.Join(", ", listeners.genres.Select(genre => genre).ToArray()),
                    String.Join(", ", listeners.FavoriteSongs.Select(favSong => favSong).ToArray()));
            }

            Console.WriteLine("Result for Get Artist From File:\n");

            foreach (Artist artist in GetArtistFromFile())
            {
                Console.WriteLine("Username: {0}\nFull Name: {1}\nGenres: {2}\nAlbums: {3}\n",
                    artist.UserName,
                    artist.FullName,
                    String.Join(", ", artist.genres.Select(genre => genre).ToArray()),
                    String.Join(", ", artist.albumNames.Select(albumName => albumName).ToArray()));
            }

            Console.WriteLine("Result for Get Album From File:\n");

            foreach (Album album in GetAlbumFromFile())
            {
                Console.WriteLine("Album name: {0}\nRelease date: {1}\nGenres: {2}\nAlbum songs: {3}\n",
                    album.Name,
                    album.ReleaseDate,
                    String.Join(", ", album.genresList.Select(genre => genre).ToArray()),
                    String.Join(", ", album.songsListNames.Select(albumName => albumName).ToArray()));
            }

            Console.WriteLine("Result for Get Song From File:\n");

            foreach (Song song in GetSongFromFile())
            {
                Console.WriteLine("Song name: {0}\nSong Duration: {1}\n", song.Name, song.SongDurationFromFile);
            }
        }
    }
}
