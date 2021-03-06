﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex1.core
{
    public class Layout
    {
        private Orientation _orientation;

        internal Orientation _Orientation
        {
            get { return _orientation; }
            set { _orientation = value; }
        }
        private PointD _cellSize;

        public PointD CellSize
        {
            get { return _cellSize; }
            set { _cellSize = value; }
        }
        private PointD _origin;

        public PointD Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        public Layout(Orientation orientation, PointD size, PointD origin)
        {
            _orientation = orientation;
            _cellSize = size;
            _origin = origin;
        }

        public PointD HexToPixel(Hex sourceHex)
        {
            double X = (_orientation.f0 * sourceHex.q + _orientation.f1 * sourceHex.r) * _cellSize.X;
            double Y = (_orientation.f2 * sourceHex.q + _orientation.f3 * sourceHex.r) * _cellSize.Y;
            return new PointD(X + _origin.X, Y + _origin.Y);
        }

        public FractionalHex PixelToHex(Point point)
        {
            return PixelToHex(new PointD((double)point.X, (double)point.Y));
        }

        public FractionalHex PixelToHex(PointD point)
        {
            PointD pt;
            pt.X = (point.X - _origin.X) / _cellSize.X;
            pt.Y = (point.Y - _origin.Y) / _cellSize.Y;
            double q = _orientation.b0 * pt.X + _orientation.b1 * pt.Y;
            double r = _orientation.b2 * pt.X + _orientation.b3 * pt.Y;
            return new FractionalHex(q, r, -q - r);
        }

        public PointD HexCornerOffset(int corner)
        {
            // Dont need this if we use Euclids : double angle = 2.0 * Math.PI * (corner + _orientation.StartAngleFactor) / 6;
            // ***********************************************************
            //
            // TODO: Since all angles here are multiples of 30, we need
            //       to replace the "trig" values below with SIN() and COS()
            //       functions of the proper Euclids[vec] value.  The 
            //       problem is how to determine the value of "vec"...
            //
            // ***********************************************************
            //System.Diagnostics.Debug.WriteLine(string.Format("HexCornerOffset angle calculated as: {0,12:0.00000000}",angle));

            // Using Utils.Euclids...

            int angle = (corner * 60) + Convert.ToInt32(_orientation.StartAngleFactor * 60);
            return new PointD(_cellSize.X * Utils.Euclids[angle].Cos, _cellSize.Y * Utils.Euclids[angle].Sin);
        }

        public List<Point> PolygonCorners(Hex polygon)
        {
            List<Point> corners = new List<Point>();
            PointD center = HexToPixel(polygon);
            for (int i = 0; i < 6; i++)
            {
                PointD offset = HexCornerOffset(i);
                corners.Add(new Point(Convert.ToInt32(center.X + offset.X), Convert.ToInt32(center.Y + offset.Y)));
            }
            return corners;
        }

        public List<PointD> PolygonCornersD(Hex polygon)
        {
            List<PointD> corners = new List<PointD>();
            PointD center = HexToPixel(polygon);
            for (int i = 0; i < 6; i++)
            {
                PointD offset = HexCornerOffset(i);
                corners.Add(new PointD(center.X + offset.X, center.Y + offset.Y));
            }
            return corners;
        }
    }
}
