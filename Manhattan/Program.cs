using Manhattan.Models;
using Manhattan.Services;
using System;
using System.Reflection;

namespace Manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            DistanceService DistanceService = new DistanceService(); 
            MathService mathService = new MathService();

            Console.WriteLine("Introduzca coordenada 1");
            string Coord1 = Console.ReadLine();

            Console.WriteLine("Introduzca coordenada 2");
            string Coord2 = Console.ReadLine();

            Point Point1 = new Point(Coord1);
            Point Point2 = new Point(Coord2);
    
            // LLamada a methodo de clase POINT, que hereda por INTERFAZ
            DistanceService.ReturnDistance(Point1, Point2, mathService);

            // LLamada a metodo de clase POINT PRIVADO
            // Recuperamos el método, y se lo pasamos al service, pero que haga una llamada "externa"
            MethodInfo privMethod = Point1.GetType().GetMethod("PrivateCalculate", BindingFlags.NonPublic | BindingFlags.Instance);
            privMethod.Invoke(Point1, new object[] { Point1, Point2  });

            DistanceService.InvokeDistance(Point1, Point2, privMethod);

            /// Parte con enteros
            /// 
            IntPoint iPoint1 = new IntPoint(5, 4);
            IntPoint iPoint2 = new IntPoint(3, 2);

            DistanceService.ReturnDistanceIntPoint(iPoint1, iPoint2, mathService);
        } 
    }
}
