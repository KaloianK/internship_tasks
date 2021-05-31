using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using KokoDajMu.Classes;
using System.Linq;

namespace KokoDajMu.Test
{
    public class ArtistTests
    {
        [Test]
        public void CreateAlbum()
        {
            //Arrange
            Artist myArtist = new Artist();
            string albumName = "Astroworld";
            string genre = "Hip-Hop";
            string releaseDate = "18/05/2018";
            Album newAlbum = new Album(albumName);

            //Act
            myArtist.CreateAlbum(albumName, genre, releaseDate);

            //Assert
            string albumNameTest = myArtist.albumsList.Select(names => names.Name).FirstOrDefault();
            Assert.AreEqual(albumName, albumNameTest);

            string genreName = myArtist.albumsList.Select(genres => genres.Genre).FirstOrDefault();
            Assert.AreEqual(genre, genreName);
        }

        [Test]
        public void RemoveAlbumShouldRemoveSpecifeid()
        {
            //Arrange
            List<string> genres = new List<string>();
            List<string> albums = new List<string>();
            string albumName = "Astroworld";
            string genre = "Hip-Hop";
            string releaseDate = "18/05/2018";
            string albumNameTest = "The OffSeason";
            string genreTest = "RnB";
            string releaseDateTest = "20/05/2021";
            Album myAlbum = new Album(albumName, "Travis Scott", genre, releaseDate);
            Album myAlbumTest = new Album(albumNameTest, "Travis Scott", genreTest, releaseDateTest);
            Artist myArtist = new Artist("Travis $cott", "Travis Scott", genres, albums);

            //Act
            myArtist.CreateAlbum(albumName, genre, releaseDate);
            myArtist.CreateAlbum(albumNameTest, genreTest, releaseDateTest);
            myArtist.RemoveAlbum(albumName);

            //Assert
            Assert.AreEqual(myArtist.albumsList.Count, 1);
            Assert.AreEqual(myArtist.albumsList.Select(names => names.Name).FirstOrDefault(name => name.Equals(albumNameTest)), albumNameTest);
        }

        [Test]
        public void RemoveAlbumShouldThrowError()
        {
            //Arrange
            List<string> genres = new List<string>();
            List<string> albums = new List<string>();
            string albumName = "Astroworld";
            string genre = "Hip-Hop";
            string releaseDate = "18/05/2018";
            string albumNameTest = "The OffSeason";
            string genreTest = "RnB";
            string releaseDateTest = "20/05/2021";
            Album myAlbum = new Album(albumName, "Travis Scott", genre, releaseDate);
            Album myAlbumTest = new Album(albumNameTest, "Travis Scott", genreTest, releaseDateTest);
            Artist myArtist = new Artist("Travis $cott", "Travis Scott", genres, albums);
            ArgumentException myExc = new ArgumentException("Album is not found!");

            //Act
            myArtist.CreateAlbum(albumName, genre, releaseDate);
            myArtist.CreateAlbum(albumNameTest, genreTest, releaseDateTest);
            myArtist.RemoveAlbum(albumName);

            //Assert
            Assert.Throws<ArgumentException>(() => myArtist.RemoveAlbum("Grenade"));
        }

        [Test]
        public void AddSongToAlbum()
        {
            //Arrange
            List<string> genres = new List<string>();
            List<string> albums = new List<string>();
            string albumName = "Astroworld";
            string genre = "Hip-Hop";
            string releaseDate = "18/05/2018";
            Artist myArtist = new Artist("Travis $cott", "Travis Scott", genres, albums);
            Song mySong = new Song("Sicko Mode", 323, myArtist.FullName, genre, "19/10/2018");

            //Act
            myArtist.CreateAlbum(albumName, genre, releaseDate);
            myArtist.AddSongToAlbum(albumName, mySong);

            //Assert
            Assert.IsTrue(myArtist.albumsList[0].songsList.Contains(mySong));
        }
    }
}
