using Manhattan.Interfaces;
using Manhattan.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan.Models
{
    class IntPoint : IDistanceMeassurementPrivate
    {
        private int _x;
        private int _y;

        public IntPoint(int X, int Y)
        {
            this._x = X;
            this._y = Y;
        }

        public int Calculate(IntPoint Point1, IntPoint Point2, MathService MathService)
        {

            int n1 = Point1._x - Point2._x;
            int n2 = Point1._y - Point2._y;

            n1 = MathService.AbsoluteValue(n1);
            n2 = MathService.AbsoluteValue(n2);

            return n1 + n2;
        }

        private int PrivateCalculate(IntPoint Point1, IntPoint Point2)
        {

            int n1 = Point1._x - Point2._x;
            int n2 = Point1._y - Point2._x;

            return Math.Abs(n1) + Math.Abs(n2);
        }
    }
}
