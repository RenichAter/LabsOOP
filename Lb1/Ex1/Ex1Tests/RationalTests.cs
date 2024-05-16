using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace Ex1.Tests
{
    [TestClass()]
    public class RationalTests
    {
        [TestMethod()]
        public void RationalTestSumm()
        {
            Rational Rational_test = new Rational(2, 4);
            Rational Rational_test2 = new Rational(2, 4);
            Rational Rational_check = new Rational(1, 1);
            Rational Rational_result = Rational_test + Rational_test2;
            Assert.IsTrue(Rational_check ==  Rational_result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Rational Rational_test = new Rational(2, 3);
            Rational Rational_test2 = new Rational(3, 4);
            Rational Rational_check = new Rational(1, 2);
            Rational Rational_result = Rational_test * Rational_test2;
            Assert.IsTrue(Rational_check == Rational_result);
        }

        [TestMethod()]
        public void EqualityTest()
        {
            Rational Rational_test = new Rational(1, 2);
            Rational Rational_test2 = new Rational(2, 4);
            bool TestBool = Rational_test == Rational_test2;
            Assert.IsTrue(TestBool);
        }
        [TestMethod()]
        public void NonEqualityTest()
        {
            Rational Rational_test = new Rational(1, 3);
            Rational Rational_test2 = new Rational(2, 4);
            bool TestBool = Rational_test != Rational_test2;
            Assert.IsTrue(TestBool);
        }

    }
}