using System;
using DivideAndConquer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DivideAndConquerTests
{
    [TestClass]
    public class TestRecursive
    {
        [TestMethod]
        public void Test_Valid()
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            MaxSubArrayRecursion s = new MaxSubArrayRecursion();
            int actual = 6;
            int res = s.MaxSubArrayRecursive(nums);
            Assert.AreEqual(actual, res);
        }

        [TestMethod]
        public void Test_AllNegative()
        {
            int[] nums = new int[] { -2, -3, -1, -5 };
            MaxSubArrayRecursion s = new MaxSubArrayRecursion();
            int actual = -1;
            int res = s.MaxSubArrayRecursive(nums);
            Assert.AreEqual(actual, res);
        }

        [TestMethod]
        public void Test_AllPositive()
        {
            int[] nums = new int[] { 2, 3, 1, 5 };
            MaxSubArrayRecursion s = new MaxSubArrayRecursion();
            int actual = 11;
            int res = s.MaxSubArrayRecursive(nums);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void Test_EmptyArray()
        {
            int[] nums = new int[] { };
            MaxSubArrayRecursion s = new MaxSubArrayRecursion();
            int actual = 0;
            int res = s.MaxSubArrayRecursive(nums);
            Assert.AreEqual(actual, res);
        }

    }
}
