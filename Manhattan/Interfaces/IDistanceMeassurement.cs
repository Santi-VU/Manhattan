using Manhattan.Models;
using Manhattan.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan.Interfaces
{
    interface IDistanceMeassurement
    {
        public int Calculate(Point Point1, Point Point2, MathService MathService);
    }
}
