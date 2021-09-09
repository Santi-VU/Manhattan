using Manhattan.Interfaces;
using Manhattan.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan.Models
{
    class Point : IDistanceMeassurement
    {
        private string _point;

        public Point(string Point) {
            _point = Point;
        }

        public int Calculate(Point Point1, Point Point2, MathService MathService)
        {
            var p1 = Point1._point.Split(",");
            var p2 = Point2._point.Split(",");

            int n1 = Int32.Parse(p1[0]) - Int32.Parse(p2[0]);
            int n2 = Int32.Parse(p1[1]) - Int32.Parse(p2[1]);

            n1 = MathService.AbsoluteValue(n1);
            n2 = MathService.AbsoluteValue(n2);

            return n1 + n2;
        }

        private int PrivateCalculate(Point Point1, Point Point2)
        {
            var p1 = Point1._point.Split(",");
            var p2 = Point2._point.Split(",");

            int n1 = Int32.Parse(p1[0]) - Int32.Parse(p2[0]);
            int n2 = Int32.Parse(p1[1]) - Int32.Parse(p2[1]);

            return Math.Abs(n1) + Math.Abs(n2);
        }
    }
}
