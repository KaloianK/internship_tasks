using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NUnit.Framework;
using KokoDajMu.Classes;

namespace KokoDajMu.Test
{
    public class ListenersTests
    {
        [Test]
        public void CreatePlaylistNameIsFree()
        {
            //Arrange
            string playlistName = "Some Playlist Name";
            List<Playlist> playlistList = new List<Playlist>();
            Listener myListener = new Listener();

            //Act
            myListener.CreatePlaylist(playlistName);

            //Assert
            Assert.IsNotNull(playlistList);
        }

        [Test]
        public void CreatePlaylistNameIsNotFree()
        {
            //Arrange
            string playlistName = "Some Playlist Name";
            List<Playlist> playlistList = new List<Playlist>();
            Listener myListener = new Listener();

            //Act
            myListener.CreatePlaylist(playlistName);

            //Assert
            Assert.Throws<ArgumentException>(() => myListener.CreatePlaylist(playlistName)); // Needs To Be Changed
        }

        [Test]
        public void AddSongToFavorite()
        {
            //Arrange
            List<Song> favoritesSong = new List<Song>();
            Listener myListener = new Listener();
            Song mySong = new Song("Sicko Mode", "323");

            //Act
            myListener.AddSongToFavorite(mySong);

            //Assert
            Assert.IsNotNull(favoritesSong.Count);
        }

        [Test]
        public void AddSongToPlaylistDoesNotContaintSong()
        {
            //Arrange
            string playlistName = "Some Playlist Name";
            Playlist myPlaylist = new Playlist(playlistName);
            Song mySong = new Song("AstroThunder", "245");
            Listener myListener = new Listener();

            //Act
            myListener.AddSongToPlaylist(myPlaylist, mySong);

            //Assert
            Assert.Contains(mySong, myPlaylist.songList);
        }

        [Test]
        public void AddSongToPlaylistContainsSong()
        {
            //Arrange
            string playlistName = "Some Playlist Name";
            Playlist myPlaylist = new Playlist(playlistName);
            Song mySong = new Song("AstroThunder", "245");
            Listener myListener = new Listener();

            //Act
            myListener.AddSongToPlaylist(myPlaylist, mySong);

            //Assert
            Assert.Throws<ArgumentException>(() => myListener.AddSongToPlaylist(myPlaylist, mySong));
        }

        [Test]
        public void AddSongToPlaylistDoesNotContainPlaylist()
        {
            //Arrange
            string playlistName = "Some Playlist Name";
            Playlist myPlaylist = new Playlist(playlistName);
            Song mySong = new Song("AstroThunder", "245");
            Listener myListener = new Listener();

            //Act
            myListener.AddSongToPlaylist(myPlaylist, mySong);

            //Assert
            Assert.IsTrue(myListener.playlists.Contains(myPlaylist));
        }
    }
}
