using Microsoft.VisualStudio.TestTools.UnitTesting;
using Remap_Day9_MSTestingPracticeProblem;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
        public void TestMethod1()
        {
            //Arrange
            int[] arr = { 7, 5, 4, 7, 94, 1, 11 };
            int soldForOnce = 5;
            int soldMoreThanOnce = 7;
           // int[] expected = { soldForOnce, soldMoreThanOnce };

            //Act
            PriceList priceList = new PriceList();
            int[] actual = priceList.PriceListForSoldItem();

            //Assert
            Assert.AreEqual(actual[0], soldForOnce);
            Assert.AreEqual(actual[1], soldMoreThanOnce);



        }
    }
}
