using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserForTest;

namespace UserTest
{
    [TestClass]
    public class UserRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //arrange
            var userRepos = new UserRepository();
            var expected = new Users(1) //userid = 1 her vil constructoren sætte det op for os
            {
                mailAddress = "myemail@live.dk",
                firstname= "Frode",
                lastname = "Nisse"
            };

            //act
            var actual = userRepos.Retrive(1);

            //assert
            Assert.AreEqual(expected.UsersId, actual.UsersId);
            Assert.AreEqual(expected.mailAddress, actual.mailAddress);
            Assert.AreEqual(expected.firstname, actual.firstname);
            Assert.AreEqual(expected.lastname, actual.lastname);

        }
    }
}
