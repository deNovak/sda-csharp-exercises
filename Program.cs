using System;

namespace sda_csharp_exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			MyPoint myPoint1 = new MyPoint(4, 7);
			MyPoint myPoint2 = new MyPoint(6, 9);

			LineSegment lineSegment1 = new LineSegment(myPoint1, myPoint2);
			LineSegment lineSegment2 = new LineSegment(6, 9, 4, 7);

			Console.WriteLine(lineSegment1.Lenght());

			Console.WriteLine(lineSegment2.Lenght());
		}
	}
}