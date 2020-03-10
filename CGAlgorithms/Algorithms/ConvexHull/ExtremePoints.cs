using CGUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGAlgorithms.Algorithms.ConvexHull
{
    public class ExtremePoints : Algorithm
    {
        public override void Run(List<Point> points, List<Line> lines, List<Polygon> polygons, ref List<Point> outPoints, ref List<Line> outLines, ref List<Polygon> outPolygons)
        {
            bool[] removed = new bool[points.Count];
            for (int i = 0; i < removed.Length; i++)
                removed[i] = false;

            for (int p = 0; p < points.Count; p++)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    for (int j = 0; j < points.Count; j++)
                    {
                        for (int k = 0; k < points.Count; k++)
                        {
                            if (points[i] != points[j] && points[j] != points[k])
                            {
                                if (HelperMethods.PointInTriangle(points[p], points[i], points[j], points[k]) == Enums.PointInPolygon.Inside)
                                {
                                    removed[p] = true;
                                }
                            }
                        }
                    }
                }
            }

            for (int o = 0; o < points.Count; o++)
            {
                if (!removed[o])
                    outPoints.Add(points[o]);
            }
        }

        public override string ToString()
        {
            return "Convex Hull - Extreme Points";
        }
    }
}
