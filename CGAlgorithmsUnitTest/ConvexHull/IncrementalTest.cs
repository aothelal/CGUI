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
    public class IncrementalTest : ConvexHullTest
    {
        [TestMethod, Timeout(1000)]
        public void IncrementalTestCase1()
        {
            convexHullTester = new Incremental();
            Case1();
        }
        [TestMethod, Timeout(1000)]
        public void IncrementalTestCase2()
        {
            convexHullTester = new Incremental();
            Case2();
        }
        [TestMethod, Timeout(1000)]
        public void IncrementalTestCase3()
        {
            convexHullTester = new Incremental();
            Case3();
        }
        [TestMethod, Timeout(1000)]
        public void IncrementalTestCase4()
        {
            convexHullTester = new Incremental();
            Case4();
        }
        [TestMethod, Timeout(1000)]
        public void IncrementalTestCase8()
        {
            convexHullTester = new Incremental();
            Case8();
        }
        [TestMethod, Timeout(1000)]
        public void IncrementalTestCase9()
        {
            convexHullTester = new Incremental();
            Case9();
        }
        [TestMethod, Timeout(1000)]
        public void IncrementalTestCase10()
        {
            convexHullTester = new Incremental();
            Case10();
        }
        [TestMethod, Timeout(1000)]
        public void IncrementalTestCase11()
        {
            convexHullTester = new Incremental();
            Case11();
        }

        [TestMethod, Timeout(1000)]
        public void IncrementalSpecialCaseTriangle()
        {
            convexHullTester = new Incremental();
            SpecialCaseTriangle();
        }
        [TestMethod, Timeout(1000)]
        public void IncrementalSpecialCaseConvexPolygon()
        {
            convexHullTester = new Incremental();
            SpecialCaseConvexPolygon();
        }
    }
}
