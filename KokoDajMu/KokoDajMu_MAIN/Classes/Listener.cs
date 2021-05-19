using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;
using System.Linq;

namespace KokoDajMu.Classes
{
    public class Listener : User, IListener
    {
        public List<string> FavoriteSongs { get; set; }
        private List<Song> favoriteSongs = new List<Song>();
        private List<Song> songPlaylist = new List<Song>();
        private List<Playlist> playlists = new List<Playlist>();

        public Listener() { }

        public Listener(string username, string fullName, string dateOfBirth, List<string> genres, List<string> likedSongs)
        {
            this.UserName = username;
            this.FullName = fullName;
            this.DateOfBirth = dateOfBirth;
            this.genres = genres;
            this.FavoriteSongs = likedSongs;
        }

        public void PrintMyInfo()
        {
            Console.WriteLine("Name: {0}\nUsername: {1}\nPassword: {2}\nDate of birth: {3}\nFavorite genres: {4}\nFavorite Songs: {5}\nPlaylists: {6}",
                this.FullName, this.UserName, this.Password, this.DateOfBirth, String.Join(", ", this.genres.Select(genre => genre.Length).ToArray()),
                String.Join(", ", this.favoriteSongs.Select(songs => songs.Name).ToArray()), String.Join(", ", this.playlists.Select(playlistsNames => playlistsNames.Name).ToArray()));
        }

        public void AddAlbumInFavorite(Album album)
        {
            favoriteSongs.AddRange(album.songsList);
        }

        public void PrintFavorites()
        {
            foreach (Song song in this.favoriteSongs)
            {
                Console.WriteLine(String.Join(", ", song));
            }
        }

        public void AddAlbumInPlaylist(Album album)
        {
            this.songPlaylist.AddRange(album.songsList);
        }

        public void PrintPlaylist()
        {
            foreach (Song song in this.songPlaylist)
            {
                Console.WriteLine(String.Join(", ", song));
            }
        }

        public void CreatePlaylist(string playlistName)
        {
            if (playlists.Select(playlistNames => playlistNames.Name).Equals(playlistName))
            {
                throw new ArgumentException("Playlist with that name already exists!");
            }
            else
            {
                this.playlists.Add(new Playlist(playlistName));
            }
        }

        public void DeletePlaylist(Playlist playlist)
        {
            if (!this.playlists.Select(playlistNames => playlistNames.Name).Equals(playlist.Name))
            {
                throw new ArgumentException("Playlist with that name does not exist!");
            }
            else
            {
                this.playlists.Remove(playlist);
            }
        }

        public void PrintPlaylistsByName()
        {
            foreach (string playlistName in this.playlists.Select(playlistNames => playlistNames.Name).ToArray())
            {
                Console.WriteLine(String.Join(", ", playlistName));
            }
        }

        public void AddSongToFavorite(Song song)
        {
            if (this.favoriteSongs.Contains(song))
            {
                throw new ArgumentException("The song {0} already exists!", song.Name);
            }
            else
            {
                this.favoriteSongs.Add(song);
            }
        }

        public void AddSongToPlaylist(Playlist playlist, Song song)
        {
            if (this.playlists.Contains(playlist))
            {
                if (playlist.songList.Contains(song))
                {
                    throw new ArgumentException(String.Format("The song {0} already exists in {1} playlist!", song.Name, playlist.Name));
                }
                else
                {
                    playlist.songList.Add(song);
                }
            }
            else
            {
                this.playlists.Add(playlist);
                playlist.songList.Add(song);
            }
        }
    }
}
