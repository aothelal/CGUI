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
    public class GrahamScanTest : ConvexHullTest
    {
        [TestMethod, Timeout(1000)]
        public void GrahamScanTestCase1()
        {
            convexHullTester = new GrahamScan();
            Case1();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanTestCase2()
        {
            convexHullTester = new GrahamScan();
            Case2();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanTestCase3()
        {
            convexHullTester = new GrahamScan();
            Case3();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanTestCase4()
        {
            convexHullTester = new GrahamScan();
            Case4();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanTestCase6()
        {
            convexHullTester = new GrahamScan();
            Case6();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanTestCase8()
        {
            convexHullTester = new GrahamScan();
            Case8();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanTestCase9()
        {
            convexHullTester = new GrahamScan();
            Case9();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanTestCase10()
        {
            convexHullTester = new GrahamScan();
            Case10();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanNormalTestCase1000Points()
        {
            convexHullTester = new GrahamScan();
            Case1000Points();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanNormalTestCase2000Points()
        {
            convexHullTester = new GrahamScan();
            Case2000Points();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanNormalTestCase3000Points()
        {
            convexHullTester = new GrahamScan();
            Case3000Points();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanNormalTestCase4000Points()
        {
            convexHullTester = new GrahamScan();
            Case4000Points();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanNormalTestCase5000Points()
        {
            convexHullTester = new GrahamScan();
            Case5000Points();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanNormalTestCase10000Points()
        {
            convexHullTester = new GrahamScan();
            Case10000Points();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanSpecialCaseTriangle()
        {
            convexHullTester = new GrahamScan();
            SpecialCaseTriangle();
        }
        [TestMethod, Timeout(1000)]
        public void GrahamScanSpecialCaseConvexPolygon()
        {
            convexHullTester = new GrahamScan();
            SpecialCaseConvexPolygon();
        }
    }
}
