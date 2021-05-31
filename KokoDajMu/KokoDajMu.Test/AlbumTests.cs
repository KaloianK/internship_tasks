using KokoDajMu.Classes;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using System;

namespace KokoDajMu.Test
{
    public class AlbumTests
    {
        [Test]
        public void AddSongIfSongIsNotAlreadyAdded()
        {
            //Arrange
            Album myAlbum = new Album("The OffSeason");
            Song mySong = new Song("My life", 219, "J Cole", "Hip-Hop", "14/05/2021");

            //Act
            myAlbum.AddSong(mySong);

            //Assert
            Assert.Contains(mySong, myAlbum.songsList);
        }

        [Test]
        public void AddSongIfSongIstAlreadyAdded()
        {
            //Arrange
            Album myAlbum = new Album("The OffSeason");
            Song mySong = new Song("My life", 219, "J Cole", "Hip-Hop", "14/05/2021");

            //Act
            myAlbum.AddSong(mySong);

            //Assert
            Assert.Throws<ArgumentException>(() => myAlbum.AddSong(mySong));
        }
    }
}