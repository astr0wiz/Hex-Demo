using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex1.core
{
    public static class Utils
    {
        public static Dictionary<int, Euclid> Euclids = new Dictionary<int, Euclid>();

        public static Orientation LayoutPointy()
        {
            return new Orientation(
                Math.Sqrt(3.0), Math.Sqrt(3.0) / 2.0, 0.0, 3.0 / 2.0,
                Math.Sqrt(3.0) / 3.0, -1.0 / 3.0, 0.0, 2.0 / 3.0, 0.5,
                OrientationType.PointyTop);
        }

        public static Orientation LayoutFlat()
        {
            return new Orientation(
                3.0 / 2.0, 0.0, Math.Sqrt(3.0) / 2.0, Math.Sqrt(3.0),
                2.0 / 3.0, 0.0, -1.0 / 3.0, Math.Sqrt(3.0) / 3.0, 0.0,
                OrientationType.FlatTop);
        }

        public static List<Hex> Directions = new List<Hex>();

    }
}
