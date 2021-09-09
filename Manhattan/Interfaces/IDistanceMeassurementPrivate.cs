using Manhattan.Models;
using Manhattan.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manhattan.Interfaces
{
    interface IDistanceMeassurementPrivate
    {
        public int Calculate(IntPoint Point1, IntPoint Point2, MathService MathService);
    }
}
