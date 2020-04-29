using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserForTest;

namespace UserTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Users user = new Users
            {
                firstname = "Karen",
                Lastname = "Haekkesaks"

            };

            string expected = "Haekkesaks, Karen";

            string actual = user.Fullname;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastnameEmty()
        {
            //arrange
            Users user = new Users
            {
                Lastname = "Haekkesaks"

            };

            string expected = "Haekkesaks";
            //act
            string actual = user.Fullname;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstnameEmty()
        {
            //arrange
            Users user = new Users
            {
                firstname = "Karen"

            };

            string expected = "Karen";
            //act
            string actual = user.Fullname;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void staticTest()
        {
            //arrange
            var s1 = new Users();
            s1.firstname = "Rita";
            Users.InstanceCount += 1;

            var s2 = new Users();
            s2.firstname = "Torben";
            Users.InstanceCount += 1;

            var s3 = new Users();
            s1.firstname = "RIta";
            Users.InstanceCount += 1;

            //act
            //assert
            Assert.AreEqual(3, Users.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            //arrange
            var user = new Users
            {
                lastname = "Karen",
                mailAddress ="JeghedderKarenhaekkesaks"               
            };

            var expected = true;
            //act
            var actual = user.Validate();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //arrange
            var user = new Users
            {
                mailAddress = "JeghedderKarenhaekkesaks"
            };

            var expected = false;
            //act
            var actual = user.Validate();
            //assert
            Assert.AreEqual(expected, actual);
        }


}   }
