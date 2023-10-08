using Microsoft.VisualStudio.TestTools.UnitTesting;
using Remap_Day9_MSTestingPracticeProblem;
using System;

namespace SwapCompetetion_TestCase
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string word1 = "abcde";
            string word2 = "bcdea";
            bool expected1 = false;
            bool expected2 = true;

            //Act
            SwapCompetetion swapCompetetion = new SwapCompetetion();
            bool actual = swapCompetetion.CanRearrange(word1, word2);

            //Assert
           // Assert.AreEqual(expected1, actual);
           Assert.AreEqual(expected2, actual);
        }
    }
}
