using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Circle : Figure
    {
        private double radius;
        const double Pi = 3.14;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            //return 3.14 * radius * radius;
            return Pi * radius * radius;
        }
    }
}
