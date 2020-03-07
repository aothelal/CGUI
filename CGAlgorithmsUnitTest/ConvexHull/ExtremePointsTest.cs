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
    public class ExtremePointsTest : ConvexHullTest
    {
        [TestMethod, Timeout(1000)]
        public void ExtremePointsTestCase1()
        {
            convexHullTester = new ExtremePoints();
            Case1();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsTestCase2()
        {
            convexHullTester = new ExtremePoints();
            Case2();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsTestCase3()
        {
            convexHullTester = new ExtremePoints();
            Case3();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsTestCase4()
        {
            convexHullTester = new ExtremePoints();
            Case4();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsTestCase6()
        {
            convexHullTester = new ExtremePoints();
            Case6();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsTestCase7()
        {
            convexHullTester = new ExtremePoints();
            Case7();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsTestCase8()
        {
            convexHullTester = new ExtremePoints();
            Case8();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsTestCase9()
        {
            convexHullTester = new ExtremePoints();
            Case9();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsTestCase10()
        {
            convexHullTester = new ExtremePoints();
            Case10();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsNormalTestCase20Points()
        {
            convexHullTester = new ExtremePoints();
            Case20Points();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsNormalTestCase40Points()
        {
            convexHullTester = new ExtremePoints();
            Case40Points();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsNormalTestCase60Points()
        {
            convexHullTester = new ExtremePoints();
            Case60Points();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsNormalTestCase80Points()
        {
            convexHullTester = new ExtremePoints();
            Case80Points();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsNormalTestCase100Points()
        {
            convexHullTester = new ExtremePoints();
            Case100Points();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsSpecialCaseTriangle()
        {
            convexHullTester = new ExtremePoints();
            SpecialCaseTriangle();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremePointsSpecialCaseConvexPolygon()
        {
            convexHullTester = new ExtremePoints();
            SpecialCaseConvexPolygon();
        }

    }
}
