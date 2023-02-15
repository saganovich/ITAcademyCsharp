namespace L5_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Point.Count);
            Point pnt1 = new Point(-10, 10);
            Point pnt2 = new Point(5, 9);
            Point pnt3 = new Point(14, 14);
            Console.WriteLine(Point.LengthPoints(pnt1, pnt2));
            pnt2.X = 17;
            Console.WriteLine(Point.LengthPoints(pnt1, pnt2));
            Console.WriteLine(Point.LengthPoints(10, 15, 12, 4));
            Console.WriteLine(Point.Count);
            Line line = new Line(pnt1, pnt3);
            Console.WriteLine(line.Length);

        }
    }
}