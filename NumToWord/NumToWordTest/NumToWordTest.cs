using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumToWord;

namespace NumToWordTest
{
    [TestClass]
    public class NumToWordTest
    {
        public WebServiceNumToWord obj;
        [TestInitialize]
        public void TestInitialise()
        {
            obj = new WebServiceNumToWord();
        }

        [TestMethod]
        public void Verify_IfNumberAndName_ConvertingtoWord_Successfully()
        {
             
            // Arrange
            string name = "SampleName";
            string number = "123";
            string expectedResult = "SampleName One Hundred And Twenty Three  Only";


            // Act
            var actualResult = obj.ConvertNumbertoWord(name, number);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Verify_IfNumberAndName_Is_Null_Return_Successfully()
        {
            // Arrange
            string expectedResult = "You have entered invalid input";

            // Act
            var actualResult = obj.ConvertNumbertoWord(string.Empty, string.Empty);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
