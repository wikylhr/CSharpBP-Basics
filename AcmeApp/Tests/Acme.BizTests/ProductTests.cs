using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            //Arrange
            Product currentProduct = new Product();
            currentProduct.ProductID = 1;
            currentProduct.ProductName = "Pizza";
            currentProduct.Description = "A tasty mushroom and olives pizza.";
            string expected = "Hello Pizza (1): A tasty mushroom and olives pizza.";

            //Act
            string actual = currentProduct.SayHello();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHello_ParameteriazedConstructorTest()
        {
            //Arrange
            Product currentProduct = new Product(1, "Pizza", "A tasty mushroom and olives pizza.");
            
            string expected = "Hello Pizza (1): A tasty mushroom and olives pizza.";

            //Act
            string actual = currentProduct.SayHello();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHello_ObjectInitializerTest()
        {
            //Arrange
            Product currentProduct = new Product
            {
                ProductID = 1,
                ProductName = "Pizza",
                Description = "A tasty mushroom and olives pizza."
            };

            string expected = "Hello Pizza (1): A tasty mushroom and olives pizza.";

            //Act
            string actual = currentProduct.SayHello();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}