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
    public class ExtremeSegmentsTest : ConvexHullTest
    {

        #region ExtremeSegments
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsTestCase1()
        {
            convexHullTester = new ExtremeSegments();
            Case1();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsTestCase2()
        {
            convexHullTester = new ExtremeSegments();
            Case2();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsTestCase3()
        {
            convexHullTester = new ExtremeSegments();
            Case3();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsTestCase4()
        {
            convexHullTester = new ExtremeSegments();
            Case4();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsTestCase8()
        {
            convexHullTester = new ExtremeSegments();
            Case8();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsTestCase9()
        {
            convexHullTester = new ExtremeSegments();
            Case9();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsTestCase10()
        {
            convexHullTester = new ExtremeSegments();
            Case10();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsTestCase11()
        {
            convexHullTester = new ExtremeSegments();
            Case11();
        }

        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsNormalTestCase20Points()
        {
            convexHullTester = new ExtremeSegments();
            Case20Points();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsNormalTestCase40Points()
        {
            convexHullTester = new ExtremeSegments();
            Case40Points();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsNormalTestCase60Points()
        {
            convexHullTester = new ExtremeSegments();
            Case60Points();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsNormalTestCase80Points()
        {
            convexHullTester = new ExtremeSegments();
            Case80Points();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsNormalTestCase100Points()
        {
            convexHullTester = new ExtremeSegments();
            Case100Points();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsSpecialCaseTriangle()
        {
            convexHullTester = new ExtremeSegments();
            SpecialCaseTriangle();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsSpecialCaseCircle()
        {
            convexHullTester = new ExtremeSegments();
            SpecialCaseCircle();
        }
        [TestMethod, Timeout(1000)]
        public void ExtremeSegmentsSpecialCaseConvexPolygon()
        {
            convexHullTester = new ExtremeSegments();
            SpecialCaseConvexPolygon();
        }

        #endregion
    }
}
