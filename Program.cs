using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //LineSegment lineSegment1 = new LineSegment(2, 5, 5, 2);

            //MyPoint myPoint1 = new MyPoint(2, 5);
            //MyPoint myPoint2 = new MyPoint(5, 2);

            //LineSegment lineSegment2 = new LineSegment(myPoint1, myPoint2);

            //Console.WriteLine($"Line 1: {lineSegment1.Length()}\nLine 2: {lineSegment2.Length()}");

            MyPoint myPoint3D1 = new MyPoint3D(2, 5, 2);
            MyPoint myPoint3D2 = new MyPoint3D(1, 2, 1);

            LineSegment lineSegment3 = new LineSegment(myPoint3D1, myPoint3D2);

            Console.WriteLine(lineSegment3.Length());
        }
    }
}