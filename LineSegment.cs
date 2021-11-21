using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class LineSegment
    {
        public MyPoint Point1 { get; set; }
        public MyPoint Point2 { get; set; }

        public LineSegment(MyPoint point1, MyPoint point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public LineSegment(double xA, double xB, double yA, double yB)
        {
            Point1 = new MyPoint(xA, xB);
            Point2 = new MyPoint(yA, yB);
        }

        public double Length()
        {
            return Point1.GetDistanceFromPoint(Point2);
        }
    }
}