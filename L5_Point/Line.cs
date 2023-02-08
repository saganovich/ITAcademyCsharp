using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Point
{
    internal class Line
    {
        private List<Point> points;
        private double length;
        public List<Point> Points
        {

            get => points;
            private set => points = value;
        }
        public double Length
        {
            get => length;
            private set => length = value;
        }
        public Line(Point point1, Point point2)
        {
            this.Points = new List<Point>();
            this.Points.Add(point1);
            this.Points.Add(point2);
            this.Length = Point.LengthPoints(point1, point2);
        }
    }

}
