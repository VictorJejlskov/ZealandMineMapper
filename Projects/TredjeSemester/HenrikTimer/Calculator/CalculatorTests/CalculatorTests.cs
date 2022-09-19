using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AdditionTest()
        {
            Assert.AreEqual(6, Calculator.Add(2, 4));
            Assert.AreNotEqual(5, Calculator.Add(2, 4));
        }

        [TestMethod()]
        public void SubtractionTest()
        {
            Assert.AreEqual(2, Calculator.Subtract(6, 4));
            Assert.AreNotEqual(6, Calculator.Subtract(6, 4));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(12, Calculator.Multiply(3, 4));
            Assert.AreNotEqual(20, Calculator.Multiply(3, 4));
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(6, Calculator.Divide(36, 6));
            Assert.AreNotEqual(3, Calculator.Divide(36, 6));
        }
        [TestMethod]
        public void PowerOfTest()
        {
            Assert.AreEqual(16, Calculator.PowerOf(2, 4));
            Assert.AreNotEqual(20, Calculator.PowerOf(2, 4));
        }
        [TestMethod]
        public void CosinusTest()
        {
            Assert.AreEqual(0.96017028665, Calculator.Cosinus(6), 0.2);
            Assert.AreNotEqual(5, Calculator.Cosinus(3));
        }
        [TestMethod]
        public void SinusTest()
        {
            Assert.AreEqual(-0.27941549819, Calculator.Sinus(6), 0.2);
            Assert.AreNotEqual(5, Calculator.Sinus(2), 0.2);
        }
        [TestMethod]
        public void SquarerootTest()
        {
            Assert.AreEqual(7, Calculator.Squareroot(49));
            Assert.AreNotEqual(5, Calculator.Squareroot(30));
        }
        [TestMethod()]
        public void PiValueTest()
        {
            Assert.AreEqual(3.141592, Calculator.Pi(), 0.00002);
            Assert.AreNotEqual(5, Calculator.Pi(), 0.00002);
        }
    }
}