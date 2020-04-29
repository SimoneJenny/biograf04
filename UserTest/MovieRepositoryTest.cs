using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserForTest;

namespace UserTest
{
    [TestClass]
    public class MovieRepositoryTest
    {
        [TestMethod]
        public void RetriveMovie()
        {
            //arrange
            var MovieRepos = new MovieRepository();
            var expected = new Movie(1) //userid = 1 her vil constructoren sætte det op for os
            {
                Tittle = "Dødens gab",
                Theater = "Palads",
                Rating = "3 stjerner"
        };

            //act
            var actual = MovieRepos.Retrive(1);

            //assert
            Assert.AreEqual(expected.Tittle, actual.Tittle);
            Assert.AreEqual(expected.Rating, actual.Rating);
            Assert.AreEqual(expected.Theater, actual.Theater);
        }
    }
}
