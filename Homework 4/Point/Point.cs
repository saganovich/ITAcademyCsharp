using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Point
{
    internal class Point
    {
        private double coordX;
        private double coordY;
        private static uint count = 0;
        public static uint Count => count;
        public double X
        {
            get => coordX;
            set => coordX = value;
        }
        public double Y
        {
            get => coordY;
            set => coordY = value;
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
            count++;
        }
        public static double LengthPoints(Point pnt1, Point pnt2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(pnt1.coordX - pnt2.coordX, 2) + Math.Pow(pnt1.coordY - pnt2.coordY, 2)), 3);
        }
        public static double LengthPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 3);
        }
    }


}
