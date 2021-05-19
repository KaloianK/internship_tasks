using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;
using System.Linq;

namespace KokoDajMu.Classes
{
    public class Artist : User, IArtist
    {
        private List<Album> albumsList = new List<Album>();
        private List<string> albumsNames = new List<string>();

        public Artist()
        {

        }

        public Artist(string username, string fullName, List<string> genres, List<string> albumsNames)
        {
            this.UserName = username;
            this.FullName = fullName;
            this.genres = genres;
            this.albumNames = albumsNames;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}\nUsername: {1}\nPassword: {2}\nDate of birth: {3}\nMusic genres: {4}\nAlbums: {5}",
                this.FullName, this.UserName, this.Password, this.DateOfBirth, String.Join(", ", this.genres.Select(genre => genre.Length).ToArray()),
                String.Join(", ", this.albumsList.Select(albums => albums.Name).ToArray()));
        }

        public void PrintAlbumsByName()
        {
            foreach (string albumName in this.albumsList.Select(albumNames => albumNames.Name).ToArray())
            {
                Console.WriteLine(String.Join(", ", albumName));
            }
        }

        public void CreateAlbum(string albumName, string genre, string releaseDate)
        {

            if (this.albumsList.Select(albumNames => albumNames.Name).Equals(albumName))
            {
                Console.WriteLine("Album with that name exists! Do you want to try different name?");
            }
            else
            {
                this.albumsList.Add(new Album(albumName, this.FullName, genre, releaseDate));
            }
        }

        public void RemoveAlbum(Album album)
        {
            if (this.albumsList.Contains(album))
            {
                this.albumsList.Remove(album);
            }
            else
            {
                throw new ArgumentException("Album {0} is not found!", album.Name);
            }
        }

        private Album GetAlbumByName(string name)
        {
            return this.albumsList.FirstOrDefault(album => album.Name.Equals(name));
        }

        public void AddSongToAlbum(string albumName, Song song)
        {
            Album album = GetAlbumByName(albumName);

            if (album != null)
            {
                if (album.songsList.Contains(song))
                {
                    Console.WriteLine("Song '{0}' is already in the '{1}'! The song was not added again!", song.Name, album.Name);
                }
                else
                {
                    album.songsList.Add(song);
                }
            }
            else
            {
                Console.WriteLine("Album with the name {0} does not exist", albumName);
            }

            AddSongGenreToArtistInfo(song);
        }

        public void RemoveSongFromAlbum(string albumName, Song song)
        {
            Album album = GetAlbumByName(albumName);

            if (album != null)
            {
                if (album.songsList.Contains(song))
                {
                    album.songsList.Remove(song);
                }
                else
                {
                    throw new ArgumentException(string.Format("Song {0} is not found in {1} album!", album.Name, song.Name));
                }
            }
            else
            {
                Console.WriteLine("Album with the name {0} does not exist", albumName);
            }
        }

        private void AddSongGenreToArtistInfo(Song song)
        {
            if (this.genres.Contains(song.Genre))
            {
                return;
            }
            else
            {
                this.genres.Add(song.Genre);
            }
        }
    }
}
