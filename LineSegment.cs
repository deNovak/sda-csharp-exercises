using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
	class LineSegment
	{
		public MyPoint A { get; set; }
		public MyPoint B { get; set; }



		public LineSegment(MyPoint a, MyPoint b)
		{
			A = a;
			B = b;
		}

		public LineSegment(double ax, double ay, double bx, double by)
		{
			A = new MyPoint(ax, ay);
			B = new MyPoint(bx, by);
		}

		public double Lenght()
		{
			return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
		}

	}
}