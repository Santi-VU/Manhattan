using Manhattan.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Manhattan.Services
{
    class DistanceService
    {
        public void ReturnDistance(Point Point1, Point Point2, MathService MathService) {
            Console.WriteLine("El resultado es: " + Point1.Calculate(Point1,  Point2, MathService).ToString());
        }

        public void ReturnDistanceIntPoint(IntPoint Point1, IntPoint Point2, MathService MathService)
        {
            Console.WriteLine("El resultado es: " + Point1.Calculate(Point1, Point2, MathService).ToString());
        }

        public void InvokeDistance(Point Point1, Point Point2, MethodInfo Method)
        {
            Console.WriteLine("El resultado es: " + Method.Invoke(Point1, new object[] { Point1, Point2 }).ToString());
        }
    }
}
