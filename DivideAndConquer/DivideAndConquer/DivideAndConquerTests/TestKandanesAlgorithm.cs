using System;
using DivideAndConquer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DivideAndConquerTests
{
    [TestClass]
    public class TestKandanesAlgorithm
    {
        [TestMethod]
        public void TestKandanesAlgo_Valid()
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            OrderOfNSolution s = new OrderOfNSolution();
            int actual = 6;
            int res = s.MaxSubArrayKadanesAlgo(nums);
            Assert.AreEqual(actual, res);
        }

        [TestMethod]
        public void TestKandanesAlgo_AllNegative()
        {
            int[] nums = new int[] { -2, -3, -1, -5 };
            OrderOfNSolution s = new OrderOfNSolution();
            int actual = -1;
            int res = s.MaxSubArrayKadanesAlgo(nums);
            Assert.AreEqual(actual, res);
        }

        [TestMethod]
        public void TestKandanesAlgo_AllPositive()
        {
            int[] nums = new int[] { 2, 3, 1, 5 };
            OrderOfNSolution s = new OrderOfNSolution();
            int actual = 11;
            int res = s.MaxSubArrayKadanesAlgo(nums);
            Assert.AreEqual(actual, res);
        }
        [TestMethod]
        public void TestKandanesAlgo_EmptyArray()
        {
            int[] nums = new int[] { };
            OrderOfNSolution s = new OrderOfNSolution();
            int actual = 0;
            int res = s.MaxSubArrayKadanesAlgo(nums);
            Assert.AreEqual(actual, res);
        }
    }
}
