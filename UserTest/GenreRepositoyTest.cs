using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserForTest;

namespace UserTest
{
    [TestClass]
    public class GenreRepositoyTest
    {
        [TestMethod]
        public void RetriveGenre()
        {
            //arrange
            var GRepos = new GenreRepository();
            var expected = new Genre(1) 
            {
               GenreId =1
            };

            //act
            var actual = GRepos.Retrive(1);

            //assert
            Assert.AreEqual(expected.GenreId, actual.GenreId);
        }
    }
}
