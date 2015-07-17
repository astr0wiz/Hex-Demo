using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Hex1.core
{
    public struct FractionalHex
    {
        public double q;
        public double r;
        public double s;

        public FractionalHex(double q_, double r_, double s_)
        {
            q = q_;
            r = r_;
            s = s_;
        }
    }

    public class Hex
    {
        private short[] _v = { 0, 0, 0 };
        public short[] v { get { return _v; } }
        public short q { get { return _v[0]; } set { _v[0] = value; } }
        public short r { get { return _v[1]; } set { _v[1] = value; } }
        public short s { get { return _v[2]; } set { _v[2] = value; } }

        // standard cube style
        public Hex(short q_, short r_, short s_)
        {
            q = q_;
            r = r_;
            s = s_;
            Debug.Assert(q + r + s == 0);
        }

        // axial style
        public Hex(short q_, short r_)
        {
            q = q_;
            r = r_;
            s = (short)(-q_ - r_);
            Debug.Assert(q + r + s == 0);
        }

        // cube style using an array
        public Hex(short[] v_)
        {
            _v = v_;
            Debug.Assert(q + r + s == 0);
        }

        public short Length()
        {
            return (short)(
                Math.Abs(this.q) +
                Math.Abs(this.r) + 
                Math.Abs(this.s));
        }

        public short Distance(Hex target)
        {
            return (this - target).Length();
        }

        public Hex Neighbor(int direction)
        {
            return this + Hex.Direction(direction);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Hex))
            {
                return (this == (Hex)obj);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 29 + q.GetHashCode();
                hash = hash * 29 + r.GetHashCode();
                hash = hash * 29 + s.GetHashCode();
                return hash;
            }
        }

        public static bool operator ==(Hex h1, Hex h2)
        {
            return (h1.v[0] == h2.v[0]) && (h1.v[1] == h2.v[1]) && (h1.v[2] == h2.v[2]);
        }

        public static bool operator !=(Hex h1, Hex h2)
        {
            return !(h1 == h2);
        }

        public static Hex operator +(Hex h1, Hex h2)
        {
            return new Hex(
                (short)(h1.v[0] + h2.v[0]),
                (short)(h1.v[1] + h2.v[1]),
                (short)(h1.v[2] + h2.v[2]));
        }

        public static Hex operator -(Hex h1, Hex h2)
        {
            return new Hex(
                (short)(h1.v[0] - h2.v[0]),
                (short)(h1.v[1] - h2.v[1]),
                (short)(h1.v[2] - h2.v[2]));
        }

        public static Hex operator *(Hex h, short k)
        {
            return new Hex(
                (short)(h.v[0] * k),
                (short)(h.v[1] * k),
                (short)(h.v[2] * k));
        }

        public static Hex Direction(int d)
        {
            Debug.Assert(0 <= d && d <= 5);
            return Utils.Directions[d];
        }

        public static Hex Round(FractionalHex Fhex)
        {
            short q = (short)Math.Truncate(Fhex.q);
            short r = (short)Math.Truncate(Fhex.r);
            short s = (short)Math.Truncate(Fhex.s);
            double q_diff = Math.Abs((double)q - Fhex.q);
            double r_diff = Math.Abs((double)r - Fhex.r);
            double s_diff = Math.Abs((double)s - Fhex.s);
            if (q_diff > r_diff && q_diff > s_diff)
            {
                q = (short)(-r - s);
            }
            else if (r_diff > s_diff)
            {
                r = (short)(-q - s);
            }
            else
            {
                s = (short)(-q - r);
            }
            return new Hex(q, r, s);
        }
    }
}
