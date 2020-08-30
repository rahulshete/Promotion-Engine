using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace PromotionEngineTest
{
    [TestClass]
    public class UnitTestPromotionEngine
    {
        [TestMethod]
        public void TestMethod1()
        {
            PromotionEngineCalculator _PromotionEngineCalculator = new PromotionEngineCalculator();
            List<char> shoppingCart = new List<char>() { 'A', 'B', 'C' };
            decimal totalPrice = _PromotionEngineCalculator.CalculateTotalPrice(shoppingCart);
            Assert.AreEqual(totalPrice, 100.0M);
        }

        [TestMethod]
        public void TestMethod2()
        {
            PromotionEngineCalculator _PromotionEngineCalculator = new PromotionEngineCalculator();
            List<char> shoppingCart = new List<char>() { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C' };
            decimal totalPrice = _PromotionEngineCalculator.CalculateTotalPrice(shoppingCart);
            Assert.AreEqual(totalPrice, 370.0M);
        }

        [TestMethod]
        public void TestMethod3()
        {
            PromotionEngineCalculator _PromotionEngineCalculator = new PromotionEngineCalculator();
            List<char> shoppingCart = new List<char>() { 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'D' };
            decimal totalPrice = _PromotionEngineCalculator.CalculateTotalPrice(shoppingCart);
            Assert.AreEqual(totalPrice, 280.0M);
        }

        
    }
}
