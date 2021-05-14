using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;

namespace KokoDajMu.Classes
{
    public class Artist : User, IArtist
    {

        private List<Album> albumsList = new List<Album>();
        private List<Song> songsList = new List<Song>();


        public void AddAlbum(Album album)
        {
            //1. Check if album with same name exists and if so ask to rewrite or cancel
            if (!albumsList.Contains(album))
            {
                Console.WriteLine("Album does not exist! Do you want to try different name?");
                //Give chance to press yes or no.
                //If yes let user set another name for album.
            }
            else
            {
                //2. Add album to the List of Albums
                albumsList.Add(album);
            }

        }

        public void AddSong(Album album, Song song)
        {
            //1. Check if song is already in the album if yes print message that song is already in and dont add(prob)
            if (album.SongsList.Contains(song))
            {
                Console.WriteLine("Song '{0}' is already in the '{1}'! The song was not added again!", song.Name, album.Name);
            }
            else
            {
                //2. If not add song to Album
                album.SongsList.Add(song); //Function is NOT done!!!
            }


        }

        public void RemoveAlbum(Album album)
        {
            //1. If exists Remove()
            if (albumsList.Contains(album))
            {
                albumsList.Remove(album);
            }
            else
            {
                //2. If doesnt exist throw exception
                throw new ArgumentException("Album {0} is not found {1}!", album.Name);
            }
        }

        public void RemoveSong(Album album, Song song)
        {
            //1. If song's in album .Remove()
            if (album.SongsList.Contains(song))
            {
                album.SongsList.Remove(song);
            }
            else
            {
                //2. If not throw exception
                throw new ArgumentException(string.Format("Song {0} is not found in {1} album!", album.Name, song.Name));
            }
        }
    }
}
