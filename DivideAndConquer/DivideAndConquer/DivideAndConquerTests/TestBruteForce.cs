using System;
using DivideAndConquer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DivideAndConquerTests
{
    [TestClass]
    public class TestBruteForce
    {
        [TestMethod]
        public void TestBruteForce_Valid()
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            BruteForce s = new BruteForce();
            int actual = 6;
            int res = s.MaxSubArray(nums);
            Assert.AreEqual(actual, res);
        }

        [TestMethod]
        public void TestBruteForce_AllNegative()
        {
            int[] nums = new int[] { -2, -3, -1, -5 };
            BruteForce s = new BruteForce();
            int actual = -1;
            int res = s.MaxSubArray(nums);
            Assert.AreEqual(actual, res);
        }

        [TestMethod]
        public void TestBruteForce_AllPositive()
        {
            int[] nums = new int[] { 2, 3, 1, 5 };
            BruteForce s = new BruteForce();
            int actual = 11;
            int res = s.MaxSubArray(nums);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void TestBruteForce_EmptyArray()
        {
            int[] nums = new int[] { };
            BruteForce s = new BruteForce();
            int actual = 0;
            int res = s.MaxSubArray(nums);
            Assert.AreEqual(actual, res);
        }
    }
}
