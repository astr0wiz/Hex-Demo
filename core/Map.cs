using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Hex1.core
{
    public enum MapShapes
    {
        Parallelogram,
        Triangle,
        Hexagon,
        Rectangle
    }
    public class Map
    {
        private PointU16 _mapSize;

        public UInt16 width
        {
            get { return _mapSize.X; }
        }
        public UInt16 height
        {
            get { return _mapSize.Y; }
        }
        public UInt16 radius
        {
            get { return (UInt16)(Math.Max(_mapSize.X, _mapSize.Y) >> 1); }
        }
        public UInt16 maxsize
        {
            get { return (UInt16)(Math.Max(Math.Abs(_mapSize.X), Math.Abs(_mapSize.Y))); }
        }

        public Layout mapLayout;
        public List<Hex> hexes;
        private MapShapes _shape = MapShapes.Rectangle;

        public Map(PointU16 mapSize, Orientation orientation, PointD cellSize, PointD origin, MapShapes mapShape = MapShapes.Rectangle)
        {
            _mapSize = mapSize;
            _shape = mapShape;
            mapLayout = new Layout(orientation, cellSize, origin);
            hexes = new List<Hex>();
        }

        public void Generate()
        {
            short q_, r_;

            switch (_shape)
            {
                case MapShapes.Rectangle:
                    for (short X = 0; X < height; X++)
                    {
                        short X_offset = (short)(X >> 1);
                        for (short Y = (short)(-X_offset); Y < width - X_offset; Y++)
                        {
                            q_ = X;
                            r_ = Y;
                            InsertCell(q_, r_);
                        }
                    }
                    break;
                case MapShapes.Hexagon:
                    for (short q = (short)(-radius); q <= radius; q++)
                    {
                        short r1 = (short)(Math.Max(-radius, -q - radius));
                        short r2 = (short)(Math.Min(radius, -q + radius));
                        for (short r = r1; r <= r2; r++)
                        {
                            InsertCell(q, r);
                        }
                    }
                    break;
                case MapShapes.Triangle:
                    switch (mapLayout._Orientation.type)
                    {
                        case OrientationType.PointyTop:
                            for (short q = 0; q <= maxsize; q++)
                            {
                                for (short r = 0; r <= maxsize - q; r++)
                                {
                                    InsertCell(q, r);
                                }
                            }
                            break;
                        case OrientationType.FlatTop:
                            for (short q = 0; q <= maxsize; q++)
                            {
                                for (short r = (short)(maxsize - q); r <= maxsize; r++)
                                {
                                    InsertCell(q, r);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case MapShapes.Parallelogram:
                    switch (mapLayout._Orientation.type)
                    {
                        case OrientationType.FlatTop:
                            for (short r = 0; r < maxsize; r++)
                            {
                                for (short s = 0; s < maxsize; s++)
                                {
                                    InsertCell((short)(-s - r), r);
                                }
                            }
                            break;
                        case OrientationType.PointyTop:
                            for (short s = 0; s < maxsize; s++)
                            {
                                for (short q = 0; q < maxsize; q++)
                                {
                                    InsertCell(q, (short)(-s - q));
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        public void InsertCell(short q, short r)
        {
            hexes.Add(new Hex(q, r));
        }

        public void DrawWin(Graphics graphics)
        {
            Pen pen = new Pen(Color.Green);
            foreach (Hex hex in hexes)
            {
                graphics.DrawPolygon(pen, mapLayout.PolygonCorners(hex).ToArray());
            }
            pen.Dispose();
        }
    }
}
