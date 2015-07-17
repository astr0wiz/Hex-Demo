using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex1.core
{
    public struct PointU16
    {
        public UInt16 X;
        public UInt16 Y;

        public PointU16(UInt16 x, UInt16 y)
        {
            X = x;
            Y = y;
        }

        public Point ToPoint()
        {
            return new Point((int)X, (int)Y);
        }

        public override bool Equals(object obj)
        {
            return obj is PointU16 && this == (PointU16)obj;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 29 + X.GetHashCode();
                hash = hash * 29 + Y.GetHashCode();
                return hash;
            }
        }
        public static bool operator ==(PointU16 a, PointU16 b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        public static bool operator !=(PointU16 a, PointU16 b)
        {
            return !(a == b);
        }
    }
}
