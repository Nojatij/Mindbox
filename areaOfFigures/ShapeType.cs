using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfFigures
{
    public abstract class ShapeType
    {
        public abstract double Area();
    }

    public class Circle : ShapeType
    {
        private readonly double radius;
        public Circle(double radius)
        {
            if (!double.IsNormal(radius) || radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "The number must be positive.");
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : ShapeType
    {
        private readonly double fstside;
        private readonly double sndside;
        private readonly double thrdside;
        public Triangle(double fstside, double sndside, double thrdside)
        {
            if (!double.IsNormal(fstside) || fstside <= 0)
                throw new ArgumentOutOfRangeException(nameof(fstside), "The number must be positive.");
            if (!double.IsNormal(sndside) || sndside <= 0)
                throw new ArgumentOutOfRangeException(nameof(sndside), "The number must be positive.");
            if (!double.IsNormal(thrdside) || thrdside <= 0)
                throw new ArgumentOutOfRangeException(nameof(thrdside), "The number must be positive.");
            this.fstside = fstside;
            this.sndside = sndside;
            this.thrdside = thrdside;
            if (fstside >= (sndside + thrdside) || sndside >= (fstside + thrdside) || thrdside >= (fstside + sndside))
                throw new ArgumentOutOfRangeException("There is no such triangle.");
        }

        public bool IsRight
        {
            get
            {
                double a = fstside;
                double b = sndside;
                double c = thrdside;
                if (b > c)
                {
                    (c, b) = (b, c);
                }
                if (a > c)
                {
                    (c, a) = (a, c);
                }
                return (c * c == b * b + a * a);
            }
        }

        public override double Area()
        {
            if (IsRight)
            {
                double a = fstside;
                double b = sndside;
                double c = thrdside;
                if (b > c)
                {
                    b = c;
                }
                if (a > c)
                {
                    a = c;
                }
                return b * a / 2;
            }
            else
            {
                double halfPer = (fstside + sndside + thrdside) / 2;
                return Math.Sqrt(halfPer * (halfPer - fstside) * (halfPer - sndside) * (halfPer - thrdside));
            }
        }
    }
}
