using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_04_Collections
{
    public struct Point: IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(Point otherPoint)
        {
            if (X != otherPoint.X)
            {
                return X.CompareTo(otherPoint.X);
            }
            else
            {
                return Y.CompareTo(otherPoint.Y);
            }

        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Point) || (obj == null)) return false;

            Point p = (Point)obj;

            return (X == p.X) && (Y == p.Y);
        }

        public override int GetHashCode()
        {
            return (X << 16 | X >> 16) ^ Y;
        }
    }

}
