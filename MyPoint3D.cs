using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class MyPoint3D : MyPoint
    {
        public double Z { get; set; }

        public MyPoint3D(double x, double y, double z) : base(x, y)
        {
            Z = z;
        }

        public override double GetDistanceFromPoint(MyPoint point)
        {
            MyPoint3D newPoint = (MyPoint3D)point;

            return Math.Sqrt(Math.Pow(newPoint.X - X, 2) + Math.Pow(newPoint.Y - Y, 2) + Math.Pow(newPoint.Z - Z, 2));
        }
    }
}