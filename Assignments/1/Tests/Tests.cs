using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace Tester
{
    [TestClass]
    public class Tests
    {
        #region Problem 1

        [TestMethod]
        public void Problem1_PointClass_WithReturnValue()
        {
            // Instantiate the problem
            var target = new Problem1();

            // Set up the test
            int x = 5;
            int y = 10;
            var pointClass = new PointClass(x, y);
            var result = target.ReturnADoubledPointClass(pointClass);

            // Assert truths.
            Assert.IsNotNull(result);
            Assert.AreNotSame(result, pointClass);
            Assert.AreEqual(x * 2, pointClass.X);
            Assert.AreEqual(y * 2, pointClass.Y);
        }

        [TestMethod]
        public void Problem1_PointClass_SideAffecting()
        {
            // Instantiate the problem
            var target = new Problem1();

            // Set up the test
            int x = 5;
            int y = 10;
            var pointClass = new PointClass(x, y);
            target.DoubleTheTargetPointClass(pointClass);

            // Assert truths.
            Assert.IsNotNull(pointClass);
            Assert.AreEqual(x * 2, pointClass.X);
            Assert.AreEqual(y * 2, pointClass.Y);
        }

        [TestMethod]
        public void Problem1_PointStruct_WithReturnValue()
        {
            // Instantiate the problem
            var target = new Problem1();

            // Set up the test
            int x = 5;
            int y = 10;
            var pointStruct = new PointStruct(x, y);
            var result = target.ReturnADoubledPointStruct(pointStruct);

            // Assert truths.
            Assert.IsNotNull(result);
            Assert.AreNotSame(result, pointStruct);
            Assert.AreEqual(x * 2, pointStruct.X);
            Assert.AreEqual(y * 2, pointStruct.Y);
        }

        [TestMethod]
        public void Problem1_PointStruct_SideAffecting()
        {
            // Instantiate the problem
            var target = new Problem1();

            // Set up the test
            int x = 5;
            int y = 10;
            var pointStruct = new MutablePointStruct() { X = x, Y = y };
            var result = target.DoubleTheTargetPointStruct(pointStruct);

            // Assert truths.
            Assert.AreSame(result, pointStruct);
            Assert.AreEqual(x * 2, result.X);
            Assert.AreEqual(y * 2, result.Y);
        }

        [TestMethod]
        public void Problem1_FindTheBug()
        {
            var target = new Problem1();

            int x = 5;
            int y = 10;
            var pointStruct = new MutablePointStruct() { X = x, Y = y };
            var result = target.FindTheBug(pointStruct);

            Assert.AreEqual(x * 2, pointStruct.X);
            Assert.AreEqual(y * 2, pointStruct.Y);
            Assert.AreNotSame(pointStruct, result);
        }

        #endregion

        #region Problem 2



        #endregion
    }
}
