using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserForTest;

namespace UserTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void Retrive()
        {
            //arrange
            var OrderRepo = new orderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),

            };
            //act
            var actual = OrderRepo.Retrive(10);
            //assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
