using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGAlgorithms.Algorithms.ConvexHull;
using CGAlgorithms;
using CGUtilities;
using System.Collections.Generic;

namespace CGAlgorithmsUnitTest
{
    /// <summary>
    /// Unit Test for Convex Hull
    /// </summary>
    [TestClass]
    public class DivideAndConquerTest : ConvexHullTest
    {
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerTestCase1()
        {
            convexHullTester = new DivideAndConquer();
            Case1();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerTestCase2()
        {
            convexHullTester = new DivideAndConquer();
            Case2();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerTestCase3()
        {
            convexHullTester = new DivideAndConquer();
            Case3();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerTestCase4()
        {
            convexHullTester = new DivideAndConquer();
            Case4();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerTestCase6()
        {
            convexHullTester = new DivideAndConquer();
            Case6();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerTestCase7()
        {
            convexHullTester = new DivideAndConquer();
            Case7();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerTestCase8()
        {
            convexHullTester = new DivideAndConquer();
            Case8();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerTestCase9()
        {
            convexHullTester = new DivideAndConquer();
            Case9();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerTestCase10()
        {
            convexHullTester = new DivideAndConquer();
            Case10();
        }

        [TestMethod, Timeout(1000)]
        public void DivideAndConquerSpecialCaseConvexPolygon()
        {
            convexHullTester = new DivideAndConquer();
            SpecialCaseConvexPolygon();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerSpecialCaseTriangle()
        {
            convexHullTester = new DivideAndConquer();
            SpecialCaseTriangle();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerNormalTestCase4000Points()
        {
            convexHullTester = new DivideAndConquer();
            Case4000Points();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerNormalTestCase5000Points()
        {
            convexHullTester = new DivideAndConquer();
            Case5000Points();
        }
        [TestMethod, Timeout(1000)]
        public void DivideAndConquerNormalTestCase10000Points()
        {
            convexHullTester = new DivideAndConquer();
            Case10000Points();
        }
    }
}
