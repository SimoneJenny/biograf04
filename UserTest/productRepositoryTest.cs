using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserForTest;

namespace UserTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetriveTest()
        {
            //arrange
            var productRepo = new ProductRepository();
            var expected = new Product(2)
            {
                currentPrice = 15.88M,
                productDescription = "Description",
                ProductName = "ProductName"
            };
            //act
            var actual = productRepo.Retrive(2);
            //assert
            Assert.AreEqual(expected.currentPrice, actual.currentPrice);
            Assert.AreEqual(expected.productDescription, actual.productDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);

        }
    }
}
